using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.KarpovAA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonResult_KAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxVarA_KAA.Text);
                int stopValue = Convert.ToInt32(textBoxVarB_KAA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxOutPut_KAA.Text = "";

                textBoxOutPut_KAA.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxOutPut_KAA.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxOutPut_KAA.AppendText("+---------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}  |", startValue, valueArray[i]);
                    textBoxOutPut_KAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxOutPut_KAA.AppendText("+---------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Карпов Андрей Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
