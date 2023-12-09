
namespace Tyuiu.KarpovAA.Sprint6.Task7.V2
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
            this.label_KAA = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_KAA = new System.Windows.Forms.PictureBox();
            this.buttonOK_KAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // label_KAA
            // 
            this.label_KAA.AutoSize = true;
            this.label_KAA.Location = new System.Drawing.Point(206, 34);
            this.label_KAA.Name = "label_KAA";
            this.label_KAA.Size = new System.Drawing.Size(284, 117);
            this.label_KAA.TabIndex = 0;
            this.label_KAA.Text = resources.GetString("label_KAA.Text");
            // 
            // pictureBoxAvatar_KAA
            // 
            this.pictureBoxAvatar_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.XtYr_gPDUKI;
            this.pictureBoxAvatar_KAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_KAA.Name = "pictureBoxAvatar_KAA";
            this.pictureBoxAvatar_KAA.Size = new System.Drawing.Size(188, 179);
            this.pictureBoxAvatar_KAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_KAA.TabIndex = 1;
            this.pictureBoxAvatar_KAA.TabStop = false;
            // 
            // buttonOK_KAA
            // 
            this.buttonOK_KAA.Location = new System.Drawing.Point(397, 168);
            this.buttonOK_KAA.Name = "buttonOK_KAA";
            this.buttonOK_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KAA.TabIndex = 2;
            this.buttonOK_KAA.Text = "OK";
            this.buttonOK_KAA.UseVisualStyleBackColor = true;
            this.buttonOK_KAA.Click += new System.EventHandler(this.buttonOK_KAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 203);
            this.Controls.Add(this.buttonOK_KAA);
            this.Controls.Add(this.pictureBoxAvatar_KAA);
            this.Controls.Add(this.label_KAA);
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

        private System.Windows.Forms.Label label_KAA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAA;
        private System.Windows.Forms.Button buttonOK_KAA;
    }
}