using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task6.V24.Lib;
using System.IO;

namespace Tyuiu.FaizullinDR.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonDone_FDR.Enabled = false;
        }
        
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask6V24.txt";
        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            textBoxOut_FDR.Text = ds.CollectTextFromFile(path);
        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_FDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_FDR.ShowDialog();
            path = openFileDialogTask_FDR.FileName;
            textBoxIn_FDR.Text = File.ReadAllText(path);
            groupBoxInPut_FDR.Text = groupBoxInPut_FDR.Text + " " + openFileDialogTask_FDR.FileName;
            buttonDone_FDR.Enabled = true;
        }
    }
}
