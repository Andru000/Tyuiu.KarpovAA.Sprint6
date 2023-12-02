
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
            this.groupBoxTask_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(417, 278);
            this.groupBoxTask_KAA.TabIndex = 0;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // ButtonResult_KAA
            // 
            this.ButtonResult_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonResult_KAA.Location = new System.Drawing.Point(340, 363);
            this.ButtonResult_KAA.Name = "ButtonResult_KAA";
            this.ButtonResult_KAA.Size = new System.Drawing.Size(89, 61);
            this.ButtonResult_KAA.TabIndex = 1;
            this.ButtonResult_KAA.Text = "Выполнить";
            this.ButtonResult_KAA.UseVisualStyleBackColor = false;
            this.ButtonResult_KAA.Click += new System.EventHandler(this.ButtonResult_KAA_Click);
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(405, 247);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = "Протабулировать функцию sin(X) на заданном диапазоне: Результат вывести в виде та" +
    "блицы.";
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.textBoxOutPut_KAA);
            this.groupBoxResult_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(435, 12);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(353, 426);
            this.groupBoxResult_KAA.TabIndex = 2;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод данных";
            // 
            // textBoxOutPut_KAA
            // 
            this.textBoxOutPut_KAA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutPut_KAA.Location = new System.Drawing.Point(6, 76);
            this.textBoxOutPut_KAA.Multiline = true;
            this.textBoxOutPut_KAA.Name = "textBoxOutPut_KAA";
            this.textBoxOutPut_KAA.ReadOnly = true;
            this.textBoxOutPut_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_KAA.Size = new System.Drawing.Size(341, 344);
            this.textBoxOutPut_KAA.TabIndex = 0;
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(6, 44);
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult_KAA.TabIndex = 1;
            this.textBoxResult_KAA.Text = "Результат:";
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarB_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarA_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxEndStep_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxStartStep_KAA);
            this.groupBoxInPut_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxInPut_KAA.Location = new System.Drawing.Point(18, 296);
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.Size = new System.Drawing.Size(251, 136);
            this.groupBoxInPut_KAA.TabIndex = 3;
            this.groupBoxInPut_KAA.TabStop = false;
            this.groupBoxInPut_KAA.Text = "Ввод данных";
            // 
            // textBoxStartStep_KAA
            // 
            this.textBoxStartStep_KAA.Location = new System.Drawing.Point(6, 56);
            this.textBoxStartStep_KAA.Name = "textBoxStartStep_KAA";
            this.textBoxStartStep_KAA.ReadOnly = true;
            this.textBoxStartStep_KAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartStep_KAA.TabIndex = 0;
            this.textBoxStartStep_KAA.Text = "Старт шага:";
            // 
            // textBoxEndStep_KAA
            // 
            this.textBoxEndStep_KAA.Location = new System.Drawing.Point(145, 56);
            this.textBoxEndStep_KAA.Name = "textBoxEndStep_KAA";
            this.textBoxEndStep_KAA.ReadOnly = true;
            this.textBoxEndStep_KAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxEndStep_KAA.TabIndex = 1;
            this.textBoxEndStep_KAA.Text = "Конец Шага:";
            // 
            // textBoxVarA_KAA
            // 
            this.textBoxVarA_KAA.Location = new System.Drawing.Point(6, 102);
            this.textBoxVarA_KAA.Name = "textBoxVarA_KAA";
            this.textBoxVarA_KAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarA_KAA.TabIndex = 2;
            // 
            // textBoxVarB_KAA
            // 
            this.textBoxVarB_KAA.Location = new System.Drawing.Point(145, 102);
            this.textBoxVarB_KAA.Name = "textBoxVarB_KAA";
            this.textBoxVarB_KAA.Size = new System.Drawing.Size(100, 26);
            this.textBoxVarB_KAA.TabIndex = 3;
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(275, 374);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(59, 50);
            this.buttonHelp_KAA.TabIndex = 4;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.groupBoxInPut_KAA);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.ButtonResult_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 12 | Карпов А. А";
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

