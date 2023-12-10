using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task2.V20.Lib;




namespace Tyuiu.KondrakovAA.Sprint6.Task2.V20
{
    partial class FormMain_KAA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        private void TextBoxListener(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonDoneListener(object sender, EventArgs e)
        {
            DataService resp = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KAA.Text);

                int len = resp.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = resp.GetMassFunction(startStep, stopStep);

                this.chartFunction_KAA.Titles.Add("График функции");
                this.chartFunction_KAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_KAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KAA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewResult_KAA = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.pictureBoxCondition_KAA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KAA = new System.Windows.Forms.TextBox();
            this.labelStop_KAA = new System.Windows.Forms.Label();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.labelStart_KAA = new System.Windows.Forms.Label();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.chartFunction_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).BeginInit();
            this.groupBoxCondition_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).BeginInit();
            this.groupBoxData_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResult_KAA
            // 
            this.dataGridViewResult_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResult_KAA.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewResult_KAA.Name = "dataGridViewResult_KAA";
            this.dataGridViewResult_KAA.Size = new System.Drawing.Size(192, 399);
            this.dataGridViewResult_KAA.TabIndex = 0;
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.pictureBoxCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(529, 309);
            this.groupBoxCondition_KAA.TabIndex = 1;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(344, 13);
            this.labelCondition_KAA.TabIndex = 1;
            this.labelCondition_KAA.Text = "Написать программу которая выводит таблицу значений функции";
            // 
            // pictureBoxCondition_KAA
            // 
            this.pictureBoxCondition_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_KAA.Image")));
            this.pictureBoxCondition_KAA.Location = new System.Drawing.Point(10, 45);
            this.pictureBoxCondition_KAA.Name = "pictureBoxCondition_KAA";
            this.pictureBoxCondition_KAA.Size = new System.Drawing.Size(341, 51);
            this.pictureBoxCondition_KAA.TabIndex = 0;
            this.pictureBoxCondition_KAA.TabStop = false;
            // 
            // groupBoxData_KAA
            // 
            this.groupBoxData_KAA.Controls.Add(this.textBoxStop_KAA);
            this.groupBoxData_KAA.Controls.Add(this.labelStop_KAA);
            this.groupBoxData_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxData_KAA.Controls.Add(this.labelStart_KAA);
            this.groupBoxData_KAA.Location = new System.Drawing.Point(13, 329);
            this.groupBoxData_KAA.Name = "groupBoxData_KAA";
            this.groupBoxData_KAA.Size = new System.Drawing.Size(413, 109);
            this.groupBoxData_KAA.TabIndex = 2;
            this.groupBoxData_KAA.TabStop = false;
            this.groupBoxData_KAA.Text = "Переменные";
            // 
            // textBoxStop_KAA
            // 
            this.textBoxStop_KAA.Location = new System.Drawing.Point(131, 48);
            this.textBoxStop_KAA.Name = "textBoxStop_KAA";
            this.textBoxStop_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_KAA.TabIndex = 4;
            this.textBoxStop_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // labelStop_KAA
            // 
            this.labelStop_KAA.AutoSize = true;
            this.labelStop_KAA.Location = new System.Drawing.Point(128, 31);
            this.labelStop_KAA.Name = "labelStop_KAA";
            this.labelStop_KAA.Size = new System.Drawing.Size(82, 13);
            this.labelStop_KAA.TabIndex = 3;
            this.labelStop_KAA.Text = "Конец отрезка";
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(10, 48);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KAA.TabIndex = 2;
            this.textBoxStart_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // labelStart_KAA
            // 
            this.labelStart_KAA.AutoSize = true;
            this.labelStart_KAA.Location = new System.Drawing.Point(10, 31);
            this.labelStart_KAA.Name = "labelStart_KAA";
            this.labelStart_KAA.Size = new System.Drawing.Size(88, 13);
            this.labelStart_KAA.TabIndex = 0;
            this.labelStart_KAA.Text = "Начало отрезка";
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(433, 394);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(109, 43);
            this.buttonEnter_KAA.TabIndex = 3;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonDoneListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(433, 329);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(109, 45);
            this.buttonAbout_KAA.TabIndex = 4;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.AboutButtonListener);
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.chartFunction_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.dataGridViewResult_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(558, 13);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(943, 425);
            this.groupBoxResult_KAA.TabIndex = 5;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Результат";
            // 
            // chartFunction_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KAA.Legends.Add(legend1);
            this.chartFunction_KAA.Location = new System.Drawing.Point(204, 20);
            this.chartFunction_KAA.Name = "chartFunction_KAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KAA.Series.Add(series1);
            this.chartFunction_KAA.Size = new System.Drawing.Size(733, 399);
            this.chartFunction_KAA.TabIndex = 1;
            this.chartFunction_KAA.Text = "chartFunction_KAA";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Width = 75;
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 445);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.buttonAbout_KAA);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Controls.Add(this.groupBoxData_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "Спринт 6 | Таск 2 | Кондраков А.А. | СМАРТб-23-1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAA)).EndInit();
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).EndInit();
            this.groupBoxData_KAA.ResumeLayout(false);
            this.groupBoxData_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResult_KAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_KAA;
        private System.Windows.Forms.Label labelCondition_KAA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_KAA;
        private System.Windows.Forms.GroupBox groupBoxData_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.Label labelStart_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private TextBox textBoxStop_KAA;
        private Label labelStop_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KAA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}

