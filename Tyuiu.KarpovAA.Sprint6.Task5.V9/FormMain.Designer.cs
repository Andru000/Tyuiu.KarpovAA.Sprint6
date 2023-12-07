
namespace Tyuiu.KarpovAA.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonResult_KAA = new System.Windows.Forms.Button();
            this.panelTop_KAA = new System.Windows.Forms.Panel();
            this.panelLeft_KAA = new System.Windows.Forms.Panel();
            this.panelMidle_KAA = new System.Windows.Forms.Panel();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonOpen_KAA = new System.Windows.Forms.Button();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.chartResult_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_KAA = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop_KAA.SuspendLayout();
            this.panelLeft_KAA.SuspendLayout();
            this.panelMidle_KAA.SuspendLayout();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_KAA
            // 
            this.buttonResult_KAA.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonResult_KAA.Location = new System.Drawing.Point(446, 22);
            this.buttonResult_KAA.Name = "buttonResult_KAA";
            this.buttonResult_KAA.Size = new System.Drawing.Size(111, 66);
            this.buttonResult_KAA.TabIndex = 0;
            this.buttonResult_KAA.Text = "Выполнить";
            this.buttonResult_KAA.UseVisualStyleBackColor = false;
            this.buttonResult_KAA.Click += new System.EventHandler(this.buttonResult_KAA_Click);
            // 
            // panelTop_KAA
            // 
            this.panelTop_KAA.BackColor = System.Drawing.Color.Aqua;
            this.panelTop_KAA.Controls.Add(this.groupBoxTask_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonOpen_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonHelp_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonResult_KAA);
            this.panelTop_KAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KAA.Name = "panelTop_KAA";
            this.panelTop_KAA.Size = new System.Drawing.Size(800, 100);
            this.panelTop_KAA.TabIndex = 1;
            // 
            // panelLeft_KAA
            // 
            this.panelLeft_KAA.BackColor = System.Drawing.Color.LightCyan;
            this.panelLeft_KAA.Controls.Add(this.groupBoxResult_KAA);
            this.panelLeft_KAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KAA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_KAA.Name = "panelLeft_KAA";
            this.panelLeft_KAA.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_KAA.TabIndex = 2;
            // 
            // panelMidle_KAA
            // 
            this.panelMidle_KAA.BackColor = System.Drawing.Color.Aquamarine;
            this.panelMidle_KAA.Controls.Add(this.chartResult_KAA);
            this.panelMidle_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidle_KAA.Location = new System.Drawing.Point(200, 100);
            this.panelMidle_KAA.Name = "panelMidle_KAA";
            this.panelMidle_KAA.Size = new System.Drawing.Size(600, 350);
            this.panelMidle_KAA.TabIndex = 3;
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(675, 22);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(99, 66);
            this.buttonHelp_KAA.TabIndex = 1;
            this.buttonHelp_KAA.Text = "Справка";
            this.buttonHelp_KAA.UseVisualStyleBackColor = false;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            // 
            // buttonOpen_KAA
            // 
            this.buttonOpen_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonOpen_KAA.Location = new System.Drawing.Point(563, 22);
            this.buttonOpen_KAA.Name = "buttonOpen_KAA";
            this.buttonOpen_KAA.Size = new System.Drawing.Size(106, 66);
            this.buttonOpen_KAA.TabIndex = 2;
            this.buttonOpen_KAA.Text = "Открыть файл";
            this.buttonOpen_KAA.UseVisualStyleBackColor = false;
            this.buttonOpen_KAA.Click += new System.EventHandler(this.buttonOpen_KAA_Click);
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(428, 91);
            this.groupBoxTask_KAA.TabIndex = 3;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие";
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.dataGridViewResult_KAA);
            this.groupBoxResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(200, 350);
            this.groupBoxResult_KAA.TabIndex = 0;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод данных";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(380, 66);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView.Дан список" +
    " из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значениям" +
    ".";
            // 
            // chartResult_KAA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_KAA.ChartAreas.Add(chartArea4);
            this.chartResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartResult_KAA.Legends.Add(legend4);
            this.chartResult_KAA.Location = new System.Drawing.Point(0, 0);
            this.chartResult_KAA.Name = "chartResult_KAA";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chartResult_KAA.Series.Add(series4);
            this.chartResult_KAA.Size = new System.Drawing.Size(600, 350);
            this.chartResult_KAA.TabIndex = 0;
            this.chartResult_KAA.Text = "chart1";
            // 
            // dataGridViewResult_KAA
            // 
            this.dataGridViewResult_KAA.AllowUserToDeleteRows = false;
            this.dataGridViewResult_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column2});
            this.dataGridViewResult_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_KAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_KAA.Name = "dataGridViewResult_KAA";
            this.dataGridViewResult_KAA.ReadOnly = true;
            this.dataGridViewResult_KAA.RowHeadersVisible = false;
            this.dataGridViewResult_KAA.Size = new System.Drawing.Size(194, 331);
            this.dataGridViewResult_KAA.TabIndex = 1;
            // 
            // Column
            // 
            this.Column.FillWeight = 300F;
            this.Column.HeaderText = "№";
            this.Column.MinimumWidth = 100;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 200;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 300F;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
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
            this.Text = "Спринт 6 | Таск 5 | Вариант 9 | Карпов А. А";
            this.panelTop_KAA.ResumeLayout(false);
            this.panelLeft_KAA.ResumeLayout(false);
            this.panelMidle_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_KAA;
        private System.Windows.Forms.Panel panelTop_KAA;
        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.Button buttonOpen_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.Panel panelLeft_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.Panel panelMidle_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

