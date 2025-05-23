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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReCliente = new System.Windows.Forms.Button();
            this.btnReBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crea una nueva cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona una opcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registrarse como Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registrarse como Usuario de Banco";
            // 
            // btnReCliente
            // 
            this.btnReCliente.Location = new System.Drawing.Point(163, 287);
            this.btnReCliente.Name = "btnReCliente";
            this.btnReCliente.Size = new System.Drawing.Size(122, 51);
            this.btnReCliente.TabIndex = 4;
            this.btnReCliente.Text = "Registrarse";
            this.btnReCliente.UseVisualStyleBackColor = true;
            this.btnReCliente.Click += new System.EventHandler(this.btnReCliente_Click);
            // 
            // btnReBanco
            // 
            this.btnReBanco.Location = new System.Drawing.Point(556, 287);
            this.btnReBanco.Name = "btnReBanco";
            this.btnReBanco.Size = new System.Drawing.Size(123, 51);
            this.btnReBanco.TabIndex = 5;
            this.btnReBanco.Text = "Registrarse";
            this.btnReBanco.UseVisualStyleBackColor = true;
            this.btnReBanco.Click += new System.EventHandler(this.btnReBanco_Click);
            // 
            // SeleccionRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 514);
            this.Controls.Add(this.btnReBanco);
            this.Controls.Add(this.btnReCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRegistro";
            this.Text = "SeleccionRegistro";
            this.Load += new System.EventHandler(this.SeleccionRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReCliente;
        private System.Windows.Forms.Button btnReBanco;
    }
}