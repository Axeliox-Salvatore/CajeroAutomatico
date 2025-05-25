namespace sistema_cajero
{
    partial class Retiroremesa
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
            this.btnretirarremesa = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.mtxtcodremesa = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtdui = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnretirarremesa
            // 
            this.btnretirarremesa.BackColor = System.Drawing.Color.DarkRed;
            this.btnretirarremesa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirarremesa.ForeColor = System.Drawing.Color.White;
            this.btnretirarremesa.Location = new System.Drawing.Point(178, 475);
            this.btnretirarremesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretirarremesa.Name = "btnretirarremesa";
            this.btnretirarremesa.Size = new System.Drawing.Size(170, 45);
            this.btnretirarremesa.TabIndex = 21;
            this.btnretirarremesa.Text = "Retirar remesa";
            this.btnretirarremesa.UseVisualStyleBackColor = false;
            this.btnretirarremesa.Click += new System.EventHandler(this.btnretirarremesa_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(139, 412);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(250, 38);
            this.txtcantidad.TabIndex = 20;
            // 
            // mtxtcodremesa
            // 
            this.mtxtcodremesa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtcodremesa.Location = new System.Drawing.Point(139, 165);
            this.mtxtcodremesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtcodremesa.Mask = "00000000";
            this.mtxtcodremesa.Name = "mtxtcodremesa";
            this.mtxtcodremesa.Size = new System.Drawing.Size(250, 30);
            this.mtxtcodremesa.TabIndex = 22;
            this.mtxtcodremesa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtcodremesa_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtcantidad);
            this.panel1.Controls.Add(this.mtxtcodremesa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnretirarremesa);
            this.panel1.Controls.Add(this.mtxtdui);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(125, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 577);
            this.panel1.TabIndex = 23;
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
            this.label5.Size = new System.Drawing.Size(255, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Retiro de remesa";
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
            // mtxtdui
            // 
            this.mtxtdui.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtdui.Location = new System.Drawing.Point(139, 294);
            this.mtxtdui.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtdui.Mask = "000000000";
            this.mtxtdui.Name = "mtxtdui";
            this.mtxtdui.Size = new System.Drawing.Size(250, 38);
            this.mtxtdui.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label7.Location = new System.Drawing.Point(138, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cantidad a retirar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label8.Location = new System.Drawing.Point(138, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Numero de DUI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label9.Location = new System.Drawing.Point(134, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Codigo de la remesa";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Retiroremesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Retiroremesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retiroremesa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretirarremesa;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.MaskedTextBox mtxtcodremesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtdui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}