using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint6.Task5.V9.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\karpo\source\repos\Tyuiu.KarpovAA.Sprint6\Tyuiu.KarpovAA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

        private void buttonResult_KAA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KAA.ColumnCount = 2;
            dataGridViewResult_KAA.Columns[0].Width = 20;
            dataGridViewResult_KAA.Columns[1].Width = 50;

            this.chartResult_KAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_KAA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_KAA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_KAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Карпов Андрей Андрей", "Сообщение");
        }
    }
}
