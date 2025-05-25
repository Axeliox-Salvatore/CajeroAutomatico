namespace sistema_cajero
{
    partial class SeleccionRegistro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReCliente = new System.Windows.Forms.Button();
            this.btnReBanco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(172, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona una opcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(158, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registrarse como Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(124, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registrarse como Usuario de Banco";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnReCliente
            // 
            this.btnReCliente.BackColor = System.Drawing.Color.DarkRed;
            this.btnReCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReCliente.ForeColor = System.Drawing.Color.White;
            this.btnReCliente.Location = new System.Drawing.Point(178, 259);
            this.btnReCliente.Name = "btnReCliente";
            this.btnReCliente.Size = new System.Drawing.Size(200, 51);
            this.btnReCliente.TabIndex = 4;
            this.btnReCliente.Text = "Registrarse";
            this.btnReCliente.UseVisualStyleBackColor = false;
            this.btnReCliente.Click += new System.EventHandler(this.btnReCliente_Click);
            // 
            // btnReBanco
            // 
            this.btnReBanco.BackColor = System.Drawing.Color.DarkRed;
            this.btnReBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReBanco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReBanco.ForeColor = System.Drawing.Color.White;
            this.btnReBanco.Location = new System.Drawing.Point(178, 423);
            this.btnReBanco.Name = "btnReBanco";
            this.btnReBanco.Size = new System.Drawing.Size(200, 51);
            this.btnReBanco.TabIndex = 5;
            this.btnReBanco.Text = "Registrarse";
            this.btnReBanco.UseVisualStyleBackColor = false;
            this.btnReBanco.Click += new System.EventHandler(this.btnReBanco_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnReBanco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(127, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 577);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label5.Location = new System.Drawing.Point(141, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Crear Nueva cuenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label6.Location = new System.Drawing.Point(69, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "CAJERO AUTOMÁTICO UES";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeleccionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.panel1);
            this.Name = "SeleccionRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionRegistro";
            this.Load += new System.EventHandler(this.SeleccionRegistro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReCliente;
        private System.Windows.Forms.Button btnReBanco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}