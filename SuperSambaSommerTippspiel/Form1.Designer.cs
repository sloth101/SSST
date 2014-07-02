namespace SuperSambaSommerTippspiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(409, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(399, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Location = new System.Drawing.Point(354, 119);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(164, 28);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_Pw
            // 
            this.tb_Pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Pw.Location = new System.Drawing.Point(354, 183);
            this.tb_Pw.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(164, 28);
            this.tb_Pw.TabIndex = 3;
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Anmelden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Anmelden.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Anmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anmelden.Location = new System.Drawing.Point(354, 221);
            this.btn_Anmelden.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(164, 35);
            this.btn_Anmelden.TabIndex = 4;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = false;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg.Location = new System.Drawing.Point(354, 266);
            this.btn_Reg.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(164, 35);
            this.btn_Reg.TabIndex = 5;
            this.btn_Reg.Text = "Registrieren";
            this.btn_Reg.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.tb_Pw);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Pw;
        private System.Windows.Forms.Button btn_Anmelden;
        private System.Windows.Forms.Button btn_Reg;
    }
}

