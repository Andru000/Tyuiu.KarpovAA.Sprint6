
namespace Tyuiu.KarpovAA.Sprint6.Task2.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.buttonResult_KAA = new System.Windows.Forms.Button();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_KAA = new System.Windows.Forms.TextBox();
            this.textBoxVarB_KAA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_KAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.dataGridViewResult_KAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResult_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxTask_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(438, 128);
            this.groupBoxTask_KAA.TabIndex = 0;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Location = new System.Drawing.Point(18, 26);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(414, 82);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = " Протабулировать функцию sin(x) на заданеом диапазоне. Результат вывести в DataGr" +
    "idViev и построить график функции";
            // 
            // buttonResult_KAA
            // 
            this.buttonResult_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResult_KAA.Location = new System.Drawing.Point(367, 207);
            this.buttonResult_KAA.Name = "buttonResult_KAA";
            this.buttonResult_KAA.Size = new System.Drawing.Size(112, 78);
            this.buttonResult_KAA.TabIndex = 1;
            this.buttonResult_KAA.Text = "Выполнить";
            this.buttonResult_KAA.UseVisualStyleBackColor = false;
            this.buttonResult_KAA.Click += new System.EventHandler(this.buttonResult_KAA_Click);
            this.buttonResult_KAA.Enter += new System.EventHandler(this.buttonResult_KAA_Enter);
            this.buttonResult_KAA.Leave += new System.EventHandler(this.buttonResult_KAA_Leave);
            this.buttonResult_KAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_KAA_MouseDown);
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.chartResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.dataGridViewResult_KAA);
            this.groupBoxResult_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(498, 3);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(519, 307);
            this.groupBoxResult_KAA.TabIndex = 2;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод данных";
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxEnd_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarB_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxVarA_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxInPut_KAA.Location = new System.Drawing.Point(12, 156);
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.Size = new System.Drawing.Size(235, 129);
            this.groupBoxInPut_KAA.TabIndex = 3;
            this.groupBoxInPut_KAA.TabStop = false;
            this.groupBoxInPut_KAA.Text = "Ввод данных";
            // 
            // textBoxEnd_KAA
            // 
            this.textBoxEnd_KAA.Location = new System.Drawing.Point(122, 51);
            this.textBoxEnd_KAA.Name = "textBoxEnd_KAA";
            this.textBoxEnd_KAA.ReadOnly = true;
            this.textBoxEnd_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd_KAA.TabIndex = 2;
            this.textBoxEnd_KAA.Text = "Конец шага:";
            // 
            // textBoxVarB_KAA
            // 
            this.textBoxVarB_KAA.Location = new System.Drawing.Point(122, 96);
            this.textBoxVarB_KAA.Name = "textBoxVarB_KAA";
            this.textBoxVarB_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarB_KAA.TabIndex = 1;
            // 
            // textBoxVarA_KAA
            // 
            this.textBoxVarA_KAA.Location = new System.Drawing.Point(6, 96);
            this.textBoxVarA_KAA.Name = "textBoxVarA_KAA";
            this.textBoxVarA_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA_KAA.TabIndex = 0;
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(6, 51);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.ReadOnly = true;
            this.textBoxStart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KAA.TabIndex = 0;
            this.textBoxStart_KAA.Text = "Старт шага:";
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(253, 207);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(108, 78);
            this.buttonHelp_KAA.TabIndex = 4;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // dataGridViewResult_KAA
            // 
            this.dataGridViewResult_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewResult_KAA.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewResult_KAA.Name = "dataGridViewResult_KAA";
            this.dataGridViewResult_KAA.RowHeadersVisible = false;
            this.dataGridViewResult_KAA.Size = new System.Drawing.Size(124, 273);
            this.dataGridViewResult_KAA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // chartResult_KAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_KAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_KAA.Legends.Add(legend2);
            this.chartResult_KAA.Location = new System.Drawing.Point(136, 26);
            this.chartResult_KAA.Name = "chartResult_KAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_KAA.Series.Add(series2);
            this.chartResult_KAA.Size = new System.Drawing.Size(383, 273);
            this.chartResult_KAA.TabIndex = 1;
            this.chartResult_KAA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.buttonHelp_KAA);
            this.Controls.Add(this.groupBoxInPut_KAA);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.buttonResult_KAA);
            this.Controls.Add(this.groupBoxTask_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Карпов А. А.";
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.Button buttonResult_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.TextBox textBoxEnd_KAA;
        private System.Windows.Forms.TextBox textBoxVarB_KAA;
        private System.Windows.Forms.TextBox textBoxVarA_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

