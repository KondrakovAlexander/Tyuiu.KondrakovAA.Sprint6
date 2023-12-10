using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task5.V21.Lib;

namespace Tyuiu.KondrakovAA.Sprint6.Task5.V21
{
    partial class FormMain_KAA
    {
        DataService resp = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V21.txt";
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AboutButtonListener(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил учащийся группы СМАРТб-23-1, Кондраков Александр", "///", MessageBoxButtons.OK);
        }
        private void buttonEnterListener(object sender, EventArgs e)
        {
            this.chartResult_KAA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartResult_KAA.ChartAreas[0].AxisY.Title = "Ось Y";
            try
            {
                double[] result = resp.LoadFromDataFile(path);
                dataGridView_KAA.ColumnCount = result.Length;
                for (int i = 0; i < result.Length; i++)
                {
                    dataGridView_KAA.Columns[i].Width = 25;
                }

                for (int i = 0; i < result.Length; i++)
                {
                    dataGridView_KAA.Rows.Add(Convert.ToString(i), Convert.ToString(result[i]));
                    chartResult_KAA.Series[0].Points.AddXY(i, result[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonLoadListener(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();               
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла \n его не существует епта", "Ошибка");
            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.buttonLoad_KAA = new System.Windows.Forms.Button();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.pictureBoxCondition_KAA = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.chartResult_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_KAA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).BeginInit();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.buttonAbout_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.buttonLoad_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.buttonEnter_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.pictureBoxCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(775, 136);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(720, 107);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(49, 23);
            this.buttonAbout_KAA.TabIndex = 3;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.AboutButtonListener);
            // 
            // buttonLoad_KAA
            // 
            this.buttonLoad_KAA.Location = new System.Drawing.Point(615, 92);
            this.buttonLoad_KAA.Name = "buttonLoad_KAA";
            this.buttonLoad_KAA.Size = new System.Drawing.Size(99, 38);
            this.buttonLoad_KAA.TabIndex = 2;
            this.buttonLoad_KAA.Text = "Открыть файл";
            this.buttonLoad_KAA.UseVisualStyleBackColor = true;
            this.buttonLoad_KAA.Click += new System.EventHandler(this.buttonLoadListener);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(615, 50);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(99, 36);
            this.buttonEnter_KAA.TabIndex = 1;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonEnterListener);
            // 
            // pictureBoxCondition_KAA
            // 
            this.pictureBoxCondition_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_KAA.Image")));
            this.pictureBoxCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.pictureBoxCondition_KAA.Name = "pictureBoxCondition_KAA";
            this.pictureBoxCondition_KAA.Size = new System.Drawing.Size(602, 110);
            this.pictureBoxCondition_KAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCondition_KAA.TabIndex = 0;
            this.pictureBoxCondition_KAA.TabStop = false;
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.chartResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.dataGridView_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(13, 156);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(775, 282);
            this.groupBoxResult_KAA.TabIndex = 1;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Результат";
            // 
            // chartResult_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_KAA.ChartAreas.Add(chartArea1);
            this.chartResult_KAA.Location = new System.Drawing.Point(254, 19);
            this.chartResult_KAA.Name = "chartResult_KAA";
            this.chartResult_KAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartResult_KAA.Series.Add(series1);
            this.chartResult_KAA.Size = new System.Drawing.Size(515, 256);
            this.chartResult_KAA.TabIndex = 1;
            this.chartResult_KAA.Text = "chart1";
            // 
            // dataGridView_KAA
            // 
            this.dataGridView_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_KAA.Name = "dataGridView_KAA";
            this.dataGridView_KAA.Size = new System.Drawing.Size(240, 256);
            this.dataGridView_KAA.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "| Спринт 6 | Таск 5 | Вариант 21 | Кондраков А.А. | СМАРТб-23-1 |";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).EndInit();
            this.groupBoxResult_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxCondition_KAA;
        private Button buttonAbout_KAA;
        private Button buttonLoad_KAA;
        private Button buttonEnter_KAA;
        private PictureBox pictureBoxCondition_KAA;
        private GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAA;
        private DataGridView dataGridView_KAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}

