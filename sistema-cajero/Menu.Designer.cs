namespace sistema_cajero
{
    partial class Menu
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
            this.btnretiro = new System.Windows.Forms.Button();
            this.btndeposito = new System.Windows.Forms.Button();
            this.btnretiroremesa = new System.Windows.Forms.Button();
            this.btngenerarremesa = new System.Windows.Forms.Button();
            this.btnservicios = new System.Windows.Forms.Button();
            this.btnpagos = new System.Windows.Forms.Button();
            this.btntransferencia = new System.Windows.Forms.Button();
            this.btnmantenimiento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnretiro
            // 
            this.btnretiro.Location = new System.Drawing.Point(32, 137);
            this.btnretiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretiro.Name = "btnretiro";
            this.btnretiro.Size = new System.Drawing.Size(221, 90);
            this.btnretiro.TabIndex = 0;
            this.btnretiro.Text = "Retiro de dinero";
            this.btnretiro.UseVisualStyleBackColor = true;
            this.btnretiro.Click += new System.EventHandler(this.btnretiro_Click);
            // 
            // btndeposito
            // 
            this.btndeposito.Location = new System.Drawing.Point(32, 246);
            this.btndeposito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndeposito.Name = "btndeposito";
            this.btndeposito.Size = new System.Drawing.Size(221, 90);
            this.btndeposito.TabIndex = 1;
            this.btndeposito.Text = "Depositos";
            this.btndeposito.UseVisualStyleBackColor = true;
            this.btndeposito.Click += new System.EventHandler(this.btndeposito_Click);
            // 
            // btnretiroremesa
            // 
            this.btnretiroremesa.Location = new System.Drawing.Point(32, 358);
            this.btnretiroremesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretiroremesa.Name = "btnretiroremesa";
            this.btnretiroremesa.Size = new System.Drawing.Size(221, 90);
            this.btnretiroremesa.TabIndex = 2;
            this.btnretiroremesa.Text = "Retirar remesa";
            this.btnretiroremesa.UseVisualStyleBackColor = true;
            this.btnretiroremesa.Click += new System.EventHandler(this.btnretiroremesa_Click);
            // 
            // btngenerarremesa
            // 
            this.btngenerarremesa.Location = new System.Drawing.Point(32, 466);
            this.btngenerarremesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenerarremesa.Name = "btngenerarremesa";
            this.btngenerarremesa.Size = new System.Drawing.Size(221, 90);
            this.btngenerarremesa.TabIndex = 3;
            this.btngenerarremesa.Text = "Generar remesa";
            this.btngenerarremesa.UseVisualStyleBackColor = true;
            this.btngenerarremesa.Click += new System.EventHandler(this.btngenerarremesa_Click);
            // 
            // btnservicios
            // 
            this.btnservicios.Location = new System.Drawing.Point(789, 358);
            this.btnservicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(221, 90);
            this.btnservicios.TabIndex = 4;
            this.btnservicios.Text = "Pago de servicios";
            this.btnservicios.UseVisualStyleBackColor = true;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // btnpagos
            // 
            this.btnpagos.Location = new System.Drawing.Point(789, 466);
            this.btnpagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(221, 90);
            this.btnpagos.TabIndex = 5;
            this.btnpagos.Text = "Pago de prestamo";
            this.btnpagos.UseVisualStyleBackColor = true;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // btntransferencia
            // 
            this.btntransferencia.Location = new System.Drawing.Point(789, 246);
            this.btntransferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntransferencia.Name = "btntransferencia";
            this.btntransferencia.Size = new System.Drawing.Size(221, 90);
            this.btntransferencia.TabIndex = 6;
            this.btntransferencia.Text = "Transferencias";
            this.btntransferencia.UseVisualStyleBackColor = true;
            this.btntransferencia.Click += new System.EventHandler(this.btntransferencia_Click);
            // 
            // btnmantenimiento
            // 
            this.btnmantenimiento.Location = new System.Drawing.Point(789, 137);
            this.btnmantenimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmantenimiento.Name = "btnmantenimiento";
            this.btnmantenimiento.Size = new System.Drawing.Size(221, 90);
            this.btnmantenimiento.TabIndex = 7;
            this.btnmantenimiento.Text = "Mantenimiento";
            this.btnmantenimiento.UseVisualStyleBackColor = true;
            this.btnmantenimiento.Click += new System.EventHandler(this.btnmantenimiento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banco de la Universidad Nacional de El Salvador";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmantenimiento);
            this.Controls.Add(this.btntransferencia);
            this.Controls.Add(this.btnpagos);
            this.Controls.Add(this.btnservicios);
            this.Controls.Add(this.btngenerarremesa);
            this.Controls.Add(this.btnretiroremesa);
            this.Controls.Add(this.btndeposito);
            this.Controls.Add(this.btnretiro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretiro;
        private System.Windows.Forms.Button btndeposito;
        private System.Windows.Forms.Button btnretiroremesa;
        private System.Windows.Forms.Button btngenerarremesa;
        private System.Windows.Forms.Button btnservicios;
        private System.Windows.Forms.Button btnpagos;
        private System.Windows.Forms.Button btntransferencia;
        private System.Windows.Forms.Button btnmantenimiento;
        private System.Windows.Forms.Label label1;
    }
}