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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnretiro
            // 
            this.btnretiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnretiro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretiro.ForeColor = System.Drawing.Color.White;
            this.btnretiro.Location = new System.Drawing.Point(42, 98);
            this.btnretiro.Name = "btnretiro";
            this.btnretiro.Size = new System.Drawing.Size(166, 73);
            this.btnretiro.TabIndex = 0;
            this.btnretiro.Text = "Retiro de dinero";
            this.btnretiro.UseVisualStyleBackColor = false;
            this.btnretiro.Click += new System.EventHandler(this.btnretiro_Click);
            // 
            // btndeposito
            // 
            this.btndeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btndeposito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeposito.ForeColor = System.Drawing.Color.White;
            this.btndeposito.Location = new System.Drawing.Point(42, 200);
            this.btndeposito.Name = "btndeposito";
            this.btndeposito.Size = new System.Drawing.Size(166, 73);
            this.btndeposito.TabIndex = 1;
            this.btndeposito.Text = "Depositos";
            this.btndeposito.UseVisualStyleBackColor = false;
            this.btndeposito.Click += new System.EventHandler(this.btndeposito_Click);
            // 
            // btnretiroremesa
            // 
            this.btnretiroremesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnretiroremesa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretiroremesa.ForeColor = System.Drawing.Color.White;
            this.btnretiroremesa.Location = new System.Drawing.Point(42, 300);
            this.btnretiroremesa.Name = "btnretiroremesa";
            this.btnretiroremesa.Size = new System.Drawing.Size(166, 73);
            this.btnretiroremesa.TabIndex = 2;
            this.btnretiroremesa.Text = "Retirar remesa";
            this.btnretiroremesa.UseVisualStyleBackColor = false;
            this.btnretiroremesa.Click += new System.EventHandler(this.btnretiroremesa_Click);
            // 
            // btngenerarremesa
            // 
            this.btngenerarremesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btngenerarremesa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarremesa.ForeColor = System.Drawing.Color.White;
            this.btngenerarremesa.Location = new System.Drawing.Point(42, 398);
            this.btngenerarremesa.Name = "btngenerarremesa";
            this.btngenerarremesa.Size = new System.Drawing.Size(166, 73);
            this.btngenerarremesa.TabIndex = 3;
            this.btngenerarremesa.Text = "Generar remesa";
            this.btngenerarremesa.UseVisualStyleBackColor = false;
            this.btngenerarremesa.Click += new System.EventHandler(this.btngenerarremesa_Click);
            // 
            // btnservicios
            // 
            this.btnservicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnservicios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservicios.ForeColor = System.Drawing.Color.White;
            this.btnservicios.Location = new System.Drawing.Point(357, 200);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(166, 73);
            this.btnservicios.TabIndex = 4;
            this.btnservicios.Text = "Pago de servicios";
            this.btnservicios.UseVisualStyleBackColor = false;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // btnpagos
            // 
            this.btnpagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnpagos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagos.ForeColor = System.Drawing.Color.White;
            this.btnpagos.Location = new System.Drawing.Point(357, 300);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(166, 73);
            this.btnpagos.TabIndex = 5;
            this.btnpagos.Text = "Pago de prestamo";
            this.btnpagos.UseVisualStyleBackColor = false;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // btntransferencia
            // 
            this.btntransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btntransferencia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransferencia.ForeColor = System.Drawing.Color.White;
            this.btntransferencia.Location = new System.Drawing.Point(357, 98);
            this.btntransferencia.Name = "btntransferencia";
            this.btntransferencia.Size = new System.Drawing.Size(166, 73);
            this.btntransferencia.TabIndex = 6;
            this.btntransferencia.Text = "Transferencias";
            this.btntransferencia.UseVisualStyleBackColor = false;
            this.btntransferencia.Click += new System.EventHandler(this.btntransferencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banco de la Universidad \r\nNacional de El Salvador";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntransferencia);
            this.Controls.Add(this.btnpagos);
            this.Controls.Add(this.btnservicios);
            this.Controls.Add(this.btngenerarremesa);
            this.Controls.Add(this.btnretiroremesa);
            this.Controls.Add(this.btndeposito);
            this.Controls.Add(this.btnretiro);
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
        private System.Windows.Forms.Label label1;
    }
}