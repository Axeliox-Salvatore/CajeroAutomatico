namespace sistema_cajero
{
    partial class MenuTransferencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransExterna = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTransInterna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnTransExterna);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnTransInterna);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(130, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 577);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label5.Location = new System.Drawing.Point(172, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Transferencia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransExterna
            // 
            this.btnTransExterna.BackColor = System.Drawing.Color.DarkRed;
            this.btnTransExterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransExterna.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransExterna.ForeColor = System.Drawing.Color.White;
            this.btnTransExterna.Location = new System.Drawing.Point(178, 423);
            this.btnTransExterna.Name = "btnTransExterna";
            this.btnTransExterna.Size = new System.Drawing.Size(200, 51);
            this.btnTransExterna.TabIndex = 5;
            this.btnTransExterna.Text = "Aceptar";
            this.btnTransExterna.UseVisualStyleBackColor = false;
            this.btnTransExterna.Click += new System.EventHandler(this.btnTransExterna_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(158, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transferencia Entre Bancos";
            // 
            // btnTransInterna
            // 
            this.btnTransInterna.BackColor = System.Drawing.Color.DarkRed;
            this.btnTransInterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransInterna.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransInterna.ForeColor = System.Drawing.Color.White;
            this.btnTransInterna.Location = new System.Drawing.Point(178, 259);
            this.btnTransInterna.Name = "btnTransInterna";
            this.btnTransInterna.Size = new System.Drawing.Size(200, 51);
            this.btnTransInterna.TabIndex = 4;
            this.btnTransInterna.Text = "Aceptar";
            this.btnTransInterna.UseVisualStyleBackColor = false;
            this.btnTransInterna.Click += new System.EventHandler(this.btnTransInterna_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(157, 123);
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
            this.label3.Size = new System.Drawing.Size(213, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transferencia Interna";
            // 
            // MenuTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.panel1);
            this.Name = "MenuTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuTransferencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransExterna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransInterna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}