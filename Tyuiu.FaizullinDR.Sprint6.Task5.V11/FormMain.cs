using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.FaizullinDR.Sprint6.Task5.V11.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartResult_FDR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_FDR.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_FDR.Series[0].Points.Clear();
                dataGridViewResult_FDR.Rows.Clear();

                double[] Value = ds.LoadFromDataFile(path);

                for (int i = 0; i < Value.Length; i++)
                {
                    chartResult_FDR.Series[0].Points.AddXY(i, Value[i]);
                    dataGridViewResult_FDR.Rows.Add(i, Value[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        private void buttonOpenFile_FDR_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-3 Файзуллин Данил Рамилевич", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
