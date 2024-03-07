namespace HospitalRegistrationApp
{
    partial class AdminForm
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
            this.groupBoxyhyarat = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.yeniqeyd = new System.Windows.Forms.TextBox();
            this.yisifre = new System.Windows.Forms.TextBox();
            this.yeniad = new System.Windows.Forms.TextBox();
            this.yeniistAD = new System.Windows.Forms.TextBox();
            this.groupBoxhtap = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBoxhbax = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxistad = new System.Windows.Forms.TextBox();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxdt = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.textBoxyt = new System.Windows.Forms.TextBox();
            this.textBoxtip = new System.Windows.Forms.TextBox();
            this.textBoxqeyd = new System.Windows.Forms.TextBox();
            this.groupBoxyhyarat.SuspendLayout();
            this.groupBoxhtap.SuspendLayout();
            this.groupBoxhbax.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxyhyarat
            // 
            this.groupBoxyhyarat.Controls.Add(this.label8);
            this.groupBoxyhyarat.Controls.Add(this.comboBox1);
            this.groupBoxyhyarat.Controls.Add(this.label4);
            this.groupBoxyhyarat.Controls.Add(this.label3);
            this.groupBoxyhyarat.Controls.Add(this.label2);
            this.groupBoxyhyarat.Controls.Add(this.label1);
            this.groupBoxyhyarat.Controls.Add(this.buttonCreate);
            this.groupBoxyhyarat.Controls.Add(this.yeniqeyd);
            this.groupBoxyhyarat.Controls.Add(this.yisifre);
            this.groupBoxyhyarat.Controls.Add(this.yeniad);
            this.groupBoxyhyarat.Controls.Add(this.yeniistAD);
            this.groupBoxyhyarat.Location = new System.Drawing.Point(14, 12);
            this.groupBoxyhyarat.Name = "groupBoxyhyarat";
            this.groupBoxyhyarat.Size = new System.Drawing.Size(342, 570);
            this.groupBoxyhyarat.TabIndex = 0;
            this.groupBoxyhyarat.TabStop = false;
            this.groupBoxyhyarat.Text = "Yeni Hesab Yarat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tip";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Resepsiyon",
            "Həkim"});
            this.comboBox1.Location = new System.Drawing.Point(101, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qeydlər";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifrə";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "İstifadəçi Adı";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(101, 517);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(199, 31);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Saxla";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // yeniqeyd
            // 
            this.yeniqeyd.Location = new System.Drawing.Point(101, 248);
            this.yeniqeyd.Multiline = true;
            this.yeniqeyd.Name = "yeniqeyd";
            this.yeniqeyd.Size = new System.Drawing.Size(200, 218);
            this.yeniqeyd.TabIndex = 3;
            // 
            // yisifre
            // 
            this.yisifre.Location = new System.Drawing.Point(101, 91);
            this.yisifre.Name = "yisifre";
            this.yisifre.Size = new System.Drawing.Size(200, 22);
            this.yisifre.TabIndex = 2;
            // 
            // yeniad
            // 
            this.yeniad.Location = new System.Drawing.Point(101, 146);
            this.yeniad.Name = "yeniad";
            this.yeniad.Size = new System.Drawing.Size(200, 22);
            this.yeniad.TabIndex = 1;
            // 
            // yeniistAD
            // 
            this.yeniistAD.Location = new System.Drawing.Point(101, 43);
            this.yeniistAD.Name = "yeniistAD";
            this.yeniistAD.Size = new System.Drawing.Size(200, 22);
            this.yeniistAD.TabIndex = 0;
            // 
            // groupBoxhtap
            // 
            this.groupBoxhtap.Controls.Add(this.label5);
            this.groupBoxhtap.Controls.Add(this.listBox1);
            this.groupBoxhtap.Controls.Add(this.textBox4);
            this.groupBoxhtap.Location = new System.Drawing.Point(387, 13);
            this.groupBoxhtap.Name = "groupBoxhtap";
            this.groupBoxhtap.Size = new System.Drawing.Size(375, 569);
            this.groupBoxhtap.TabIndex = 1;
            this.groupBoxhtap.TabStop = false;
            this.groupBoxhtap.Text = "Hesabı Tap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ad/Tel.";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(36, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 452);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(115, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBoxhbax
            // 
            this.groupBoxhbax.Controls.Add(this.label14);
            this.groupBoxhbax.Controls.Add(this.label13);
            this.groupBoxhbax.Controls.Add(this.label12);
            this.groupBoxhbax.Controls.Add(this.label11);
            this.groupBoxhbax.Controls.Add(this.label10);
            this.groupBoxhbax.Controls.Add(this.label9);
            this.groupBoxhbax.Controls.Add(this.label7);
            this.groupBoxhbax.Controls.Add(this.label6);
            this.groupBoxhbax.Controls.Add(this.button2);
            this.groupBoxhbax.Controls.Add(this.textBoxId);
            this.groupBoxhbax.Controls.Add(this.textBoxistad);
            this.groupBoxhbax.Controls.Add(this.textBoxad);
            this.groupBoxhbax.Controls.Add(this.textBoxdt);
            this.groupBoxhbax.Controls.Add(this.textBoxtel);
            this.groupBoxhbax.Controls.Add(this.textBoxyt);
            this.groupBoxhbax.Controls.Add(this.textBoxtip);
            this.groupBoxhbax.Controls.Add(this.textBoxqeyd);
            this.groupBoxhbax.Location = new System.Drawing.Point(807, 14);
            this.groupBoxhbax.Name = "groupBoxhbax";
            this.groupBoxhbax.Size = new System.Drawing.Size(387, 568);
            this.groupBoxhbax.TabIndex = 2;
            this.groupBoxhbax.TabStop = false;
            this.groupBoxhbax.Text = "Hesaba Bax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Qeydlər";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tip";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "İstifadəçi Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Yaradıldığı Tarix";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tel.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Doğum Tarixi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hesab ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxId.Location = new System.Drawing.Point(150, 41);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(200, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // textBoxistad
            // 
            this.textBoxistad.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxistad.Location = new System.Drawing.Point(150, 89);
            this.textBoxistad.Name = "textBoxistad";
            this.textBoxistad.ReadOnly = true;
            this.textBoxistad.Size = new System.Drawing.Size(200, 22);
            this.textBoxistad.TabIndex = 7;
            // 
            // textBoxad
            // 
            this.textBoxad.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxad.Location = new System.Drawing.Point(150, 144);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.ReadOnly = true;
            this.textBoxad.Size = new System.Drawing.Size(200, 22);
            this.textBoxad.TabIndex = 6;
            // 
            // textBoxdt
            // 
            this.textBoxdt.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxdt.Location = new System.Drawing.Point(150, 196);
            this.textBoxdt.Name = "textBoxdt";
            this.textBoxdt.ReadOnly = true;
            this.textBoxdt.Size = new System.Drawing.Size(200, 22);
            this.textBoxdt.TabIndex = 5;
            // 
            // textBoxtel
            // 
            this.textBoxtel.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxtel.Location = new System.Drawing.Point(150, 245);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.ReadOnly = true;
            this.textBoxtel.Size = new System.Drawing.Size(200, 22);
            this.textBoxtel.TabIndex = 4;
            // 
            // textBoxyt
            // 
            this.textBoxyt.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxyt.Location = new System.Drawing.Point(150, 479);
            this.textBoxyt.Name = "textBoxyt";
            this.textBoxyt.ReadOnly = true;
            this.textBoxyt.Size = new System.Drawing.Size(200, 22);
            this.textBoxyt.TabIndex = 3;
            // 
            // textBoxtip
            // 
            this.textBoxtip.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxtip.Location = new System.Drawing.Point(150, 292);
            this.textBoxtip.Name = "textBoxtip";
            this.textBoxtip.ReadOnly = true;
            this.textBoxtip.Size = new System.Drawing.Size(200, 22);
            this.textBoxtip.TabIndex = 2;
            // 
            // textBoxqeyd
            // 
            this.textBoxqeyd.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxqeyd.Location = new System.Drawing.Point(150, 324);
            this.textBoxqeyd.Multiline = true;
            this.textBoxqeyd.Name = "textBoxqeyd";
            this.textBoxqeyd.Size = new System.Drawing.Size(200, 140);
            this.textBoxqeyd.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1207, 594);
            this.Controls.Add(this.groupBoxhbax);
            this.Controls.Add(this.groupBoxhtap);
            this.Controls.Add(this.groupBoxyhyarat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBoxyhyarat.ResumeLayout(false);
            this.groupBoxyhyarat.PerformLayout();
            this.groupBoxhtap.ResumeLayout(false);
            this.groupBoxhtap.PerformLayout();
            this.groupBoxhbax.ResumeLayout(false);
            this.groupBoxhbax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxyhyarat;
        private System.Windows.Forms.GroupBox groupBoxhtap;
        private System.Windows.Forms.GroupBox groupBoxhbax;
        private System.Windows.Forms.TextBox yeniistAD;
        private System.Windows.Forms.TextBox yisifre;
        private System.Windows.Forms.TextBox yeniad;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox yeniqeyd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxistad;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxdt;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.TextBox textBoxyt;
        private System.Windows.Forms.TextBox textBoxtip;
        private System.Windows.Forms.TextBox textBoxqeyd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}