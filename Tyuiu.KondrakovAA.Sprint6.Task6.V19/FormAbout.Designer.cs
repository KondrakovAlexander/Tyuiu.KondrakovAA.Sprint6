
namespace Tyuiu.KondrakovAA.Sprint6.Task6.V19
{
    partial class FormAbout_KAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KAA));
            this.pictureBoxVITEK_KAA = new System.Windows.Forms.PictureBox();
            this.labelAbout_KAA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVITEK_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVITEK_KAA
            // 
            this.pictureBoxVITEK_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVITEK_KAA.Image")));
            this.pictureBoxVITEK_KAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVITEK_KAA.Name = "pictureBoxVITEK_KAA";
            this.pictureBoxVITEK_KAA.Size = new System.Drawing.Size(355, 197);
            this.pictureBoxVITEK_KAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVITEK_KAA.TabIndex = 0;
            this.pictureBoxVITEK_KAA.TabStop = false;
            // 
            // labelAbout_KAA
            // 
            this.labelAbout_KAA.AutoSize = true;
            this.labelAbout_KAA.Location = new System.Drawing.Point(373, 50);
            this.labelAbout_KAA.Name = "labelAbout_KAA";
            this.labelAbout_KAA.Size = new System.Drawing.Size(284, 117);
            this.labelAbout_KAA.TabIndex = 1;
            this.labelAbout_KAA.Text = resources.GetString("labelAbout_KAA.Text");
            // 
            // FormAbout_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 220);
            this.Controls.Add(this.labelAbout_KAA);
            this.Controls.Add(this.pictureBoxVITEK_KAA);
            this.Name = "FormAbout_KAA";
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVITEK_KAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVITEK_KAA;
        private System.Windows.Forms.Label labelAbout_KAA;
    }
}