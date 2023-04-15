
namespace SchoolManagementProject
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxOgretmen = new System.Windows.Forms.PictureBox();
            this.picboxOgrenci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgretmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(516, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Çıkış";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SchoolManagementProject.Properties.Resources.turn_off;
            this.pictureBox1.Location = new System.Drawing.Point(477, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picBoxOgretmen
            // 
            this.picBoxOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxOgretmen.Image = global::SchoolManagementProject.Properties.Resources.teacher_;
            this.picBoxOgretmen.Location = new System.Drawing.Point(255, 38);
            this.picBoxOgretmen.Name = "picBoxOgretmen";
            this.picBoxOgretmen.Size = new System.Drawing.Size(128, 118);
            this.picBoxOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOgretmen.TabIndex = 1;
            this.picBoxOgretmen.TabStop = false;
            this.picBoxOgretmen.Click += new System.EventHandler(this.picBoxOgretmen_Click);
            // 
            // picboxOgrenci
            // 
            this.picboxOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxOgrenci.Image = global::SchoolManagementProject.Properties.Resources.graduated__1_;
            this.picboxOgrenci.Location = new System.Drawing.Point(33, 38);
            this.picboxOgrenci.Name = "picboxOgrenci";
            this.picboxOgrenci.Size = new System.Drawing.Size(128, 118);
            this.picboxOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxOgrenci.TabIndex = 0;
            this.picboxOgrenci.TabStop = false;
            this.picboxOgrenci.Click += new System.EventHandler(this.picboxOgrenci_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxOgretmen);
            this.Controls.Add(this.picboxOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisteme Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOgretmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxOgrenci;
        private System.Windows.Forms.PictureBox picBoxOgretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

