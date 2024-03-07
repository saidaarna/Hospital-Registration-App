namespace HospitalRegistrationApp
{
    partial class HekimForm
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
            this.btnHesabiRedakte = new System.Windows.Forms.Button();
            this.btnRezBax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHesabiRedakte
            // 
            this.btnHesabiRedakte.Location = new System.Drawing.Point(24, 33);
            this.btnHesabiRedakte.Name = "btnHesabiRedakte";
            this.btnHesabiRedakte.Size = new System.Drawing.Size(284, 46);
            this.btnHesabiRedakte.TabIndex = 0;
            this.btnHesabiRedakte.Text = "Hesabı Redaktə Et";
            this.btnHesabiRedakte.UseVisualStyleBackColor = true;
            this.btnHesabiRedakte.Click += new System.EventHandler(this.btnHesabiRedakte_Click);
            // 
            // btnRezBax
            // 
            this.btnRezBax.Location = new System.Drawing.Point(24, 110);
            this.btnRezBax.Name = "btnRezBax";
            this.btnRezBax.Size = new System.Drawing.Size(284, 46);
            this.btnRezBax.TabIndex = 1;
            this.btnRezBax.Text = "Rezervasiyalara Bax";
            this.btnRezBax.UseVisualStyleBackColor = true;
            this.btnRezBax.Click += new System.EventHandler(this.btnRezBax_Click);
            // 
            // HekimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(331, 183);
            this.Controls.Add(this.btnRezBax);
            this.Controls.Add(this.btnHesabiRedakte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HekimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Həkim Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesabiRedakte;
        private System.Windows.Forms.Button btnRezBax;
    }
}