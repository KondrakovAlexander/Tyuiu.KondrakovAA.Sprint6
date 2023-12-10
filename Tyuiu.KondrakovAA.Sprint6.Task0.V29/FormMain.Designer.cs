using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task0.V29.Lib;


namespace Tyuiu.KondrakovAA.Sprint6.Task0.V29
{
    public partial class FormMain : Form
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

        private void buttonDoneListener(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_KAA.Text)));
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK);
            }
        }
        private void textBoxListener(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxResultListener(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void aboutButtonListener(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил учащийся группы СМАРТб-23-1, Кондраков Александр", "///", MessageBoxButtons.OK);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.imageCondition_KAA = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_KAA = new System.Windows.Forms.GroupBox();
            this.labelX_KAA = new System.Windows.Forms.Label();
            this.textBoxInput_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_KAA = new System.Windows.Forms.GroupBox();
            this.labelResult_KAA = new System.Windows.Forms.Label();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCondition_KAA)).BeginInit();
            this.groupBoxInput_KAA.SuspendLayout();
            this.groupBoxOutput_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Controls.Add(this.imageCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(706, 290);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(6, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(186, 13);
            this.labelCondition_KAA.TabIndex = 1;
            this.labelCondition_KAA.Text = "Вычислить выражение по формуле";
            // 
            // imageCondition_KAA
            // 
            this.imageCondition_KAA.Image = ((System.Drawing.Image)(resources.GetObject("imageCondition_KAA.Image")));
            this.imageCondition_KAA.ImageLocation = "";
            this.imageCondition_KAA.Location = new System.Drawing.Point(575, 20);
            this.imageCondition_KAA.Name = "imageCondition_KAA";
            this.imageCondition_KAA.Size = new System.Drawing.Size(119, 87);
            this.imageCondition_KAA.TabIndex = 0;
            this.imageCondition_KAA.TabStop = false;
            // 
            // groupBoxInput_KAA
            // 
            this.groupBoxInput_KAA.Controls.Add(this.labelX_KAA);
            this.groupBoxInput_KAA.Controls.Add(this.textBoxInput_KAA);
            this.groupBoxInput_KAA.Location = new System.Drawing.Point(13, 309);
            this.groupBoxInput_KAA.Name = "groupBoxInput_KAA";
            this.groupBoxInput_KAA.Size = new System.Drawing.Size(492, 95);
            this.groupBoxInput_KAA.TabIndex = 1;
            this.groupBoxInput_KAA.TabStop = false;
            this.groupBoxInput_KAA.Text = "Ввод данных";
            // 
            // labelX_KAA
            // 
            this.labelX_KAA.AutoSize = true;
            this.labelX_KAA.Location = new System.Drawing.Point(8, 38);
            this.labelX_KAA.Name = "labelX_KAA";
            this.labelX_KAA.Size = new System.Drawing.Size(81, 13);
            this.labelX_KAA.TabIndex = 4;
            this.labelX_KAA.Text = "Переменная X";
            // 
            // textBoxInput_KAA
            // 
            this.textBoxInput_KAA.Location = new System.Drawing.Point(11, 54);
            this.textBoxInput_KAA.Name = "textBoxInput_KAA";
            this.textBoxInput_KAA.Size = new System.Drawing.Size(129, 20);
            this.textBoxInput_KAA.TabIndex = 1;
            this.textBoxInput_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxListener);
            // 
            // groupBoxOutput_KAA
            // 
            this.groupBoxOutput_KAA.Controls.Add(this.labelResult_KAA);
            this.groupBoxOutput_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxOutput_KAA.Location = new System.Drawing.Point(512, 309);
            this.groupBoxOutput_KAA.Name = "groupBoxOutput_KAA";
            this.groupBoxOutput_KAA.Size = new System.Drawing.Size(200, 52);
            this.groupBoxOutput_KAA.TabIndex = 2;
            this.groupBoxOutput_KAA.TabStop = false;
            this.groupBoxOutput_KAA.Text = "Вывод данных";
            // 
            // labelResult_KAA
            // 
            this.labelResult_KAA.AutoSize = true;
            this.labelResult_KAA.Location = new System.Drawing.Point(7, 25);
            this.labelResult_KAA.Name = "labelResult_KAA";
            this.labelResult_KAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KAA.TabIndex = 1;
            this.labelResult_KAA.Text = "Результат:";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Location = new System.Drawing.Point(100, 22);
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.Size = new System.Drawing.Size(94, 20);
            this.textBoxResult_KAA.TabIndex = 0;
            this.textBoxResult_KAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResultListener);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(565, 368);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(147, 36);
            this.buttonEnter_KAA.TabIndex = 3;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonDoneListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(512, 368);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(47, 36);
            this.buttonAbout_KAA.TabIndex = 4;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.aboutButtonListener);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 416);
            this.Controls.Add(this.buttonAbout_KAA);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Controls.Add(this.groupBoxOutput_KAA);
            this.Controls.Add(this.groupBoxInput_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 29 | Кондраков А.А.";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCondition_KAA)).EndInit();
            this.groupBoxInput_KAA.ResumeLayout(false);
            this.groupBoxInput_KAA.PerformLayout();
            this.groupBoxOutput_KAA.ResumeLayout(false);
            this.groupBoxOutput_KAA.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.GroupBox groupBoxCondition_KAA ;
        private System.Windows.Forms.Label labelCondition_KAA;
        private System.Windows.Forms.PictureBox imageCondition_KAA;
        private System.Windows.Forms.GroupBox groupBoxInput_KAA;
        private System.Windows.Forms.TextBox textBoxInput_KAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KAA;
        private System.Windows.Forms.TextBox textBoxResult_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.Label labelX_KAA;
        private System.Windows.Forms.Label labelResult_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
    }
}

