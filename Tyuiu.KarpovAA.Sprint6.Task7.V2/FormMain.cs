using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint6.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAA.ShowDialog();
            openFilePath = openFileDialogTask_KAA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_KAA.ColumnCount = columns;
            dataGridViewInPut_KAA.RowCount = rows;
            dataGridViewOutPut_KAA.ColumnCount = columns;
            dataGridViewOutPut_KAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_KAA.Columns[i].Width = 25;
                dataGridViewOutPut_KAA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KAA.Enabled = true;
        }

        private void buttonDone_KAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KAA.Enabled = true;
        }

        private void buttonSave_KAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAA.ShowDialog();

            string path = saveFileDialogMatrix_KAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_KAA.RowCount;
            int columns = dataGridViewOutPut_KAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_KAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_KAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_KAA.ColumnCount = 50;
            dataGridViewOutPut_KAA.ColumnCount = 50;

            dataGridViewInPut_KAA.RowCount = 50;
            dataGridViewOutPut_KAA.RowCount = 50;

            panelLeft_KAA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_KAA.Columns[i].Width = 25;
                dataGridViewOutPut_KAA.Columns[i].Width = 25;
            }
        }

        private void buttonDone_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KAA.ToolTipTitle = "Выполнить";
        }

        private void buttonOpen_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonSave_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelpButtons_KAA.ToolTipTitle = "Справка";
        }
    }
    
}
