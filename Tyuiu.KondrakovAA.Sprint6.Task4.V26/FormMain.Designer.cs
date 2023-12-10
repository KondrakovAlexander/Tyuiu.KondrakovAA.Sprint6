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
using Tyuiu.KondrakovAA.Sprint6.Task4.V26.Lib;

namespace Tyuiu.KondrakovAA.Sprint6.Task4.V26
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

                this.chartResult_KAA.Titles.Add("График функции");
                this.chartResult_KAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    textBoxResult_KAA.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartResult_KAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
                


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveListener(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_KAA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно. Открыть в блокноте? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка");
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
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelConditioooon_KAA = new System.Windows.Forms.Label();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.textBoxStop_KAA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.labelStop_KAA = new System.Windows.Forms.Label();
            this.labelStart_KAA = new System.Windows.Forms.Label();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.chartResult_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.labelConditioooon_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.textBoxStop_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.labelStop_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.labelStart_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.buttonSave_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.buttonEnter_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.buttonAbout_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(4, 3);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(793, 149);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // labelConditioooon_KAA
            // 
            this.labelConditioooon_KAA.AutoSize = true;
            this.labelConditioooon_KAA.Location = new System.Drawing.Point(8, 33);
            this.labelConditioooon_KAA.Name = "labelConditioooon_KAA";
            this.labelConditioooon_KAA.Size = new System.Drawing.Size(429, 78);
            this.labelConditioooon_KAA.TabIndex = 9;
            this.labelConditioooon_KAA.Text = resources.GetString("labelConditioooon_KAA.Text");
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(354, 13);
            this.labelCondition_KAA.TabIndex = 8;
            this.labelCondition_KAA.Text = "Произвести табулирование функции F(x) = 5 - 3x + (1 + sin(x))/ (2x-0.5)";
            // 
            // textBoxStop_KAA
            // 
            this.textBoxStop_KAA.Location = new System.Drawing.Point(456, 95);
            this.textBoxStop_KAA.Name = "textBoxStop_KAA";
            this.textBoxStop_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_KAA.TabIndex = 7;
            this.textBoxStop_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(456, 37);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KAA.TabIndex = 6;
            this.textBoxStart_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // labelStop_KAA
            // 
            this.labelStop_KAA.AutoSize = true;
            this.labelStop_KAA.Location = new System.Drawing.Point(453, 78);
            this.labelStop_KAA.Name = "labelStop_KAA";
            this.labelStop_KAA.Size = new System.Drawing.Size(82, 13);
            this.labelStop_KAA.TabIndex = 5;
            this.labelStop_KAA.Text = "Конец отрезка";
            // 
            // labelStart_KAA
            // 
            this.labelStart_KAA.AutoSize = true;
            this.labelStart_KAA.Location = new System.Drawing.Point(453, 20);
            this.labelStart_KAA.Name = "labelStart_KAA";
            this.labelStart_KAA.Size = new System.Drawing.Size(88, 13);
            this.labelStart_KAA.TabIndex = 4;
            this.labelStart_KAA.Text = "Начало отрезка";
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.Location = new System.Drawing.Point(604, 108);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(131, 35);
            this.buttonSave_KAA.TabIndex = 2;
            this.buttonSave_KAA.Text = "Сохранить";
            this.buttonSave_KAA.UseVisualStyleBackColor = true;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSaveListener);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(604, 60);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(131, 42);
            this.buttonEnter_KAA.TabIndex = 1;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonDoneListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(604, 20);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(131, 34);
            this.buttonAbout_KAA.TabIndex = 0;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.AboutButtonListener);
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.chartResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(4, 159);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(793, 287);
            this.groupBoxResult_KAA.TabIndex = 1;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Результат";
            // 
            // chartResult_KAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_KAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult_KAA.Legends.Add(legend1);
            this.chartResult_KAA.Location = new System.Drawing.Point(272, 20);
            this.chartResult_KAA.Name = "chartResult_KAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_KAA.Series.Add(series1);
            this.chartResult_KAA.Size = new System.Drawing.Size(512, 259);
            this.chartResult_KAA.TabIndex = 1;
            this.chartResult_KAA.Text = "chart1";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(9, 20);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(256, 259);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "| Спринт 6 | Таск 4  | Вариант 26 | Кондраков А.А. | СМАРТб-23-1 |";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KAA;
        private System.Windows.Forms.TextBox textBoxStop_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.Label labelStop_KAA;
        private System.Windows.Forms.Label labelStart_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Label labelConditioooon_KAA;
        private System.Windows.Forms.Label labelCondition_KAA;
    }
}

