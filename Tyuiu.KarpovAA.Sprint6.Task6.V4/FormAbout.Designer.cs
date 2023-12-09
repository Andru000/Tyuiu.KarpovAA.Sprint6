
namespace Tyuiu.KarpovAA.Sprint6.Task6.V4
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
            this.pictureBoxAvatar_KAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_KAA = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_KAA
            // 
            this.pictureBoxAvatar_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task6.V4.Properties.Resources.XtYr_gPDUKI;
            this.pictureBoxAvatar_KAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_KAA.Name = "pictureBoxAvatar_KAA";
            this.pictureBoxAvatar_KAA.Size = new System.Drawing.Size(210, 194);
            this.pictureBoxAvatar_KAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_KAA.TabIndex = 0;
            this.pictureBoxAvatar_KAA.TabStop = false;
            // 
            // labelInfo_KAA
            // 
            this.labelInfo_KAA.AutoSize = true;
            this.labelInfo_KAA.Location = new System.Drawing.Point(228, 12);
            this.labelInfo_KAA.Name = "labelInfo_KAA";
            this.labelInfo_KAA.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KAA.TabIndex = 1;
            this.labelInfo_KAA.Text = resources.GetString("labelInfo_KAA.Text");
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(437, 183);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 216);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelInfo_KAA);
            this.Controls.Add(this.pictureBoxAvatar_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAA;
        public System.Windows.Forms.Label labelInfo_KAA;
        private System.Windows.Forms.Button buttonOk;
    }
}