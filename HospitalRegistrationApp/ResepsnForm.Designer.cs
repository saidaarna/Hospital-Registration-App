namespace HospitalRegistrationApp
{
    partial class ResepsnForm
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
            this.buttonredakte = new System.Windows.Forms.Button();
            this.pasprof = new System.Windows.Forms.Button();
            this.buttonrezet = new System.Windows.Forms.Button();
            this.rezbax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonredakte
            // 
            this.buttonredakte.Location = new System.Drawing.Point(47, 53);
            this.buttonredakte.Name = "buttonredakte";
            this.buttonredakte.Size = new System.Drawing.Size(170, 54);
            this.buttonredakte.TabIndex = 0;
            this.buttonredakte.Text = "Hesabı Redaktə Et";
            this.buttonredakte.UseVisualStyleBackColor = true;
            this.buttonredakte.Click += new System.EventHandler(this.buttonredakte_Click);
            // 
            // pasprof
            // 
            this.pasprof.Location = new System.Drawing.Point(47, 137);
            this.pasprof.Name = "pasprof";
            this.pasprof.Size = new System.Drawing.Size(170, 54);
            this.pasprof.TabIndex = 1;
            this.pasprof.Text = "Pasiyent Profilləri";
            this.pasprof.UseVisualStyleBackColor = true;
            this.pasprof.Click += new System.EventHandler(this.pasprof_Click);
            // 
            // buttonrezet
            // 
            this.buttonrezet.Location = new System.Drawing.Point(47, 227);
            this.buttonrezet.Name = "buttonrezet";
            this.buttonrezet.Size = new System.Drawing.Size(170, 54);
            this.buttonrezet.TabIndex = 2;
            this.buttonrezet.Text = "Rezervasiya Et";
            this.buttonrezet.UseVisualStyleBackColor = true;
            this.buttonrezet.Click += new System.EventHandler(this.buttonrezet_Click);
            // 
            // rezbax
            // 
            this.rezbax.Location = new System.Drawing.Point(47, 322);
            this.rezbax.Name = "rezbax";
            this.rezbax.Size = new System.Drawing.Size(170, 54);
            this.rezbax.TabIndex = 3;
            this.rezbax.Text = "Rezervasiyalara Bax";
            this.rezbax.UseVisualStyleBackColor = true;
            this.rezbax.Click += new System.EventHandler(this.rezbax_Click);
            // 
            // ResepsnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(280, 470);
            this.Controls.Add(this.rezbax);
            this.Controls.Add(this.buttonrezet);
            this.Controls.Add(this.pasprof);
            this.Controls.Add(this.buttonredakte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ResepsnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resepsiyon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonredakte;
        private System.Windows.Forms.Button pasprof;
        private System.Windows.Forms.Button buttonrezet;
        private System.Windows.Forms.Button rezbax;
    }
}