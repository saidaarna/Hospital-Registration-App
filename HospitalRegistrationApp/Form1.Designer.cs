namespace HospitalRegistrationApp
{
    partial class Form1
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
            this.İstifadəçiAdı = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // İstifadəçiAdı
            // 
            this.İstifadəçiAdı.AutoSize = true;
            this.İstifadəçiAdı.Location = new System.Drawing.Point(49, 83);
            this.İstifadəçiAdı.Name = "İstifadəçiAdı";
            this.İstifadəçiAdı.Size = new System.Drawing.Size(97, 16);
            this.İstifadəçiAdı.TabIndex = 0;
            this.İstifadəçiAdı.Text = "İstifadəçi Adı";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(157, 77);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(262, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(157, 119);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.PasswordChar = '*';
            this.textBoxPasword.Size = new System.Drawing.Size(262, 22);
            this.textBoxPasword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrə";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(264, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Daxil Ol";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxPasword);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.İstifadəçiAdı);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 278);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 274);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::HospitalRegistrationApp.Properties.Resources.analysis_hospital_doctor_medical;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daxil Ol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label İstifadəçiAdı;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

