
namespace Tyuiu.FaizullinDR.Sprint6.Task5.V11
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOpenFile_FDR = new System.Windows.Forms.Button();
            this.groupBoxOutPut_FDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_FDR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_FDR = new System.Windows.Forms.Label();
            this.buttonInfo_FDR = new System.Windows.Forms.Button();
            this.buttonDone_FDR = new System.Windows.Forms.Button();
            this.groupBoxTask_FDR = new System.Windows.Forms.GroupBox();
            this.labelTask2_FDR = new System.Windows.Forms.Label();
            this.labelTask_FDR = new System.Windows.Forms.Label();
            this.chartResult_FDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_FDR)).BeginInit();
            this.groupBoxTask_FDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_FDR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_FDR
            // 
            this.buttonOpenFile_FDR.BackColor = System.Drawing.Color.Lime;
            this.buttonOpenFile_FDR.Location = new System.Drawing.Point(962, 12);
            this.buttonOpenFile_FDR.Name = "buttonOpenFile_FDR";
            this.buttonOpenFile_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonOpenFile_FDR.TabIndex = 32;
            this.buttonOpenFile_FDR.Text = "Открыть файл";
            this.buttonOpenFile_FDR.UseVisualStyleBackColor = false;
            this.buttonOpenFile_FDR.Click += new System.EventHandler(this.buttonOpenFile_FDR_Click_1);
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutPut_FDR.Controls.Add(this.dataGridViewResult_FDR);
            this.groupBoxOutPut_FDR.Controls.Add(this.labelResult_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(11, 138);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(352, 489);
            this.groupBoxOutPut_FDR.TabIndex = 31;
            this.groupBoxOutPut_FDR.TabStop = false;
            this.groupBoxOutPut_FDR.Text = "Вывод данных";
            // 
            // dataGridViewResult_FDR
            // 
            this.dataGridViewResult_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewResult_FDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_FDR.ColumnHeadersVisible = false;
            this.dataGridViewResult_FDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_FDR.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewResult_FDR.Name = "dataGridViewResult_FDR";
            this.dataGridViewResult_FDR.ReadOnly = true;
            this.dataGridViewResult_FDR.RowHeadersVisible = false;
            this.dataGridViewResult_FDR.RowHeadersWidth = 51;
            this.dataGridViewResult_FDR.RowTemplate.Height = 24;
            this.dataGridViewResult_FDR.Size = new System.Drawing.Size(343, 465);
            this.dataGridViewResult_FDR.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // labelResult_FDR
            // 
            this.labelResult_FDR.AutoSize = true;
            this.labelResult_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelResult_FDR.Name = "labelResult_FDR";
            this.labelResult_FDR.Size = new System.Drawing.Size(76, 17);
            this.labelResult_FDR.TabIndex = 0;
            this.labelResult_FDR.Text = "Результат";
            // 
            // buttonInfo_FDR
            // 
            this.buttonInfo_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_FDR.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_FDR.Location = new System.Drawing.Point(1089, 12);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonInfo_FDR.TabIndex = 30;
            this.buttonInfo_FDR.Text = "Справка";
            this.buttonInfo_FDR.UseVisualStyleBackColor = false;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // buttonDone_FDR
            // 
            this.buttonDone_FDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_FDR.Location = new System.Drawing.Point(835, 12);
            this.buttonDone_FDR.Name = "buttonDone_FDR";
            this.buttonDone_FDR.Size = new System.Drawing.Size(121, 120);
            this.buttonDone_FDR.TabIndex = 29;
            this.buttonDone_FDR.Text = "Выполнить";
            this.buttonDone_FDR.UseVisualStyleBackColor = false;
            this.buttonDone_FDR.Click += new System.EventHandler(this.buttonDone_FDR_Click);
            // 
            // groupBoxTask_FDR
            // 
            this.groupBoxTask_FDR.Controls.Add(this.labelTask2_FDR);
            this.groupBoxTask_FDR.Controls.Add(this.labelTask_FDR);
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(11, 12);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(818, 120);
            this.groupBoxTask_FDR.TabIndex = 28;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие";
            // 
            // labelTask2_FDR
            // 
            this.labelTask2_FDR.AutoSize = true;
            this.labelTask2_FDR.Location = new System.Drawing.Point(6, 35);
            this.labelTask2_FDR.Name = "labelTask2_FDR";
            this.labelTask2_FDR.Size = new System.Drawing.Size(287, 17);
            this.labelTask2_FDR.TabIndex = 2;
            this.labelTask2_FDR.Text = "Построить диаграмму по этим значениям.";
            // 
            // labelTask_FDR
            // 
            this.labelTask_FDR.AutoSize = true;
            this.labelTask_FDR.Location = new System.Drawing.Point(6, 18);
            this.labelTask_FDR.Name = "labelTask_FDR";
            this.labelTask_FDR.Size = new System.Drawing.Size(487, 17);
            this.labelTask_FDR.TabIndex = 0;
            this.labelTask_FDR.Text = "Прочитать данные из файла и вывести в dataGridView числа, кратные 5";
            // 
            // chartResult_FDR
            // 
            this.chartResult_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chartResult_FDR.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartResult_FDR.Legends.Add(legend5);
            this.chartResult_FDR.Location = new System.Drawing.Point(363, 138);
            this.chartResult_FDR.Name = "chartResult_FDR";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_FDR.Series.Add(series5);
            this.chartResult_FDR.Size = new System.Drawing.Size(847, 489);
            this.chartResult_FDR.TabIndex = 33;
            this.chartResult_FDR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 639);
            this.Controls.Add(this.chartResult_FDR);
            this.Controls.Add(this.buttonOpenFile_FDR);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.buttonDone_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 11 | Файзуллин Д. Р.";
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_FDR)).EndInit();
            this.groupBoxTask_FDR.ResumeLayout(false);
            this.groupBoxTask_FDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_FDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_FDR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_FDR;
        private System.Windows.Forms.DataGridView dataGridViewResult_FDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label labelResult_FDR;
        private System.Windows.Forms.Button buttonInfo_FDR;
        private System.Windows.Forms.Button buttonDone_FDR;
        private System.Windows.Forms.GroupBox groupBoxTask_FDR;
        private System.Windows.Forms.Label labelTask2_FDR;
        private System.Windows.Forms.Label labelTask_FDR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_FDR;
    }
}

