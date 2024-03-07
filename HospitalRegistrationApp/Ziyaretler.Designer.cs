namespace HospitalRegistrationApp
{
    partial class Ziyaretler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonelave = new System.Windows.Forms.Button();
            this.qeydler = new System.Windows.Forms.TextBox();
            this.diaqnoz = new System.Windows.Forms.TextBox();
            this.sebeb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rqeyd = new System.Windows.Forms.TextBox();
            this.rdiaqnoz = new System.Windows.Forms.TextBox();
            this.rsebeb = new System.Windows.Forms.TextBox();
            this.rres = new System.Windows.Forms.TextBox();
            this.rhekim = new System.Windows.Forms.TextBox();
            this.rtarix = new System.Windows.Forms.TextBox();
            this.rpasiyent = new System.Windows.Forms.TextBox();
            this.rzid = new System.Windows.Forms.TextBox();
            this.buttonredaktəet = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonelave);
            this.groupBox1.Controls.Add(this.qeydler);
            this.groupBox1.Controls.Add(this.diaqnoz);
            this.groupBox1.Controls.Add(this.sebeb);
            this.groupBox1.Location = new System.Drawing.Point(14, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 574);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ziyarət Əlavə Et";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Qeydlər";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diaqnoz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Səbəblər";
            // 
            // buttonelave
            // 
            this.buttonelave.Location = new System.Drawing.Point(141, 510);
            this.buttonelave.Name = "buttonelave";
            this.buttonelave.Size = new System.Drawing.Size(271, 37);
            this.buttonelave.TabIndex = 3;
            this.buttonelave.Text = "Əlavə Et";
            this.buttonelave.UseVisualStyleBackColor = true;
            this.buttonelave.Click += new System.EventHandler(this.buttonelave_Click);
            // 
            // qeydler
            // 
            this.qeydler.Location = new System.Drawing.Point(140, 339);
            this.qeydler.Multiline = true;
            this.qeydler.Name = "qeydler";
            this.qeydler.Size = new System.Drawing.Size(272, 140);
            this.qeydler.TabIndex = 2;
            // 
            // diaqnoz
            // 
            this.diaqnoz.Location = new System.Drawing.Point(140, 193);
            this.diaqnoz.Multiline = true;
            this.diaqnoz.Name = "diaqnoz";
            this.diaqnoz.Size = new System.Drawing.Size(272, 140);
            this.diaqnoz.TabIndex = 1;
            // 
            // sebeb
            // 
            this.sebeb.Location = new System.Drawing.Point(140, 47);
            this.sebeb.Multiline = true;
            this.sebeb.Name = "sebeb";
            this.sebeb.Size = new System.Drawing.Size(272, 140);
            this.sebeb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(480, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 574);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öncəki Ziyarətlər";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 500);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rqeyd);
            this.groupBox3.Controls.Add(this.rdiaqnoz);
            this.groupBox3.Controls.Add(this.rsebeb);
            this.groupBox3.Controls.Add(this.rres);
            this.groupBox3.Controls.Add(this.rhekim);
            this.groupBox3.Controls.Add(this.rtarix);
            this.groupBox3.Controls.Add(this.rpasiyent);
            this.groupBox3.Controls.Add(this.rzid);
            this.groupBox3.Controls.Add(this.buttonredaktəet);
            this.groupBox3.Location = new System.Drawing.Point(852, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 574);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ziyarət Detalları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Səbəblər";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Qeydlər";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tarix";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Diaqnoz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Həkim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Resepsiyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pasiyent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ziyarət İD";
            // 
            // rqeyd
            // 
            this.rqeyd.Location = new System.Drawing.Point(126, 428);
            this.rqeyd.Multiline = true;
            this.rqeyd.Name = "rqeyd";
            this.rqeyd.Size = new System.Drawing.Size(237, 76);
            this.rqeyd.TabIndex = 12;
            // 
            // rdiaqnoz
            // 
            this.rdiaqnoz.Location = new System.Drawing.Point(126, 339);
            this.rdiaqnoz.Multiline = true;
            this.rdiaqnoz.Name = "rdiaqnoz";
            this.rdiaqnoz.Size = new System.Drawing.Size(237, 76);
            this.rdiaqnoz.TabIndex = 11;
            // 
            // rsebeb
            // 
            this.rsebeb.Location = new System.Drawing.Point(126, 244);
            this.rsebeb.Multiline = true;
            this.rsebeb.Name = "rsebeb";
            this.rsebeb.Size = new System.Drawing.Size(237, 76);
            this.rsebeb.TabIndex = 10;
            // 
            // rres
            // 
            this.rres.Location = new System.Drawing.Point(126, 123);
            this.rres.Name = "rres";
            this.rres.ReadOnly = true;
            this.rres.Size = new System.Drawing.Size(237, 22);
            this.rres.TabIndex = 9;
            // 
            // rhekim
            // 
            this.rhekim.Location = new System.Drawing.Point(126, 165);
            this.rhekim.Name = "rhekim";
            this.rhekim.ReadOnly = true;
            this.rhekim.Size = new System.Drawing.Size(237, 22);
            this.rhekim.TabIndex = 8;
            // 
            // rtarix
            // 
            this.rtarix.Location = new System.Drawing.Point(126, 203);
            this.rtarix.Name = "rtarix";
            this.rtarix.ReadOnly = true;
            this.rtarix.Size = new System.Drawing.Size(237, 22);
            this.rtarix.TabIndex = 7;
            // 
            // rpasiyent
            // 
            this.rpasiyent.Location = new System.Drawing.Point(126, 85);
            this.rpasiyent.Name = "rpasiyent";
            this.rpasiyent.ReadOnly = true;
            this.rpasiyent.Size = new System.Drawing.Size(237, 22);
            this.rpasiyent.TabIndex = 6;
            // 
            // rzid
            // 
            this.rzid.Location = new System.Drawing.Point(126, 47);
            this.rzid.Name = "rzid";
            this.rzid.ReadOnly = true;
            this.rzid.Size = new System.Drawing.Size(237, 22);
            this.rzid.TabIndex = 5;
            // 
            // buttonredaktəet
            // 
            this.buttonredaktəet.Location = new System.Drawing.Point(126, 510);
            this.buttonredaktəet.Name = "buttonredaktəet";
            this.buttonredaktəet.Size = new System.Drawing.Size(237, 37);
            this.buttonredaktəet.TabIndex = 4;
            this.buttonredaktəet.Text = "Redaktə Et";
            this.buttonredaktəet.UseVisualStyleBackColor = true;
            this.buttonredaktəet.Click += new System.EventHandler(this.buttonredaktəet_Click);
            // 
            // Ziyaretler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 615);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ziyaretler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ziyarətlər";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox qeydler;
        private System.Windows.Forms.TextBox diaqnoz;
        private System.Windows.Forms.TextBox sebeb;
        private System.Windows.Forms.Button buttonelave;
        private System.Windows.Forms.Button buttonredaktəet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox rqeyd;
        private System.Windows.Forms.TextBox rdiaqnoz;
        private System.Windows.Forms.TextBox rsebeb;
        private System.Windows.Forms.TextBox rres;
        private System.Windows.Forms.TextBox rhekim;
        private System.Windows.Forms.TextBox rtarix;
        private System.Windows.Forms.TextBox rpasiyent;
        private System.Windows.Forms.TextBox rzid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}