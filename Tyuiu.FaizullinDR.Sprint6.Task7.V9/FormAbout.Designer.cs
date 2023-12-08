
namespace Tyuiu.FaizullinDR.Sprint6.Task7.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_FDR = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxMyPhoto_FDR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPhoto_FDR)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_FDR
            // 
            this.labelInfo_FDR.AutoSize = true;
            this.labelInfo_FDR.Location = new System.Drawing.Point(138, 12);
            this.labelInfo_FDR.Name = "labelInfo_FDR";
            this.labelInfo_FDR.Size = new System.Drawing.Size(363, 153);
            this.labelInfo_FDR.TabIndex = 6;
            this.labelInfo_FDR.Text = resources.GetString("labelInfo_FDR.Text");
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(403, 167);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 30);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxMyPhoto_FDR
            // 
            this.pictureBoxMyPhoto_FDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyPhoto_FDR.Image")));
            this.pictureBoxMyPhoto_FDR.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMyPhoto_FDR.Name = "pictureBoxMyPhoto_FDR";
            this.pictureBoxMyPhoto_FDR.Size = new System.Drawing.Size(120, 185);
            this.pictureBoxMyPhoto_FDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyPhoto_FDR.TabIndex = 4;
            this.pictureBoxMyPhoto_FDR.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 205);
            this.Controls.Add(this.labelInfo_FDR);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxMyPhoto_FDR);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPhoto_FDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_FDR;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxMyPhoto_FDR;
    }
}