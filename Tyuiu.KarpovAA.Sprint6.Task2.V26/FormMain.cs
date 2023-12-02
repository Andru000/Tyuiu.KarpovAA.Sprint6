using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint6.Task2.V26.Lib;

namespace Tyuiu.KarpovAA.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_KAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_KAA.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_KAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_KAA.Titles.Add("График функции");
                this.chartResult_KAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_KAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_KAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Карпов Андрей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonResult_KAA_Enter(object sender, EventArgs e)
        {
            buttonResult_KAA.BackColor = Color.Red;
        }

        private void buttonResult_KAA_Leave(object sender, EventArgs e)
        {
            buttonResult_KAA.BackColor = Color.Green;
        }

        private void buttonResult_KAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_KAA.BackColor = Color.Blue;
        }
    }
}
