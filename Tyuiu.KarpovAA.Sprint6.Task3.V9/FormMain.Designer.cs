
namespace Tyuiu.KarpovAA.Sprint6.Task3.V9
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
            this.buttonResult_KAA = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_KAA = new System.Windows.Forms.DataGridView();
            this.textBoxTextRes_KAA = new System.Windows.Forms.TextBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_KAA
            // 
            this.buttonResult_KAA.Location = new System.Drawing.Point(514, 181);
            this.buttonResult_KAA.Name = "buttonResult_KAA";
            this.buttonResult_KAA.Size = new System.Drawing.Size(75, 40);
            this.buttonResult_KAA.TabIndex = 0;
            this.buttonResult_KAA.Text = "Выполнить";
            this.buttonResult_KAA.UseVisualStyleBackColor = true;
            this.buttonResult_KAA.Click += new System.EventHandler(this.buttonResult_KAA_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(468, 181);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(40, 40);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxTask_KAA.Controls.Add(this.dataGridViewMatrix_KAA);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(450, 209);
            this.groupBoxTask_KAA.TabIndex = 2;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.textBoxTextRes_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(477, 12);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(112, 83);
            this.groupBoxResult_KAA.TabIndex = 3;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод данных";
            // 
            // dataGridViewMatrix_KAA
            // 
            this.dataGridViewMatrix_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KAA.Location = new System.Drawing.Point(169, 19);
            this.dataGridViewMatrix_KAA.Name = "dataGridViewMatrix_KAA";
            this.dataGridViewMatrix_KAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_KAA.Size = new System.Drawing.Size(265, 172);
            this.dataGridViewMatrix_KAA.TabIndex = 0;
            // 
            // textBoxTextRes_KAA
            // 
            this.textBoxTextRes_KAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTextRes_KAA.Name = "textBoxTextRes_KAA";
            this.textBoxTextRes_KAA.ReadOnly = true;
            this.textBoxTextRes_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTextRes_KAA.TabIndex = 0;
            this.textBoxTextRes_KAA.Text = "Результат:";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxTask_KAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(157, 184);
            this.textBoxTask_KAA.TabIndex = 1;
            this.textBoxTask_KAA.Text = "Дана матрица 5 на 5:\r\n-14 25 26 18  17\r\n 28 10  6   -2   4\r\n 30 25 -3  11 -10\r\n 1" +
    "1 32 -5 -20  25\r\n 2 -18  11   8 -20\r\n Выполнить сортировку по возрастанию в пято" +
    "м столбце.";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(6, 45);
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_KAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 233);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonResult_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Карпов А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_KAA;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.TextBox textBoxTextRes_KAA;
    }
}

