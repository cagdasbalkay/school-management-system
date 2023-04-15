namespace SchoolManagementProject
{
    partial class FrmOgrenciGiris
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbOgrenciNumara = new System.Windows.Forms.TextBox();
            this.lblAnaMenuyeDon = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementProject.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(57, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ GİRİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(91, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 1);
            this.panel1.TabIndex = 3;
            // 
            // tbOgrenciNumara
            // 
            this.tbOgrenciNumara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOgrenciNumara.Location = new System.Drawing.Point(91, 196);
            this.tbOgrenciNumara.Multiline = true;
            this.tbOgrenciNumara.Name = "tbOgrenciNumara";
            this.tbOgrenciNumara.Size = new System.Drawing.Size(126, 20);
            this.tbOgrenciNumara.TabIndex = 4;
            // 
            // lblAnaMenuyeDon
            // 
            this.lblAnaMenuyeDon.AutoSize = true;
            this.lblAnaMenuyeDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAnaMenuyeDon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaMenuyeDon.ForeColor = System.Drawing.Color.Black;
            this.lblAnaMenuyeDon.Location = new System.Drawing.Point(34, 311);
            this.lblAnaMenuyeDon.Name = "lblAnaMenuyeDon";
            this.lblAnaMenuyeDon.Size = new System.Drawing.Size(162, 25);
            this.lblAnaMenuyeDon.TabIndex = 5;
            this.lblAnaMenuyeDon.Text = "Ana Menüye Dön";
            this.lblAnaMenuyeDon.Click += new System.EventHandler(this.lblAnaMenuyeDon_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.Black;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(17, 242);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(200, 41);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 362);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblAnaMenuyeDon);
            this.Controls.Add(this.tbOgrenciNumara);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmOgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenciGiris";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbOgrenciNumara;
        private System.Windows.Forms.Label lblAnaMenuyeDon;
        private System.Windows.Forms.Button btnGirisYap;
    }
}