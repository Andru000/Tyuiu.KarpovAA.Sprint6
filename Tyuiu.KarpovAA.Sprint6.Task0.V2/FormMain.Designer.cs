
namespace Tyuiu.KarpovAA.Sprint6.Task0.V2
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
            this.groupBoxHeading_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KAA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_KAA = new System.Windows.Forms.PictureBox();
            this.buttonResult_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.groupBoxInput_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxVariable_KAA = new System.Windows.Forms.TextBox();
            this.textBoxInput_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTextResult_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxHeading_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAA)).BeginInit();
            this.groupBoxInput_KAA.SuspendLayout();
            this.groupBoxOutput_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHeading_KAA
            // 
            this.groupBoxHeading_KAA.Controls.Add(this.textBoxCondition_KAA);
            this.groupBoxHeading_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.groupBoxHeading_KAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHeading_KAA.Name = "groupBoxHeading_KAA";
            this.groupBoxHeading_KAA.Size = new System.Drawing.Size(528, 216);
            this.groupBoxHeading_KAA.TabIndex = 0;
            this.groupBoxHeading_KAA.TabStop = false;
            this.groupBoxHeading_KAA.Text = "Условие";
            // 
            // textBoxCondition_KAA
            // 
            this.textBoxCondition_KAA.Location = new System.Drawing.Point(6, 48);
            this.textBoxCondition_KAA.Multiline = true;
            this.textBoxCondition_KAA.Name = "textBoxCondition_KAA";
            this.textBoxCondition_KAA.ReadOnly = true;
            this.textBoxCondition_KAA.Size = new System.Drawing.Size(516, 150);
            this.textBoxCondition_KAA.TabIndex = 0;
            this.textBoxCondition_KAA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой.";
            // 
            // pictureBoxFormula_KAA
            // 
            this.pictureBoxFormula_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task0.V2.Properties.Resources.Task0;
            this.pictureBoxFormula_KAA.Location = new System.Drawing.Point(577, 49);
            this.pictureBoxFormula_KAA.Name = "pictureBoxFormula_KAA";
            this.pictureBoxFormula_KAA.Size = new System.Drawing.Size(169, 112);
            this.pictureBoxFormula_KAA.TabIndex = 1;
            this.pictureBoxFormula_KAA.TabStop = false;
            // 
            // buttonResult_KAA
            // 
            this.buttonResult_KAA.Location = new System.Drawing.Point(671, 368);
            this.buttonResult_KAA.Name = "buttonResult_KAA";
            this.buttonResult_KAA.Size = new System.Drawing.Size(117, 70);
            this.buttonResult_KAA.TabIndex = 4;
            this.buttonResult_KAA.Text = "Выполнить";
            this.buttonResult_KAA.UseVisualStyleBackColor = true;
            this.buttonResult_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(604, 383);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(61, 44);
            this.buttonHelp_KAA.TabIndex = 5;
            this.buttonHelp_KAA.Text = "?";
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // groupBoxInput_KAA
            // 
            this.groupBoxInput_KAA.Controls.Add(this.textBoxVariable_KAA);
            this.groupBoxInput_KAA.Controls.Add(this.textBoxInput_KAA);
            this.groupBoxInput_KAA.Location = new System.Drawing.Point(18, 251);
            this.groupBoxInput_KAA.Name = "groupBoxInput_KAA";
            this.groupBoxInput_KAA.Size = new System.Drawing.Size(277, 160);
            this.groupBoxInput_KAA.TabIndex = 6;
            this.groupBoxInput_KAA.TabStop = false;
            this.groupBoxInput_KAA.Text = "Ввод даннах";
            // 
            // textBoxVariable_KAA
            // 
            this.textBoxVariable_KAA.Location = new System.Drawing.Point(33, 32);
            this.textBoxVariable_KAA.Multiline = true;
            this.textBoxVariable_KAA.Name = "textBoxVariable_KAA";
            this.textBoxVariable_KAA.ReadOnly = true;
            this.textBoxVariable_KAA.Size = new System.Drawing.Size(180, 44);
            this.textBoxVariable_KAA.TabIndex = 1;
            this.textBoxVariable_KAA.Text = "Переменная X:";
            // 
            // textBoxInput_KAA
            // 
            this.textBoxInput_KAA.Location = new System.Drawing.Point(33, 96);
            this.textBoxInput_KAA.Multiline = true;
            this.textBoxInput_KAA.Name = "textBoxInput_KAA";
            this.textBoxInput_KAA.Size = new System.Drawing.Size(204, 58);
            this.textBoxInput_KAA.TabIndex = 0;
            this.textBoxInput_KAA.WordWrap = false;
            this.textBoxInput_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KAA_KeyPress);
            // 
            // groupBoxOutput_KAA
            // 
            this.groupBoxOutput_KAA.Controls.Add(this.textBoxTextResult_KAA);
            this.groupBoxOutput_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxOutput_KAA.Location = new System.Drawing.Point(328, 251);
            this.groupBoxOutput_KAA.Name = "groupBoxOutput_KAA";
            this.groupBoxOutput_KAA.Size = new System.Drawing.Size(270, 166);
            this.groupBoxOutput_KAA.TabIndex = 0;
            this.groupBoxOutput_KAA.TabStop = false;
            this.groupBoxOutput_KAA.Text = "Вывод данных";
            // 
            // textBoxTextResult_KAA
            // 
            this.textBoxTextResult_KAA.Location = new System.Drawing.Point(20, 32);
            this.textBoxTextResult_KAA.Multiline = true;
            this.textBoxTextResult_KAA.Name = "textBoxTextResult_KAA";
            this.textBoxTextResult_KAA.ReadOnly = true;
            this.textBoxTextResult_KAA.Size = new System.Drawing.Size(203, 44);
            this.textBoxTextResult_KAA.TabIndex = 2;
            this.textBoxTextResult_KAA.Text = "Результат";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(20, 96);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(226, 64);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_KAA);
            this.Controls.Add(this.groupBoxInput_KAA);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.buttonResult_KAA);
            this.Controls.Add(this.pictureBoxFormula_KAA);
            this.Controls.Add(this.groupBoxHeading_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 2 | Карпов А. А";
            this.groupBoxHeading_KAA.ResumeLayout(false);
            this.groupBoxHeading_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAA)).EndInit();
            this.groupBoxInput_KAA.ResumeLayout(false);
            this.groupBoxInput_KAA.PerformLayout();
            this.groupBoxOutput_KAA.ResumeLayout(false);
            this.groupBoxOutput_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHeading_KAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KAA;
        private System.Windows.Forms.Button buttonResult_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.TextBox textBoxCondition_KAA;
        private System.Windows.Forms.GroupBox groupBoxInput_KAA;
        private System.Windows.Forms.TextBox textBoxVariable_KAA;
        private System.Windows.Forms.TextBox textBoxInput_KAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KAA;
        private System.Windows.Forms.TextBox textBoxTextResult_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
    }
}

