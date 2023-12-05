
namespace Tyuiu.FaizullinDR.Sprint6.Task6.V24
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonOpenFile_FDR = new System.Windows.Forms.Button();
            this.buttonDone_FDR = new System.Windows.Forms.Button();
            this.buttonInfo_FDR = new System.Windows.Forms.Button();
            this.groupBoxTask_FDR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_FDR = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_FDR = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_FDR = new System.Windows.Forms.GroupBox();
            this.textBoxIn_FDR = new System.Windows.Forms.TextBox();
            this.textBoxOut_FDR = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_FDR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_FDR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_FDR.SuspendLayout();
            this.groupBoxInPut_FDR.SuspendLayout();
            this.groupBoxOutPut_FDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_FDR
            // 
            this.buttonOpenFile_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_FDR.Image")));
            this.buttonOpenFile_FDR.Location = new System.Drawing.Point(11, 3);
            this.buttonOpenFile_FDR.Name = "buttonOpenFile_FDR";
            this.buttonOpenFile_FDR.Size = new System.Drawing.Size(117, 81);
            this.buttonOpenFile_FDR.TabIndex = 0;
            this.toolTip_FDR.SetToolTip(this.buttonOpenFile_FDR, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_FDR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_FDR.Click += new System.EventHandler(this.buttonOpenFile_FDR_Click);
            // 
            // buttonDone_FDR
            // 
            this.buttonDone_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_FDR.Image")));
            this.buttonDone_FDR.Location = new System.Drawing.Point(134, 3);
            this.buttonDone_FDR.Name = "buttonDone_FDR";
            this.buttonDone_FDR.Size = new System.Drawing.Size(110, 81);
            this.buttonDone_FDR.TabIndex = 0;
            this.toolTip_FDR.SetToolTip(this.buttonDone_FDR, "Выполнить действия");
            this.buttonDone_FDR.UseVisualStyleBackColor = true;
            this.buttonDone_FDR.Click += new System.EventHandler(this.buttonDone_FDR_Click);
            // 
            // buttonInfo_FDR
            // 
            this.buttonInfo_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_FDR.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_FDR.Image")));
            this.buttonInfo_FDR.Location = new System.Drawing.Point(689, 3);
            this.buttonInfo_FDR.Name = "buttonInfo_FDR";
            this.buttonInfo_FDR.Size = new System.Drawing.Size(94, 81);
            this.buttonInfo_FDR.TabIndex = 2;
            this.toolTip_FDR.SetToolTip(this.buttonInfo_FDR, "Сведение о приложении");
            this.buttonInfo_FDR.UseVisualStyleBackColor = true;
            this.buttonInfo_FDR.Click += new System.EventHandler(this.buttonInfo_FDR_Click);
            // 
            // groupBoxTask_FDR
            // 
            this.groupBoxTask_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_FDR.Controls.Add(this.textBoxTask_FDR);
            this.groupBoxTask_FDR.Location = new System.Drawing.Point(12, 85);
            this.groupBoxTask_FDR.Name = "groupBoxTask_FDR";
            this.groupBoxTask_FDR.Size = new System.Drawing.Size(776, 100);
            this.groupBoxTask_FDR.TabIndex = 3;
            this.groupBoxTask_FDR.TabStop = false;
            this.groupBoxTask_FDR.Text = "Условие:";
            // 
            // textBoxTask_FDR
            // 
            this.textBoxTask_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_FDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxTask_FDR.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_FDR.Multiline = true;
            this.textBoxTask_FDR.Name = "textBoxTask_FDR";
            this.textBoxTask_FDR.ReadOnly = true;
            this.textBoxTask_FDR.Size = new System.Drawing.Size(767, 76);
            this.textBoxTask_FDR.TabIndex = 0;
            this.textBoxTask_FDR.Text = resources.GetString("textBoxTask_FDR.Text");
            // 
            // groupBoxInPut_FDR
            // 
            this.groupBoxInPut_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInPut_FDR.Controls.Add(this.textBoxIn_FDR);
            this.groupBoxInPut_FDR.Location = new System.Drawing.Point(15, 191);
            this.groupBoxInPut_FDR.Name = "groupBoxInPut_FDR";
            this.groupBoxInPut_FDR.Size = new System.Drawing.Size(384, 253);
            this.groupBoxInPut_FDR.TabIndex = 1;
            this.groupBoxInPut_FDR.TabStop = false;
            this.groupBoxInPut_FDR.Text = "Ввод:";
            // 
            // groupBoxOutPut_FDR
            // 
            this.groupBoxOutPut_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_FDR.Controls.Add(this.textBoxOut_FDR);
            this.groupBoxOutPut_FDR.Location = new System.Drawing.Point(405, 191);
            this.groupBoxOutPut_FDR.Name = "groupBoxOutPut_FDR";
            this.groupBoxOutPut_FDR.Size = new System.Drawing.Size(384, 253);
            this.groupBoxOutPut_FDR.TabIndex = 2;
            this.groupBoxOutPut_FDR.TabStop = false;
            this.groupBoxOutPut_FDR.Text = "Вывод:";
            // 
            // textBoxIn_FDR
            // 
            this.textBoxIn_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn_FDR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxIn_FDR.Location = new System.Drawing.Point(3, 18);
            this.textBoxIn_FDR.Multiline = true;
            this.textBoxIn_FDR.Name = "textBoxIn_FDR";
            this.textBoxIn_FDR.ReadOnly = true;
            this.textBoxIn_FDR.Size = new System.Drawing.Size(375, 229);
            this.textBoxIn_FDR.TabIndex = 0;
            // 
            // textBoxOut_FDR
            // 
            this.textBoxOut_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_FDR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOut_FDR.Location = new System.Drawing.Point(3, 18);
            this.textBoxOut_FDR.Multiline = true;
            this.textBoxOut_FDR.Name = "textBoxOut_FDR";
            this.textBoxOut_FDR.ReadOnly = true;
            this.textBoxOut_FDR.Size = new System.Drawing.Size(375, 229);
            this.textBoxOut_FDR.TabIndex = 1;
            // 
            // openFileDialogTask_FDR
            // 
            this.openFileDialogTask_FDR.FileName = "openFileDialog1";
            // 
            // toolTip_FDR
            // 
            this.toolTip_FDR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_FDR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.groupBoxOutPut_FDR);
            this.Controls.Add(this.groupBoxInPut_FDR);
            this.Controls.Add(this.groupBoxTask_FDR);
            this.Controls.Add(this.buttonInfo_FDR);
            this.Controls.Add(this.buttonDone_FDR);
            this.Controls.Add(this.buttonOpenFile_FDR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 24 | Файзуллин Д. Р.";
            this.groupBoxTask_FDR.ResumeLayout(false);
            this.groupBoxTask_FDR.PerformLayout();
            this.groupBoxInPut_FDR.ResumeLayout(false);
            this.groupBoxInPut_FDR.PerformLayout();
            this.groupBoxOutPut_FDR.ResumeLayout(false);
            this.groupBoxOutPut_FDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_FDR;
        private System.Windows.Forms.Button buttonDone_FDR;
        private System.Windows.Forms.Button buttonInfo_FDR;
        private System.Windows.Forms.GroupBox groupBoxTask_FDR;
        private System.Windows.Forms.TextBox textBoxTask_FDR;
        private System.Windows.Forms.GroupBox groupBoxInPut_FDR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_FDR;
        private System.Windows.Forms.TextBox textBoxIn_FDR;
        private System.Windows.Forms.TextBox textBoxOut_FDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_FDR;
        private System.Windows.Forms.ToolTip toolTip_FDR;
    }
}

