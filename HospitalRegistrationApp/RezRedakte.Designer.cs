namespace HospitalRegistrationApp
{
    partial class RezRedakte
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
            this.buttonred = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.resepsiyon = new System.Windows.Forms.TextBox();
            this.pasiyent = new System.Windows.Forms.TextBox();
            this.tarix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonred
            // 
            this.buttonred.Location = new System.Drawing.Point(168, 306);
            this.buttonred.Name = "buttonred";
            this.buttonred.Size = new System.Drawing.Size(147, 77);
            this.buttonred.TabIndex = 0;
            this.buttonred.Text = "Redaktə Et";
            this.buttonred.UseVisualStyleBackColor = true;
            this.buttonred.Click += new System.EventHandler(this.buttonred_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(322, 306);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(156, 77);
            this.buttonsil.TabIndex = 1;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(168, 50);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(310, 22);
            this.id.TabIndex = 2;
            // 
            // resepsiyon
            // 
            this.resepsiyon.Location = new System.Drawing.Point(168, 134);
            this.resepsiyon.Name = "resepsiyon";
            this.resepsiyon.ReadOnly = true;
            this.resepsiyon.Size = new System.Drawing.Size(310, 22);
            this.resepsiyon.TabIndex = 3;
            // 
            // pasiyent
            // 
            this.pasiyent.Location = new System.Drawing.Point(168, 89);
            this.pasiyent.Name = "pasiyent";
            this.pasiyent.ReadOnly = true;
            this.pasiyent.Size = new System.Drawing.Size(310, 22);
            this.pasiyent.TabIndex = 4;
            // 
            // tarix
            // 
            this.tarix.Location = new System.Drawing.Point(171, 270);
            this.tarix.Name = "tarix";
            this.tarix.ReadOnly = true;
            this.tarix.Size = new System.Drawing.Size(310, 22);
            this.tarix.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "İD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pasiyent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resepsiyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ziyarət Tarixi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarix";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // RezRedakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(566, 404);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarix);
            this.Controls.Add(this.pasiyent);
            this.Controls.Add(this.resepsiyon);
            this.Controls.Add(this.id);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonred);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RezRedakte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasiyanı Redaktə Et";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonred;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox resepsiyon;
        private System.Windows.Forms.TextBox pasiyent;
        private System.Windows.Forms.TextBox tarix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}