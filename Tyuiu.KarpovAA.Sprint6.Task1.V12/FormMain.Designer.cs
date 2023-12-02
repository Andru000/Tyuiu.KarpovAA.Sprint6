
namespace Tyuiu.KarpovAA.Sprint6.Task1.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.ButtonResult_KAA = new System.Windows.Forms.Button();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_KAA = new System.Windows.Forms.TextBox();
            this.textBoxEndStep_KAA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_KAA = new System.Windows.Forms.TextBox();
            this.textBoxVarB_KAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            resources.ApplyResources(this.groupBoxTask_KAA, "groupBoxTask_KAA");
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.TabStop = false;
            // 
            // ButtonResult_KAA
            // 
            this.ButtonResult_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.ButtonResult_KAA, "ButtonResult_KAA");
            this.ButtonResult_KAA.Name = "ButtonResult_KAA";
            this.ButtonResult_KAA.UseVisualStyleBackColor = false;
            this.ButtonResult_KAA.Click += new System.EventHandler(this.ButtonResult_KAA_Click);
            // 
            // textBoxTask_KAA
            // 
            resources.ApplyResources(this.textBoxTask_KAA, "textBoxTask_KAA");
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.textBoxOutPut_KAA);
            resources.ApplyResources(this.groupBoxResult_KAA, "groupBoxResult_KAA");
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.TabStop = false;
            // 
            // textBoxOutPut_KAA
            // 
            resources.ApplyResources(this.textBoxOutPut_KAA, "textBoxOutPut_KAA");
            this.textBoxOutPut_KAA.Name = "textBoxOutPut_KAA";
            this.textBoxOutPut_KAA.ReadOnly = true;
            // 
            // textBoxResult_KAA
            // 
            resources.ApplyResources(this.textBoxResult_KAA, "textBoxResult_KAA");
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarB_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarA_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxEndStep_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxStartStep_KAA);
            resources.ApplyResources(this.groupBoxInPut_KAA, "groupBoxInPut_KAA");
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.TabStop = false;
            // 
            // textBoxStartStep_KAA
            // 
            resources.ApplyResources(this.textBoxStartStep_KAA, "textBoxStartStep_KAA");
            this.textBoxStartStep_KAA.Name = "textBoxStartStep_KAA";
            this.textBoxStartStep_KAA.ReadOnly = true;
            // 
            // textBoxEndStep_KAA
            // 
            resources.ApplyResources(this.textBoxEndStep_KAA, "textBoxEndStep_KAA");
            this.textBoxEndStep_KAA.Name = "textBoxEndStep_KAA";
            this.textBoxEndStep_KAA.ReadOnly = true;
            // 
            // textBoxVarA_KAA
            // 
            resources.ApplyResources(this.textBoxVarA_KAA, "textBoxVarA_KAA");
            this.textBoxVarA_KAA.Name = "textBoxVarA_KAA";
            // 
            // textBoxVarB_KAA
            // 
            resources.ApplyResources(this.textBoxVarB_KAA, "textBoxVarB_KAA");
            this.textBoxVarB_KAA.Name = "textBoxVarB_KAA";
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.buttonHelp_KAA, "buttonHelp_KAA");
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.groupBoxInPut_KAA);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.ButtonResult_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.PerformLayout();
            this.groupBoxInPut_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.Button ButtonResult_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.TextBox textBoxOutPut_KAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KAA;
        private System.Windows.Forms.TextBox textBoxVarB_KAA;
        private System.Windows.Forms.TextBox textBoxVarA_KAA;
        private System.Windows.Forms.TextBox textBoxEndStep_KAA;
        private System.Windows.Forms.TextBox textBoxStartStep_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
    }
}

