using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.FaizullinDR.Sprint6.Task7.V9.Lib;

namespace Tyuiu.FaizullinDR.Sprint6.Task7.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static string openFilePath;

        private void buttonOpenFile_FDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_FDR.ShowDialog();
            openFilePath = openFileDialogTask_FDR.FileName;

            int[,] matrix = ds.GetMatrix(openFilePath);

            dataGridViewIn_FDR.RowCount = matrix.GetLength(0);
            dataGridViewIn_FDR.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_FDR.RowCount = matrix.GetLength(0);
            dataGridViewOut_FDR.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewIn_FDR.Columns[i].Width = 25;
                dataGridViewOut_FDR.Columns[i].Width = 25;
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    dataGridViewIn_FDR.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_FDR.Enabled = true;
        }

        private void buttonInfo_FDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_FDR_Click(object sender, EventArgs e)
        {
            string path = @"C:\DataSprint6\InPutFileTask7V9.csv";
            int[,] matrix = ds.GetMatrix(path);

            for (int r = 0; r < dataGridViewOut_FDR.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOut_FDR.ColumnCount; c++)
                {
                    if ((c == 2) && (matrix[r, c] >= 1) && (matrix[r, c] <= 5))
                        dataGridViewOut_FDR.Rows[r].Cells[c].Value = 7;
                    else
                        dataGridViewOut_FDR.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSaveFile_FDR.Enabled = true;
        }

        private void buttonSaveFile_FDR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_FDR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_FDR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_FDR.ShowDialog();

            string path = saveFileDialogMatrix_FDR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(path);

            int rows = dataGridViewOut_FDR.RowCount;
            int columns = dataGridViewOut_FDR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += dataGridViewOut_FDR.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOut_FDR.Rows[i].Cells[j].Value;

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void groupBoxTask_FDR_Enter(object sender, EventArgs e)
        {

        }
    }
}
