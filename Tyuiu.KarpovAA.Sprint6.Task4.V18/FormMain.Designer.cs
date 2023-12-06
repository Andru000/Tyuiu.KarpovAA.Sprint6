
namespace Tyuiu.KarpovAA.Sprint6.Task4.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonResult_KAA = new System.Windows.Forms.Button();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutStart_KAA = new System.Windows.Forms.TextBox();
            this.textBoxEnd_KAA = new System.Windows.Forms.TextBox();
            this.textBoxInPutEnd_KAA = new System.Windows.Forms.TextBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.chartResult_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_KAA = new System.Windows.Forms.Panel();
            this.panelLeft_KAA = new System.Windows.Forms.Panel();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.panelMidle_KAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).BeginInit();
            this.panelTop_KAA.SuspendLayout();
            this.panelLeft_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            this.panelMidle_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonResult_KAA
            // 
            this.buttonResult_KAA.BackColor = System.Drawing.Color.Lime;
            this.buttonResult_KAA.Location = new System.Drawing.Point(544, 29);
            this.buttonResult_KAA.Name = "buttonResult_KAA";
            this.buttonResult_KAA.Size = new System.Drawing.Size(75, 63);
            this.buttonResult_KAA.TabIndex = 0;
            this.buttonResult_KAA.Text = "Выполнить";
            this.buttonResult_KAA.UseVisualStyleBackColor = false;
            this.buttonResult_KAA.Click += new System.EventHandler(this.buttonResult_KAA_Click);
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(358, 97);
            this.groupBoxTask_KAA.TabIndex = 1;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_KAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(346, 70);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = "Протабулироать функцию sin(x) на заданном диапазоне от -5 до 5. Построить график " +
    "функции и сохронить в файл OutPutFileTask4.txt по нажатию кнопки";
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxInPutEnd_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxEnd_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxInPutStart_KAA);
            this.groupBoxInPut_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxInPut_KAA.Location = new System.Drawing.Point(367, 12);
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.Size = new System.Drawing.Size(171, 88);
            this.groupBoxInPut_KAA.TabIndex = 2;
            this.groupBoxInPut_KAA.TabStop = false;
            this.groupBoxInPut_KAA.Text = "Ввод данных";
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.ReadOnly = true;
            this.textBoxStart_KAA.Size = new System.Drawing.Size(77, 20);
            this.textBoxStart_KAA.TabIndex = 0;
            this.textBoxStart_KAA.Text = "Старт шага:";
            // 
            // textBoxInPutStart_KAA
            // 
            this.textBoxInPutStart_KAA.Location = new System.Drawing.Point(6, 46);
            this.textBoxInPutStart_KAA.Name = "textBoxInPutStart_KAA";
            this.textBoxInPutStart_KAA.Size = new System.Drawing.Size(78, 20);
            this.textBoxInPutStart_KAA.TabIndex = 1;
            // 
            // textBoxEnd_KAA
            // 
            this.textBoxEnd_KAA.Location = new System.Drawing.Point(90, 20);
            this.textBoxEnd_KAA.Name = "textBoxEnd_KAA";
            this.textBoxEnd_KAA.ReadOnly = true;
            this.textBoxEnd_KAA.Size = new System.Drawing.Size(73, 20);
            this.textBoxEnd_KAA.TabIndex = 2;
            this.textBoxEnd_KAA.Text = "Конец шага:";
            // 
            // textBoxInPutEnd_KAA
            // 
            this.textBoxInPutEnd_KAA.Location = new System.Drawing.Point(90, 46);
            this.textBoxInPutEnd_KAA.Name = "textBoxInPutEnd_KAA";
            this.textBoxInPutEnd_KAA.Size = new System.Drawing.Size(73, 20);
            this.textBoxInPutEnd_KAA.TabIndex = 3;
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(230, 320);
            this.textBoxResult_KAA.TabIndex = 3;
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(714, 29);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(83, 63);
            this.buttonHelp_KAA.TabIndex = 5;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSave_KAA.Location = new System.Drawing.Point(625, 29);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(83, 61);
            this.buttonSave_KAA.TabIndex = 6;
            this.buttonSave_KAA.Text = "Сохранить";
            this.buttonSave_KAA.UseVisualStyleBackColor = false;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSave_KAA_Click);
            // 
            // chartResult_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_KAA.ChartAreas.Add(chartArea1);
            this.chartResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_KAA.Legends.Add(legend1);
            this.chartResult_KAA.Location = new System.Drawing.Point(0, 0);
            this.chartResult_KAA.Name = "chartResult_KAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_KAA.Series.Add(series1);
            this.chartResult_KAA.Size = new System.Drawing.Size(564, 339);
            this.chartResult_KAA.TabIndex = 7;
            this.chartResult_KAA.Text = "chart1";
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)";
            this.chartResult_KAA.Titles.Add(title1);
            // 
            // panelTop_KAA
            // 
            this.panelTop_KAA.BackColor = System.Drawing.Color.DarkViolet;
            this.panelTop_KAA.Controls.Add(this.groupBoxTask_KAA);
            this.panelTop_KAA.Controls.Add(this.groupBoxInPut_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonHelp_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonSave_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonResult_KAA);
            this.panelTop_KAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KAA.Name = "panelTop_KAA";
            this.panelTop_KAA.Size = new System.Drawing.Size(800, 111);
            this.panelTop_KAA.TabIndex = 8;
            // 
            // panelLeft_KAA
            // 
            this.panelLeft_KAA.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelLeft_KAA.Controls.Add(this.groupBoxResult_KAA);
            this.panelLeft_KAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KAA.Location = new System.Drawing.Point(0, 111);
            this.panelLeft_KAA.Name = "panelLeft_KAA";
            this.panelLeft_KAA.Size = new System.Drawing.Size(236, 339);
            this.panelLeft_KAA.TabIndex = 9;
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(236, 339);
            this.groupBoxResult_KAA.TabIndex = 1;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод";
            // 
            // panelMidle_KAA
            // 
            this.panelMidle_KAA.BackColor = System.Drawing.Color.Violet;
            this.panelMidle_KAA.Controls.Add(this.chartResult_KAA);
            this.panelMidle_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidle_KAA.Location = new System.Drawing.Point(236, 111);
            this.panelMidle_KAA.Name = "panelMidle_KAA";
            this.panelMidle_KAA.Size = new System.Drawing.Size(564, 339);
            this.panelMidle_KAA.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMidle_KAA);
            this.Controls.Add(this.panelLeft_KAA);
            this.Controls.Add(this.panelTop_KAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 18 | Карпов А. А";
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxInPut_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).EndInit();
            this.panelTop_KAA.ResumeLayout(false);
            this.panelLeft_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.PerformLayout();
            this.panelMidle_KAA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_KAA;
        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KAA;
        private System.Windows.Forms.TextBox textBoxInPutEnd_KAA;
        private System.Windows.Forms.TextBox textBoxEnd_KAA;
        private System.Windows.Forms.TextBox textBoxInPutStart_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAA;
        private System.Windows.Forms.Panel panelTop_KAA;
        private System.Windows.Forms.Panel panelLeft_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.Panel panelMidle_KAA;
    }
}

