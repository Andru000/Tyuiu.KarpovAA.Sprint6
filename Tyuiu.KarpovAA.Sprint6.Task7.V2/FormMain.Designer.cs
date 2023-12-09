
namespace Tyuiu.KarpovAA.Sprint6.Task7.V2
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
            this.panelTop_KAA = new System.Windows.Forms.Panel();
            this.panelLeft_KAA = new System.Windows.Forms.Panel();
            this.panelRight_KAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.dataGridViewInPut_KAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_Put_KAA = new System.Windows.Forms.DataGridView();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonOpen_KAA = new System.Windows.Forms.Button();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.panelTop_KAA.SuspendLayout();
            this.panelLeft_KAA.SuspendLayout();
            this.panelRight_KAA.SuspendLayout();
            this.groupBoxTask_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            this.groupBoxOutPut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_Put_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_KAA
            // 
            this.panelTop_KAA.Controls.Add(this.buttonSave_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonHelp_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonOpen_KAA);
            this.panelTop_KAA.Controls.Add(this.groupBoxTask_KAA);
            this.panelTop_KAA.Controls.Add(this.buttonDone_KAA);
            this.panelTop_KAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KAA.Name = "panelTop_KAA";
            this.panelTop_KAA.Size = new System.Drawing.Size(800, 139);
            this.panelTop_KAA.TabIndex = 0;
            // 
            // panelLeft_KAA
            // 
            this.panelLeft_KAA.Controls.Add(this.groupBoxInPut_KAA);
            this.panelLeft_KAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KAA.Location = new System.Drawing.Point(0, 139);
            this.panelLeft_KAA.Name = "panelLeft_KAA";
            this.panelLeft_KAA.Size = new System.Drawing.Size(400, 311);
            this.panelLeft_KAA.TabIndex = 1;
            // 
            // panelRight_KAA
            // 
            this.panelRight_KAA.Controls.Add(this.groupBoxOutPut_KAA);
            this.panelRight_KAA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_KAA.Location = new System.Drawing.Point(401, 139);
            this.panelRight_KAA.Name = "panelRight_KAA";
            this.panelRight_KAA.Size = new System.Drawing.Size(399, 311);
            this.panelRight_KAA.TabIndex = 2;
            // 
            // groupBoxTask_KAA
            // 
            this.groupBoxTask_KAA.Controls.Add(this.textBoxTask_KAA);
            this.groupBoxTask_KAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTask_KAA.Location = new System.Drawing.Point(0, 70);
            this.groupBoxTask_KAA.Name = "groupBoxTask_KAA";
            this.groupBoxTask_KAA.Size = new System.Drawing.Size(800, 69);
            this.groupBoxTask_KAA.TabIndex = 2;
            this.groupBoxTask_KAA.TabStop = false;
            this.groupBoxTask_KAA.Text = "Условие:";
            // 
            // groupBoxInPut_KAA
            // 
            this.groupBoxInPut_KAA.Controls.Add(this.dataGridViewInPut_KAA);
            this.groupBoxInPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_KAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_KAA.Name = "groupBoxInPut_KAA";
            this.groupBoxInPut_KAA.Size = new System.Drawing.Size(400, 311);
            this.groupBoxInPut_KAA.TabIndex = 0;
            this.groupBoxInPut_KAA.TabStop = false;
            this.groupBoxInPut_KAA.Text = "Ввод:";
            // 
            // groupBoxOutPut_KAA
            // 
            this.groupBoxOutPut_KAA.Controls.Add(this.dataGridViewOut_Put_KAA);
            this.groupBoxOutPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KAA.Name = "groupBoxOutPut_KAA";
            this.groupBoxOutPut_KAA.Size = new System.Drawing.Size(399, 311);
            this.groupBoxOutPut_KAA.TabIndex = 0;
            this.groupBoxOutPut_KAA.TabStop = false;
            this.groupBoxOutPut_KAA.Text = "Вывод:";
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_KAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(794, 50);
            this.textBoxTask_KAA.TabIndex = 0;
            this.textBoxTask_KAA.Text = resources.GetString("textBoxTask_KAA.Text");
            // 
            // dataGridViewInPut_KAA
            // 
            this.dataGridViewInPut_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_KAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_KAA.Name = "dataGridViewInPut_KAA";
            this.dataGridViewInPut_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_KAA.Size = new System.Drawing.Size(394, 292);
            this.dataGridViewInPut_KAA.TabIndex = 0;
            // 
            // dataGridViewOut_Put_KAA
            // 
            this.dataGridViewOut_Put_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_Put_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_Put_KAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_Put_KAA.Name = "dataGridViewOut_Put_KAA";
            this.dataGridViewOut_Put_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewOut_Put_KAA.Size = new System.Drawing.Size(393, 292);
            this.dataGridViewOut_Put_KAA.TabIndex = 0;
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.page_save;
            this.buttonSave_KAA.Location = new System.Drawing.Point(194, 10);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(75, 53);
            this.buttonSave_KAA.TabIndex = 5;
            this.buttonSave_KAA.UseVisualStyleBackColor = true;
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.help;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(701, 9);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(75, 54);
            this.buttonHelp_KAA.TabIndex = 4;
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            // 
            // buttonOpen_KAA
            // 
            this.buttonOpen_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.folder_page;
            this.buttonOpen_KAA.Location = new System.Drawing.Point(12, 11);
            this.buttonOpen_KAA.Name = "buttonOpen_KAA";
            this.buttonOpen_KAA.Size = new System.Drawing.Size(75, 53);
            this.buttonOpen_KAA.TabIndex = 3;
            this.buttonOpen_KAA.UseVisualStyleBackColor = true;
            this.buttonOpen_KAA.Click += new System.EventHandler(this.buttonOpen_KAA_Click);
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.page_white_go;
            this.buttonDone_KAA.Location = new System.Drawing.Point(102, 11);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(75, 52);
            this.buttonDone_KAA.TabIndex = 1;
            this.buttonDone_KAA.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_KAA);
            this.Controls.Add(this.panelLeft_KAA);
            this.Controls.Add(this.panelTop_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Карпов А. А";
            this.panelTop_KAA.ResumeLayout(false);
            this.panelLeft_KAA.ResumeLayout(false);
            this.panelRight_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.groupBoxInPut_KAA.ResumeLayout(false);
            this.groupBoxOutPut_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_Put_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.Button buttonHelp_KAA;
        private System.Windows.Forms.Button buttonOpen_KAA;
        private System.Windows.Forms.GroupBox groupBoxTask_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
        private System.Windows.Forms.Button buttonDone_KAA;
        private System.Windows.Forms.Panel panelLeft_KAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KAA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KAA;
        private System.Windows.Forms.Panel panelRight_KAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_Put_KAA;
    }
}

