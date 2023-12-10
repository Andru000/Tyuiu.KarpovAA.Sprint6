
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_KAA = new System.Windows.Forms.Panel();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.buttonHelp_KAA = new System.Windows.Forms.Button();
            this.buttonOpen_KAA = new System.Windows.Forms.Button();
            this.groupBoxTask_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.panelLeft_KAA = new System.Windows.Forms.Panel();
            this.groupBoxInPut_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_KAA = new System.Windows.Forms.DataGridView();
            this.panelRight_KAA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_KAA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_KAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelpButtons_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_KAA = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_KAA.SuspendLayout();
            this.groupBoxTask_KAA.SuspendLayout();
            this.panelLeft_KAA.SuspendLayout();
            this.groupBoxInPut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAA)).BeginInit();
            this.panelRight_KAA.SuspendLayout();
            this.groupBoxOutPut_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KAA)).BeginInit();
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
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.Enabled = false;
            this.buttonSave_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.page_save;
            this.buttonSave_KAA.Location = new System.Drawing.Point(194, 10);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(75, 53);
            this.buttonSave_KAA.TabIndex = 5;
            this.buttonSave_KAA.UseVisualStyleBackColor = true;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSave_KAA_Click);
            this.buttonSave_KAA.MouseEnter += new System.EventHandler(this.buttonSave_KAA_MouseEnter);
            // 
            // buttonHelp_KAA
            // 
            this.buttonHelp_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.help;
            this.buttonHelp_KAA.Location = new System.Drawing.Point(701, 9);
            this.buttonHelp_KAA.Name = "buttonHelp_KAA";
            this.buttonHelp_KAA.Size = new System.Drawing.Size(75, 54);
            this.buttonHelp_KAA.TabIndex = 4;
            this.buttonHelp_KAA.UseVisualStyleBackColor = true;
            this.buttonHelp_KAA.Click += new System.EventHandler(this.buttonHelp_KAA_Click);
            this.buttonHelp_KAA.MouseEnter += new System.EventHandler(this.buttonHelp_KAA_MouseEnter);
            // 
            // buttonOpen_KAA
            // 
            this.buttonOpen_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.folder_page;
            this.buttonOpen_KAA.Location = new System.Drawing.Point(12, 11);
            this.buttonOpen_KAA.Name = "buttonOpen_KAA";
            this.buttonOpen_KAA.Size = new System.Drawing.Size(75, 53);
            this.buttonOpen_KAA.TabIndex = 3;
            this.buttonOpen_KAA.UseVisualStyleBackColor = true;
            this.buttonOpen_KAA.Click += new System.EventHandler(this.buttonOpen_KAA_Click);
            this.buttonOpen_KAA.MouseEnter += new System.EventHandler(this.buttonOpen_KAA_MouseEnter);
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
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.Enabled = false;
            this.buttonDone_KAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KAA.Image = global::Tyuiu.KarpovAA.Sprint6.Task7.V2.Properties.Resources.page_white_go;
            this.buttonDone_KAA.Location = new System.Drawing.Point(102, 11);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(75, 52);
            this.buttonDone_KAA.TabIndex = 1;
            this.buttonDone_KAA.UseVisualStyleBackColor = true;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            this.buttonDone_KAA.MouseEnter += new System.EventHandler(this.buttonDone_KAA_MouseEnter);
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
            // dataGridViewInPut_KAA
            // 
            this.dataGridViewInPut_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KAA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_KAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_KAA.Name = "dataGridViewInPut_KAA";
            this.dataGridViewInPut_KAA.RowHeadersVisible = false;
            this.dataGridViewInPut_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_KAA.Size = new System.Drawing.Size(394, 292);
            this.dataGridViewInPut_KAA.TabIndex = 0;
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
            // groupBoxOutPut_KAA
            // 
            this.groupBoxOutPut_KAA.Controls.Add(this.dataGridViewOutPut_KAA);
            this.groupBoxOutPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KAA.Name = "groupBoxOutPut_KAA";
            this.groupBoxOutPut_KAA.Size = new System.Drawing.Size(399, 311);
            this.groupBoxOutPut_KAA.TabIndex = 0;
            this.groupBoxOutPut_KAA.TabStop = false;
            this.groupBoxOutPut_KAA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_KAA
            // 
            this.dataGridViewOutPut_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_KAA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_KAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_KAA.Name = "dataGridViewOutPut_KAA";
            this.dataGridViewOutPut_KAA.RowHeadersVisible = false;
            this.dataGridViewOutPut_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewOutPut_KAA.Size = new System.Drawing.Size(393, 292);
            this.dataGridViewOutPut_KAA.TabIndex = 0;
            // 
            // openFileDialogTask_KAA
            // 
            this.openFileDialogTask_KAA.FileName = "openFileDialog1";
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
            this.Text = "Спринт 6 | Таск 7 | Вариант 2 | Карпов А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.ResumeLayout(false);
            this.groupBoxTask_KAA.PerformLayout();
            this.panelLeft_KAA.ResumeLayout(false);
            this.groupBoxInPut_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAA)).EndInit();
            this.panelRight_KAA.ResumeLayout(false);
            this.groupBoxOutPut_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KAA)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewOutPut_KAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAA;
        private System.Windows.Forms.ToolTip toolTipHelpButtons_KAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KAA;
    }
}

