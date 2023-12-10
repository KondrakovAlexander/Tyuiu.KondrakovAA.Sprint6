using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task3.V14.Lib;

namespace Tyuiu.KondrakovAA.Sprint6.Task3.V14
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

        private void buttonEnterListener(object sender, EventArgs e)
        {
            DataService resp = new DataService();
            int[,] matr = new int[5, 5] { { 1, 4, -5, -12, -8 }, { -7, -20, 11, -13, 6 }, { 2, -12, 1, -12, 3 }, { -1, -7, -20, -6, 17 }, { -3, 3, 2, 13, -17 } };
            int[,] result = new int[5, 5];
            result = resp.Calculate(matr);

            dataGridView_KAA.ColumnCount = 5;
            dataGridView_KAA.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                dataGridView_KAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView_KAA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
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
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxResult_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridView_KAA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(850, 425);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxResult_KAA
            // 
            this.groupBoxResult_KAA.Controls.Add(this.dataGridView_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.buttonAbout_KAA);
            this.groupBoxResult_KAA.Controls.Add(this.buttonEnter_KAA);
            this.groupBoxResult_KAA.Location = new System.Drawing.Point(869, 13);
            this.groupBoxResult_KAA.Name = "groupBoxResult_KAA";
            this.groupBoxResult_KAA.Size = new System.Drawing.Size(225, 425);
            this.groupBoxResult_KAA.TabIndex = 1;
            this.groupBoxResult_KAA.TabStop = false;
            this.groupBoxResult_KAA.Text = "Результат";
            // 
            // dataGridView_KAA
            // 
            this.dataGridView_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridView_KAA.Name = "dataGridView_KAA";
            this.dataGridView_KAA.Size = new System.Drawing.Size(212, 348);
            this.dataGridView_KAA.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 25;
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(125, 374);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(94, 43);
            this.buttonAbout_KAA.TabIndex = 1;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.AboutButtonListener);
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(7, 374);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(111, 43);
            this.buttonEnter_KAA.TabIndex = 0;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonEnterListener);
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 444);
            this.Controls.Add(this.groupBoxResult_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "| Спринт 6 | Таск 3 | Варинт 14 | Кондраков А.А. | СМАРТб-23-1 | ";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KAA;
        private System.Windows.Forms.GroupBox groupBoxResult_KAA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

