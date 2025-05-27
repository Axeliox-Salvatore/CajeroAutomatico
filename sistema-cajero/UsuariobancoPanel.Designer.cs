namespace sistema_cajero
{
    partial class UsuariobancoPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtNumeroCuentaB = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtMontoServicio = new System.Windows.Forms.TextBox();
            this.brnAgregarServicio = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDUIC = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.btnGenerarPrestamo = new System.Windows.Forms.Button();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtCorreoC = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.dgvCuentasExternas = new System.Windows.Forms.DataGridView();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEliminarServicios = new System.Windows.Forms.Button();
            this.btnEliminarCuantasEx = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.txtUsuarioCuenta = new System.Windows.Forms.TextBox();
            this.txtMontoCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasExternas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtMontoCuenta);
            this.groupBox7.Controls.Add(this.txtUsuarioCuenta);
            this.groupBox7.Controls.Add(this.txtBanco);
            this.groupBox7.Controls.Add(this.txtNumeroCuentaB);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox7.Location = new System.Drawing.Point(1190, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(350, 348);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Generar Cuenta Externa";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(102, 39);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(180, 34);
            this.txtBanco.TabIndex = 0;
            // 
            // txtNumeroCuentaB
            // 
            this.txtNumeroCuentaB.Location = new System.Drawing.Point(102, 103);
            this.txtNumeroCuentaB.MaxLength = 12;
            this.txtNumeroCuentaB.Name = "txtNumeroCuentaB";
            this.txtNumeroCuentaB.Size = new System.Drawing.Size(180, 34);
            this.txtNumeroCuentaB.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(129, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 35);
            this.button8.TabIndex = 2;
            this.button8.Text = "Generar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.cmbTipoServicio);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtNumeroCuenta);
            this.groupBox6.Controls.Add(this.txtMontoServicio);
            this.groupBox6.Controls.Add(this.brnAgregarServicio);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox6.Location = new System.Drawing.Point(794, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 354);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Agregar Servicios";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(100, 50);
            this.txtNumeroCuenta.MaxLength = 5;
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(180, 34);
            this.txtNumeroCuenta.TabIndex = 0;
            // 
            // txtMontoServicio
            // 
            this.txtMontoServicio.Location = new System.Drawing.Point(100, 106);
            this.txtMontoServicio.Name = "txtMontoServicio";
            this.txtMontoServicio.Size = new System.Drawing.Size(180, 34);
            this.txtMontoServicio.TabIndex = 1;
            // 
            // brnAgregarServicio
            // 
            this.brnAgregarServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.brnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAgregarServicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAgregarServicio.ForeColor = System.Drawing.Color.White;
            this.brnAgregarServicio.Location = new System.Drawing.Point(112, 307);
            this.brnAgregarServicio.Name = "brnAgregarServicio";
            this.brnAgregarServicio.Size = new System.Drawing.Size(110, 35);
            this.brnAgregarServicio.TabIndex = 2;
            this.brnAgregarServicio.Text = "Agregar";
            this.brnAgregarServicio.UseVisualStyleBackColor = false;
            this.brnAgregarServicio.Click += new System.EventHandler(this.brnAgregarServicio_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtDUIC);
            this.groupBox5.Controls.Add(this.txtMontoPrestamo);
            this.groupBox5.Controls.Add(this.btnGenerarPrestamo);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Location = new System.Drawing.Point(410, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 354);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prestamos";
            // 
            // txtDUIC
            // 
            this.txtDUIC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUIC.Location = new System.Drawing.Point(79, 50);
            this.txtDUIC.MaxLength = 9;
            this.txtDUIC.Name = "txtDUIC";
            this.txtDUIC.Size = new System.Drawing.Size(180, 34);
            this.txtDUIC.TabIndex = 0;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPrestamo.Location = new System.Drawing.Point(86, 114);
            this.txtMontoPrestamo.MaxLength = 7;
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(180, 34);
            this.txtMontoPrestamo.TabIndex = 1;
            // 
            // btnGenerarPrestamo
            // 
            this.btnGenerarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnGenerarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPrestamo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPrestamo.Location = new System.Drawing.Point(115, 307);
            this.btnGenerarPrestamo.Name = "btnGenerarPrestamo";
            this.btnGenerarPrestamo.Size = new System.Drawing.Size(110, 35);
            this.btnGenerarPrestamo.TabIndex = 2;
            this.btnGenerarPrestamo.Text = "Generar";
            this.btnGenerarPrestamo.UseVisualStyleBackColor = false;
            this.btnGenerarPrestamo.Click += new System.EventHandler(this.btnGenerarPrestamo_Click);
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpDatosCliente.Controls.Add(this.label2);
            this.grpDatosCliente.Controls.Add(this.label1);
            this.grpDatosCliente.Controls.Add(this.txtCorreoC);
            this.grpDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.grpDatosCliente.Controls.Add(this.btnModificarCliente);
            this.grpDatosCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDatosCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.grpDatosCliente.Location = new System.Drawing.Point(22, 30);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(350, 360);
            this.grpDatosCliente.TabIndex = 10;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del Cliente";
            // 
            // txtCorreoC
            // 
            this.txtCorreoC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoC.Location = new System.Drawing.Point(106, 53);
            this.txtCorreoC.Name = "txtCorreoC";
            this.txtCorreoC.Size = new System.Drawing.Size(180, 34);
            this.txtCorreoC.TabIndex = 0;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(106, 119);
            this.txtTelefonoCliente.MaxLength = 8;
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(180, 34);
            this.txtTelefonoCliente.TabIndex = 1;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(106, 309);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(110, 35);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeight = 29;
            this.dgvClientes.Location = new System.Drawing.Point(31, 459);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(700, 165);
            this.dgvClientes.TabIndex = 11;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.ColumnHeadersHeight = 29;
            this.dgvPrestamos.Location = new System.Drawing.Point(31, 724);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.Size = new System.Drawing.Size(700, 165);
            this.dgvPrestamos.TabIndex = 12;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.ColumnHeadersHeight = 29;
            this.dgvPagos.Location = new System.Drawing.Point(870, 459);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.Size = new System.Drawing.Size(700, 164);
            this.dgvPagos.TabIndex = 14;
            // 
            // dgvCuentasExternas
            // 
            this.dgvCuentasExternas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentasExternas.ColumnHeadersHeight = 29;
            this.dgvCuentasExternas.Location = new System.Drawing.Point(870, 724);
            this.dgvCuentasExternas.Name = "dgvCuentasExternas";
            this.dgvCuentasExternas.RowHeadersWidth = 51;
            this.dgvCuentasExternas.Size = new System.Drawing.Size(700, 165);
            this.dgvCuentasExternas.TabIndex = 15;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCliente.Location = new System.Drawing.Point(621, 643);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarCliente.TabIndex = 16;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEliminarServicios
            // 
            this.btnEliminarServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEliminarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicios.ForeColor = System.Drawing.Color.White;
            this.btnEliminarServicios.Location = new System.Drawing.Point(1414, 643);
            this.btnEliminarServicios.Name = "btnEliminarServicios";
            this.btnEliminarServicios.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarServicios.TabIndex = 17;
            this.btnEliminarServicios.Text = "Eliminar";
            this.btnEliminarServicios.UseVisualStyleBackColor = false;
            this.btnEliminarServicios.Click += new System.EventHandler(this.btnEliminarServicios_Click);
            // 
            // btnEliminarCuantasEx
            // 
            this.btnEliminarCuantasEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEliminarCuantasEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuantasEx.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCuantasEx.Location = new System.Drawing.Point(1414, 910);
            this.btnEliminarCuantasEx.Name = "btnEliminarCuantasEx";
            this.btnEliminarCuantasEx.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarCuantasEx.TabIndex = 18;
            this.btnEliminarCuantasEx.Text = "Eliminar";
            this.btnEliminarCuantasEx.UseVisualStyleBackColor = false;
            this.btnEliminarCuantasEx.Click += new System.EventHandler(this.btnEliminarCuantasEx_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnEliminarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(621, 910);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(110, 35);
            this.btnEliminarPrestamo.TabIndex = 24;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = false;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(9, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "N°Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(9, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Agua",
            "Luz",
            "Telefono"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(100, 172);
            this.cmbTipoServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(180, 39);
            this.cmbTipoServicio.TabIndex = 8;
            // 
            // txtUsuarioCuenta
            // 
            this.txtUsuarioCuenta.Location = new System.Drawing.Point(102, 171);
            this.txtUsuarioCuenta.Name = "txtUsuarioCuenta";
            this.txtUsuarioCuenta.Size = new System.Drawing.Size(180, 34);
            this.txtUsuarioCuenta.TabIndex = 3;
            // 
            // txtMontoCuenta
            // 
            this.txtMontoCuenta.Location = new System.Drawing.Point(102, 237);
            this.txtMontoCuenta.MaxLength = 6;
            this.txtMontoCuenta.Name = "txtMontoCuenta";
            this.txtMontoCuenta.Size = new System.Drawing.Size(180, 34);
            this.txtMontoCuenta.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Banco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "N°cuenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(6, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(6, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 23);
            this.label11.TabIndex = 9;
            this.label11.Text = "Monto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(32, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tabla Clientes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(866, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tabla Servicios";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(866, 689);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 23);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tabla Cuentas Externas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(32, 698);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 23);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tabla Prestamos";
            // 
            // UsuariobancoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.dgvCuentasExternas);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEliminarServicios);
            this.Controls.Add(this.btnEliminarCuantasEx);
            this.Name = "UsuariobancoPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariobancoPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsuariobancoPanel_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasExternas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtNumeroCuentaB;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtMontoServicio;
        private System.Windows.Forms.Button brnAgregarServicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDUIC;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.Button btnGenerarPrestamo;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.TextBox txtCorreoC;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.DataGridView dgvCuentasExternas;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEliminarServicios;
        private System.Windows.Forms.Button btnEliminarCuantasEx;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontoCuenta;
        private System.Windows.Forms.TextBox txtUsuarioCuenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}