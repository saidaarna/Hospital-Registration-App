namespace HospitalRegistrationApp
{
    partial class RezBax
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
            this.label2 = new System.Windows.Forms.Label();
            this.Tarix = new System.Windows.Forms.Label();
            this.radioButtonadtelrez = new System.Windows.Forms.RadioButton();
            this.radioButtonherikisi = new System.Windows.Forms.RadioButton();
            this.radioButtontarix = new System.Windows.Forms.RadioButton();
            this.adtelrez = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnziyaretler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonred = new System.Windows.Forms.Button();
            this.pasiyent = new System.Windows.Forms.TextBox();
            this.resepsiyon = new System.Windows.Forms.TextBox();
            this.gs = new System.Windows.Forms.TextBox();
            this.trx = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.TextBox();
            this.rid = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tarix);
            this.groupBox1.Controls.Add(this.radioButtonadtelrez);
            this.groupBox1.Controls.Add(this.radioButtonherikisi);
            this.groupBox1.Controls.Add(this.radioButtontarix);
            this.groupBox1.Controls.Add(this.adtelrez);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervasiya Tap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad/Tel/Rez. ID";
            // 
            // Tarix
            // 
            this.Tarix.AutoSize = true;
            this.Tarix.Location = new System.Drawing.Point(100, 33);
            this.Tarix.Name = "Tarix";
            this.Tarix.Size = new System.Drawing.Size(42, 16);
            this.Tarix.TabIndex = 5;
            this.Tarix.Text = "Tarix";
            // 
            // radioButtonadtelrez
            // 
            this.radioButtonadtelrez.AutoSize = true;
            this.radioButtonadtelrez.Location = new System.Drawing.Point(54, 199);
            this.radioButtonadtelrez.Name = "radioButtonadtelrez";
            this.radioButtonadtelrez.Size = new System.Drawing.Size(197, 20);
            this.radioButtonadtelrez.TabIndex = 4;
            this.radioButtonadtelrez.TabStop = true;
            this.radioButtonadtelrez.Text = "Ad/Tel/Rez.ID ilə axtarış";
            this.radioButtonadtelrez.UseVisualStyleBackColor = true;
            this.radioButtonadtelrez.CheckedChanged += new System.EventHandler(this.radioButtonadtelrez_CheckedChanged);
            // 
            // radioButtonherikisi
            // 
            this.radioButtonherikisi.AutoSize = true;
            this.radioButtonherikisi.Location = new System.Drawing.Point(54, 235);
            this.radioButtonherikisi.Name = "radioButtonherikisi";
            this.radioButtonherikisi.Size = new System.Drawing.Size(156, 20);
            this.radioButtonherikisi.TabIndex = 3;
            this.radioButtonherikisi.TabStop = true;
            this.radioButtonherikisi.Text = "Hər ikisi ilə axtarış";
            this.radioButtonherikisi.UseVisualStyleBackColor = true;
            this.radioButtonherikisi.CheckedChanged += new System.EventHandler(this.radioButtonherikisi_CheckedChanged);
            // 
            // radioButtontarix
            // 
            this.radioButtontarix.AutoSize = true;
            this.radioButtontarix.Location = new System.Drawing.Point(54, 163);
            this.radioButtontarix.Name = "radioButtontarix";
            this.radioButtontarix.Size = new System.Drawing.Size(134, 20);
            this.radioButtontarix.TabIndex = 2;
            this.radioButtontarix.TabStop = true;
            this.radioButtontarix.Text = "Tarix ilə axtarış";
            this.radioButtontarix.UseVisualStyleBackColor = true;
            this.radioButtontarix.CheckedChanged += new System.EventHandler(this.radioButtontarix_CheckedChanged);
            // 
            // adtelrez
            // 
            this.adtelrez.Location = new System.Drawing.Point(232, 74);
            this.adtelrez.Name = "adtelrez";
            this.adtelrez.Size = new System.Drawing.Size(289, 22);
            this.adtelrez.TabIndex = 1;
            this.adtelrez.TextChanged += new System.EventHandler(this.adtelrez_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnziyaretler);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonred);
            this.groupBox2.Controls.Add(this.pasiyent);
            this.groupBox2.Controls.Add(this.resepsiyon);
            this.groupBox2.Controls.Add(this.gs);
            this.groupBox2.Controls.Add(this.trx);
            this.groupBox2.Controls.Add(this.gt);
            this.groupBox2.Controls.Add(this.rid);
            this.groupBox2.Location = new System.Drawing.Point(595, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezervasiya Detalları";
            // 
            // btnziyaretler
            // 
            this.btnziyaretler.Enabled = false;
            this.btnziyaretler.Location = new System.Drawing.Point(289, 225);
            this.btnziyaretler.Name = "btnziyaretler";
            this.btnziyaretler.Size = new System.Drawing.Size(115, 40);
            this.btnziyaretler.TabIndex = 14;
            this.btnziyaretler.Text = "Ziyarətlər";
            this.btnziyaretler.UseVisualStyleBackColor = true;
            this.btnziyaretler.Click += new System.EventHandler(this.btnziyaretler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Görüş Saatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tarix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Görüş Tarixi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resepsiyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pasiyent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // buttonred
            // 
            this.buttonred.Enabled = false;
            this.buttonred.Location = new System.Drawing.Point(115, 225);
            this.buttonred.Name = "buttonred";
            this.buttonred.Size = new System.Drawing.Size(115, 40);
            this.buttonred.TabIndex = 6;
            this.buttonred.Text = "Redaktə Et";
            this.buttonred.UseVisualStyleBackColor = true;
            this.buttonred.Click += new System.EventHandler(this.buttonred_Click);
            // 
            // pasiyent
            // 
            this.pasiyent.Location = new System.Drawing.Point(115, 63);
            this.pasiyent.Name = "pasiyent";
            this.pasiyent.ReadOnly = true;
            this.pasiyent.Size = new System.Drawing.Size(289, 22);
            this.pasiyent.TabIndex = 5;
            // 
            // resepsiyon
            // 
            this.resepsiyon.Location = new System.Drawing.Point(115, 91);
            this.resepsiyon.Name = "resepsiyon";
            this.resepsiyon.ReadOnly = true;
            this.resepsiyon.Size = new System.Drawing.Size(289, 22);
            this.resepsiyon.TabIndex = 4;
            // 
            // gs
            // 
            this.gs.Location = new System.Drawing.Point(115, 147);
            this.gs.Name = "gs";
            this.gs.ReadOnly = true;
            this.gs.Size = new System.Drawing.Size(289, 22);
            this.gs.TabIndex = 3;
            // 
            // trx
            // 
            this.trx.Location = new System.Drawing.Point(115, 175);
            this.trx.Name = "trx";
            this.trx.ReadOnly = true;
            this.trx.Size = new System.Drawing.Size(289, 22);
            this.trx.TabIndex = 2;
            // 
            // gt
            // 
            this.gt.Location = new System.Drawing.Point(115, 119);
            this.gt.Name = "gt";
            this.gt.ReadOnly = true;
            this.gt.Size = new System.Drawing.Size(289, 22);
            this.gt.TabIndex = 1;
            // 
            // rid
            // 
            this.rid.Location = new System.Drawing.Point(115, 35);
            this.rid.Name = "rid";
            this.rid.ReadOnly = true;
            this.rid.Size = new System.Drawing.Size(289, 22);
            this.rid.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 297);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1015, 276);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RezBax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1059, 594);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RezBax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasiyalara Bax";
            this.Load += new System.EventHandler(this.RezBax_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonred;
        private System.Windows.Forms.TextBox pasiyent;
        private System.Windows.Forms.TextBox resepsiyon;
        private System.Windows.Forms.TextBox gs;
        private System.Windows.Forms.TextBox trx;
        private System.Windows.Forms.TextBox gt;
        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.RadioButton radioButtonadtelrez;
        private System.Windows.Forms.RadioButton radioButtonherikisi;
        private System.Windows.Forms.RadioButton radioButtontarix;
        private System.Windows.Forms.TextBox adtelrez;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tarix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnziyaretler;
    }
}