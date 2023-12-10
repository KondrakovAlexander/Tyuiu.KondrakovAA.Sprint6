using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task1.V9.Lib;



namespace Tyuiu.KondrakovAA.Sprint6.Task1.V9
{
    partial class FormMain
    {
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
        private void TextBoxResultListener(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TextBoxListener(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58 ) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void DoneButtonListener(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int start = Convert.ToInt32(textBoxStart_KAA.Text);
                int stop = Convert.ToInt32(textBoxStop_KAA.Text);
                textBoxResult_KAA.Text = Convert.ToString(ds.GetMassFunction(start, stop));
                int len = ds.GetMassFunction(start, stop).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(start, stop);
                textBoxResult_KAA.Text = "";
                textBoxResult_KAA.AppendText("+-------------------------+" + Environment.NewLine);
                textBoxResult_KAA.AppendText("|    x     |     f(x)     |" + Environment.NewLine);
                textBoxResult_KAA.AppendText("+-------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", start, func[i]);
                    textBoxResult_KAA.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBoxResult_KAA.AppendText("+-------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.pictureBoxCondition_KAA = new System.Windows.Forms.PictureBox();
            this.groupBoxData_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KAA = new System.Windows.Forms.TextBox();
            this.labelStop_KAA = new System.Windows.Forms.Label();
            this.textBoxStart_KAA = new System.Windows.Forms.TextBox();
            this.labelStart_KAA = new System.Windows.Forms.Label();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.labelResult_KAA = new System.Windows.Forms.Label();
            this.groupBoxCondition_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).BeginInit();
            this.groupBoxData_KAA.SuspendLayout();
            this.groupBoxResult_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.pictureBoxCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(373, 319);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            this.groupBoxCondition_KAA.Enter += new System.EventHandler(this.groupBoxCondition_KAA_Enter);
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(347, 13);
            this.labelCondition_KAA.TabIndex = 1;
            this.labelCondition_KAA.Text = "Написать программу, которая выводит таблицу значений функции";
            // 
            // pictureBoxCondition_KAA
            // 
            this.pictureBoxCondition_KAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition_KAA.Image")));
            this.pictureBoxCondition_KAA.Location = new System.Drawing.Point(6, 39);
            this.pictureBoxCondition_KAA.Name = "pictureBoxCondition_KAA";
            this.pictureBoxCondition_KAA.Size = new System.Drawing.Size(344, 109);
            this.pictureBoxCondition_KAA.TabIndex = 0;
            this.pictureBoxCondition_KAA.TabStop = false;
            // 
            // groupBoxData_KAA
            // 
            this.groupBoxData_KAA.Controls.Add(this.textBoxStop_KAA);
            this.groupBoxData_KAA.Controls.Add(this.labelStop_KAA);
            this.groupBoxData_KAA.Controls.Add(this.textBoxStart_KAA);
            this.groupBoxData_KAA.Controls.Add(this.labelStart_KAA);
            this.groupBoxData_KAA.Location = new System.Drawing.Point(13, 338);
            this.groupBoxData_KAA.Name = "groupBoxData_KAA";
            this.groupBoxData_KAA.Size = new System.Drawing.Size(242, 100);
            this.groupBoxData_KAA.TabIndex = 1;
            this.groupBoxData_KAA.TabStop = false;
            this.groupBoxData_KAA.Text = "Переменные";
            // 
            // textBoxStop_KAA
            // 
            this.textBoxStop_KAA.Location = new System.Drawing.Point(125, 61);
            this.textBoxStop_KAA.Name = "textBoxStop_KAA";
            this.textBoxStop_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_KAA.TabIndex = 3;
            this.textBoxStop_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // labelStop_KAA
            // 
            this.labelStop_KAA.AutoSize = true;
            this.labelStop_KAA.Location = new System.Drawing.Point(122, 44);
            this.labelStop_KAA.Name = "labelStop_KAA";
            this.labelStop_KAA.Size = new System.Drawing.Size(82, 13);
            this.labelStop_KAA.TabIndex = 2;
            this.labelStop_KAA.Text = "Конец отрезка";
            // 
            // textBoxStart_KAA
            // 
            this.textBoxStart_KAA.Location = new System.Drawing.Point(19, 61);
            this.textBoxStart_KAA.Name = "textBoxStart_KAA";
            this.textBoxStart_KAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_KAA.TabIndex = 1;
            this.textBoxStart_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxListener);
            // 
            // labelStart_KAA
            // 
            this.labelStart_KAA.AutoSize = true;
            this.labelStart_KAA.Location = new System.Drawing.Point(16, 45);
            this.labelStart_KAA.Name = "labelStart_KAA";
            this.labelStart_KAA.Size = new System.Drawing.Size(88, 13);
            this.labelStart_KAA.TabIndex = 0;
            this.labelStart_KAA.Text = "Начало отрезка";
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(261, 347);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(125, 36);
            this.buttonAbout_KAA.TabIndex = 0;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.AboutButtonListener);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(261, 389);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(125, 44);
            this.buttonEnter_KAA.TabIndex = 1;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.DoneButtonListener);
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.labelResult_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(393, 14);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(395, 425);
            this.groupBoxResult_KAA.TabIndex = 2;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Вывод данных";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(10, 37);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.Size = new System.Drawing.Size(379, 382);
            this.textBoxResult_KAA.TabIndex = 1;
            this.textBoxResult_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxResultListener);
            // 
            // labelResult_KAA
            // 
            this.labelResult_KAA.AutoSize = true;
            this.labelResult_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelResult_KAA.Name = "labelResult_KAA";
            this.labelResult_KAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KAA.TabIndex = 0;
            this.labelResult_KAA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.buttonAbout_KAA);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Controls.Add(this.groupBoxData_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 9 | Кондракаов А.А.";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_KAA)).EndInit();
            this.groupBoxData_KAA.ResumeLayout(false);
            this.groupBoxData_KAA.PerformLayout();
            this.groupBoxResult_KAA.ResumeLayout(false);
            this.groupBoxResult_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KAA;
        private System.Windows.Forms.Label labelCondition_KAA;
        private System.Windows.Forms.PictureBox pictureBoxCondition_KAA;
        private System.Windows.Forms.GroupBox groupBoxData_KAA;
        private System.Windows.Forms.TextBox textBoxStop_KAA;
        private System.Windows.Forms.Label labelStop_KAA;
        private System.Windows.Forms.TextBox textBoxStart_KAA;
        private System.Windows.Forms.Label labelStart_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Label labelResult_KAA;
    }
}

