using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_cajero
{
    public partial class UsuariobancoPanel: Form
    {
        public UsuariobancoPanel()
        {
            InitializeComponent();
        }
        private void CargarDatos()// creamos un metodo para cargar los datos de las tablas datagrid
        {
            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Cargar clientes
                    string consultaClientes = "SELECT DUI, Nombre, Apellido, Correo, Telefono, TipoCuenta, Saldo FROM Clientes";
                    MySqlDataAdapter adaptadorClientes = new MySqlDataAdapter(consultaClientes, conexion);
                    DataTable tablaClientes = new DataTable();
                    adaptadorClientes.Fill(tablaClientes);
                    dgvClientes.DataSource = tablaClientes;

                    // Cargar pagos
                    string consultaPagos = "SELECT NumeroPago, Tipo, Monto, Estado, Fecha FROM Pagos";
                    MySqlDataAdapter adaptadorPagos = new MySqlDataAdapter(consultaPagos, conexion);
                    DataTable tablaPagos = new DataTable();
                    adaptadorPagos.Fill(tablaPagos);
                    dgvPagos.DataSource = tablaPagos;

                    // Cargar prestamos
                    string consultaPrestamos = "SELECT ClienteID, MontoTotal, SaldoPendiente, Estado, Fecha FROM Prestamos";
                    MySqlDataAdapter adaptadorPrestamos = new MySqlDataAdapter(consultaPrestamos, conexion);
                    DataTable tablaPrestamos = new DataTable();
                    adaptadorPrestamos.Fill(tablaPrestamos);
                    dgvPrestamos.DataSource = tablaPrestamos;

                    // Cargar cuentas externas
                    string consultaCuentasExternas = "SELECT Banco, Cuenta, Usuario, Valor FROM CuentasExternas";
                    MySqlDataAdapter adaptadorCuentas = new MySqlDataAdapter(consultaCuentasExternas, conexion);
                    DataTable tablaCuentas = new DataTable();
                    adaptadorCuentas.Fill(tablaCuentas);
                    dgvCuentasExternas.DataSource = tablaCuentas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //modificacion cliente

        //cuando seleccione una celda en la tabla cliente
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                // Extraer datos por indice 
                txtDUIC.Text = fila.Cells["DUI"].Value?.ToString();//este es para el prestamo
                txtCorreoC.Text = fila.Cells[3].Value?.ToString();
                txtTelefonoCliente.Text = fila.Cells[4].Value?.ToString();
            }

        }


        // Boton para modificar cliente
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string duiCliente = dgvClientes.SelectedRows[0].Cells["DUI"].Value.ToString();
            string nuevoCorreo = txtCorreoC.Text.Trim();
            string nuevoTelefono = txtTelefonoCliente.Text.Trim();

            //  Validar que al menos un campo haya sido modificado
            if (string.IsNullOrWhiteSpace(nuevoCorreo) && string.IsNullOrWhiteSpace(nuevoTelefono))
            {
                MessageBox.Show("Ingrese al menos un dato para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Construir la consulta SQL  segun los campos ingresados
                    string actualizarCliente = "UPDATE Clientes SET ";
                    List<MySqlParameter> parametros = new List<MySqlParameter>();

                    if (!string.IsNullOrWhiteSpace(nuevoCorreo))
                    {
                        actualizarCliente += "Correo = @correo, ";
                        parametros.Add(new MySqlParameter("@correo", nuevoCorreo));
                    }
                    if (!string.IsNullOrWhiteSpace(nuevoTelefono))
                    {
                        actualizarCliente += "Telefono = @telefono, ";
                        parametros.Add(new MySqlParameter("@telefono", nuevoTelefono));
                    }

                    //
                    actualizarCliente = actualizarCliente.TrimEnd(',', ' ') + " WHERE DUI = @duiCliente";
                    parametros.Add(new MySqlParameter("@duiCliente", duiCliente));

                    MySqlCommand cmdActualizar = new MySqlCommand(actualizarCliente, conexion);
                    cmdActualizar.Parameters.AddRange(parametros.ToArray());
                    cmdActualizar.ExecuteNonQuery();
                }

                MessageBox.Show("Informacion actualizada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla para reflejar los cambios
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



        //boton eliminar cliente
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el DUI desde la fila seleccionada en DataGridView
            string duiCliente = dgvClientes.SelectedRows[0].Cells["DUI"].Value.ToString();

            // Confirmacion antes de eliminar
            DialogResult resultado = MessageBox.Show($"Esta seguro de que desea eliminar al cliente con DUI {duiCliente}?",
                                                     "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Eliminar el cliente de la base de datos
                    string eliminarCliente = "DELETE FROM Clientes WHERE DUI = @duiCliente";
                    MySqlCommand cmdEliminar = new MySqlCommand(eliminarCliente, conexion);
                    cmdEliminar.Parameters.AddWithValue("@duiCliente", duiCliente);
                    cmdEliminar.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla para reflejar los cambios
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //cargar todos los datos de los dgv
        private void UsuariobancoPanel_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }



        //geenerar prestamo
        private void btnGenerarPrestamo_Click(object sender, EventArgs e)
        {
            string duiCliente = txtDUIC.Text.Trim();
            string montoPrestamoStr = txtMontoPrestamo.Text.Trim();

            // Validar que los campos esten ingresados
            if (string.IsNullOrWhiteSpace(duiCliente) || string.IsNullOrWhiteSpace(montoPrestamoStr))
            {
                MessageBox.Show("Ingrese el DUI del cliente y el monto del prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el monto a decimal
            if (!decimal.TryParse(montoPrestamoStr, out decimal montoPrestamo) || montoPrestamo <= 0)
            {
                MessageBox.Show("Ingrese un monto valido para el prestamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Verificar que el cliente existe y obtener su ID
                    string verificarClienteQuery = "SELECT ID FROM clientes WHERE DUI = @duiCliente";
                    MySqlCommand cmdVerificarCliente = new MySqlCommand(verificarClienteQuery, conexion);
                    cmdVerificarCliente.Parameters.AddWithValue("@duiCliente", duiCliente);
                    object resultadoCliente = cmdVerificarCliente.ExecuteScalar();

                    if (resultadoCliente == null)
                    {
                        MessageBox.Show("El cliente con el DUI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int clienteID = Convert.ToInt32(resultadoCliente);

                    // Verificar si el cliente ya tiene un préstamo activo
                    string verificarPrestamoQuery = "SELECT COUNT(*) FROM prestamos WHERE ClienteID = @clienteID AND Estado = 'Activo'";
                    MySqlCommand cmdVerificarPrestamo = new MySqlCommand(verificarPrestamoQuery, conexion);
                    cmdVerificarPrestamo.Parameters.AddWithValue("@clienteID", clienteID);
                    int tienePrestamoActivo = Convert.ToInt32(cmdVerificarPrestamo.ExecuteScalar());

                    if (tienePrestamoActivo > 0)
                    {
                        MessageBox.Show("El cliente ya tiene un préstamo activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar préstamo con el `ID` correcto
                    string insertarPrestamoQuery = "INSERT INTO prestamos (ClienteID, MontoTotal, SaldoPendiente, Estado, Fecha) VALUES (@clienteID, @montoPrestamo, @montoPrestamo, 'Activo', NOW())";
                    MySqlCommand cmdInsertarPrestamo = new MySqlCommand(insertarPrestamoQuery, conexion);
                    cmdInsertarPrestamo.Parameters.AddWithValue("@clienteID", clienteID);
                    cmdInsertarPrestamo.Parameters.AddWithValue("@montoPrestamo", montoPrestamo);
                    cmdInsertarPrestamo.ExecuteNonQuery();
                }

                MessageBox.Show("Prestamo generado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla de prestamos
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el prestamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // eliminar prestamo
        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un prestamo en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ClienteID desde la fila seleccionada en 
            string clienteID = dgvPrestamos.SelectedRows[0].Cells["ClienteID"].Value.ToString();

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show($"¿Esta seguro de que desea eliminar el prestamo del Cliente {clienteID}?",
                                                     "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Eliminar el prestamo de la base de datos
                    string eliminarPrestamo = "DELETE FROM Prestamos WHERE ClienteID = @clienteID";
                    MySqlCommand cmdEliminar = new MySqlCommand(eliminarPrestamo, conexion);
                    cmdEliminar.Parameters.AddWithValue("@clienteID", clienteID);
                    cmdEliminar.ExecuteNonQuery();
                }

                MessageBox.Show("Prestamo eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla para reflejar los cambios
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el prestamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //generar servicio
        private void brnAgregarServicio_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumeroCuenta.Text.Trim();
            string montoStr = txtMontoServicio.Text.Trim();
            string tipoPago = cmbTipoServicio.SelectedItem?.ToString() ?? string.Empty;

            // Validar que los datos sean correctos
            if (string.IsNullOrWhiteSpace(numeroCuenta) || string.IsNullOrWhiteSpace(montoStr) || string.IsNullOrWhiteSpace(tipoPago))
            {
                MessageBox.Show("Ingrese el numero de cuenta, el monto y seleccione un tipo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el monto a decimal
            if (!decimal.TryParse(montoStr, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Validar que el nmero de cuenta no esté repetido
                    string verificarCuenta = "SELECT COUNT(*) FROM Pagos WHERE NumeroPago = @numeroCuenta";
                    MySqlCommand cmdVerificar = new MySqlCommand(verificarCuenta, conexion);
                    cmdVerificar.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);
                    int cuentaExiste = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (cuentaExiste > 0)
                    {
                        MessageBox.Show("El numero de cuenta ya tiene un pago registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar pago en la base de datos
                    string insertarPago = "INSERT INTO Pagos (NumeroPago, Monto, Tipo) VALUES (@numeroCuenta, @monto, @tipoPago)";
                    MySqlCommand cmdInsertar = new MySqlCommand(insertarPago, conexion);
                    cmdInsertar.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);
                    cmdInsertar.Parameters.AddWithValue("@monto", monto);
                    cmdInsertar.Parameters.AddWithValue("@tipoPago", tipoPago);
                    cmdInsertar.ExecuteNonQuery();
                }

                MessageBox.Show("Pago agregado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla de pagos
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Eliminar servicio
        private void btnEliminarServicios_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un pago en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el Numero de cuenta desde la fila seleccionada en DataGridView
            string numeroCuenta = dgvPagos.SelectedRows[0].Cells["NumeroPago"].Value.ToString();

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show($"¿Esta seguro de que desea eliminar el pago con cuenta {numeroCuenta}?",
                                                     "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Eliminar el pago de la base de datos
                    string eliminarPago = "DELETE FROM Pagos WHERE NumeroPago = @numeroCuenta";
                    MySqlCommand cmdEliminar = new MySqlCommand(eliminarPago, conexion);
                    cmdEliminar.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);
                    cmdEliminar.ExecuteNonQuery();
                }

                MessageBox.Show("Pago eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla de pagos
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // // Agregar cuenta externa
        private void button8_Click(object sender, EventArgs e)
        {
            string banco = txtBanco.Text.Trim();
            string cuenta = txtNumeroCuentaB.Text.Trim();
            string usuario = txtUsuarioCuenta.Text.Trim();
            string saldo = txtMontoCuenta.Text.Trim();

            // Validar que los datos sean correctos
            if (string.IsNullOrWhiteSpace(banco) || string.IsNullOrWhiteSpace(cuenta) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(saldo))
            {
                MessageBox.Show("Ingrese el banco, numero de cuenta, usuario y monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el monto a decimal
            if (!decimal.TryParse(saldo, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Validar que el numero de cuenta no este repetido en cuentas externas
                    string verificarCuenta = "SELECT COUNT(*) FROM CuentasExternas WHERE Cuenta = @cuenta";
                    MySqlCommand cmdVerificar = new MySqlCommand(verificarCuenta, conexion);
                    cmdVerificar.Parameters.AddWithValue("@cuenta", cuenta);
                    int cuentaExisteExterna = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    // Validar que el numero de cuenta no este repetido en cuentas internas
                    string verificarCuentaInterna = "SELECT COUNT(*) FROM CuentasExternas WHERE Cuenta = @cuenta";
                    MySqlCommand cmdVerificarInterna = new MySqlCommand(verificarCuentaInterna, conexion);
                    cmdVerificarInterna.Parameters.AddWithValue("@cuenta", cuenta);
                    int cuentaExisteInterna = Convert.ToInt32(cmdVerificarInterna.ExecuteScalar());

                    if (cuentaExisteExterna > 0 || cuentaExisteInterna > 0)
                    {
                        MessageBox.Show("El numero de cuenta ya existe en el sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar cuenta externa en la base de datos
                    string insertarCuenta = "INSERT INTO CuentasExternas (Banco, Cuenta, Usuario, Valor) VALUES (@banco, @cuenta, @usuario, @monto)";
                    MySqlCommand cmdInsertar = new MySqlCommand(insertarCuenta, conexion);
                    cmdInsertar.Parameters.AddWithValue("@banco", banco);
                    cmdInsertar.Parameters.AddWithValue("@cuenta", cuenta);
                    cmdInsertar.Parameters.AddWithValue("@usuario", usuario);
                    cmdInsertar.Parameters.AddWithValue("@monto", monto);
                    cmdInsertar.ExecuteNonQuery();
                }

                MessageBox.Show("Cuenta externa agregada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla de cuentas externas
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la cuenta externa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // // Eliminar cuenta externa
        private void btnEliminarCuantasEx_Click(object sender, EventArgs e)
        {
            if (dgvCuentasExternas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta externa en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el numero de cuenta desde la fila seleccionada en DataGridView
            string cuenta = dgvCuentasExternas.SelectedRows[0].Cells["Cuenta"].Value.ToString();

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show($"Esta seguro de que desea eliminar la cuenta {cuenta}?",
                                                     "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionDB.Conexion())
                {
                    conexion.Open();

                    // Eliminar la cuenta externa de la base de datos
                    string eliminarCuenta = "DELETE FROM CuentasExternas WHERE Cuenta = @cuenta";
                    MySqlCommand cmdEliminar = new MySqlCommand(eliminarCuenta, conexion);
                    cmdEliminar.Parameters.AddWithValue("@cuenta", cuenta);
                    cmdEliminar.ExecuteNonQuery();
                }

                MessageBox.Show("Cuenta externa eliminada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla de cuentas externas
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la cuenta externa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
