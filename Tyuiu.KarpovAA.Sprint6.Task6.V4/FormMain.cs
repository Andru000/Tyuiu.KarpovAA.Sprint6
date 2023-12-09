using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KarpovAA.Sprint6.Task6.V4.Lib;
using System.IO;

namespace Tyuiu.KarpovAA.Sprint6.Task6.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;

        private void buttonResult_KAA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_KAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_KAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAA.ShowDialog();
            openFilePath = openFileDialogTask_KAA.FileName;
            textBoxInPut_KAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KAA.Text = groupBoxOutPut_KAA.Text + " " + openFileDialogTask_KAA.FileName;
        }

        private void buttonHelp_KAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
