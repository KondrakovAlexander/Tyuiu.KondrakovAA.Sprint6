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
using Tyuiu.KondrakovAA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.KondrakovAA.Sprint6.Task6.V19
{
    partial class FormMain_KAA
    {
        private System.ComponentModel.IContainer components = null;
        string openFilePath;
        DataService result = new DataService();
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void buttonEnterListener(object sender, EventArgs e)
        {
            textBoxResult_KAA.Text = result.CollectTextFromFile("l", openFilePath);
        }
        private void buttonLoadListener(object sender, EventArgs e)
        {
            openFileDialog_KAA.ShowDialog();
            openFilePath = openFileDialog_KAA.FileName;
            textBoxEnter_KAA.Text = File.ReadAllText(openFilePath);
            buttonEnter_KAA.Enabled = true;
        }
        private void buttonAboutListener(object sender, EventArgs e)
        {
            FormAbout_KAA form = new FormAbout_KAA();
            form.ShowDialog();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAA));
            this.openFileDialog_KAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLoad_KAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.groupBoxInput_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxEnter_KAA = new System.Windows.Forms.TextBox();
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.groupBoxOutput_KAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KAA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_KAA.SuspendLayout();
            this.groupBoxInput_KAA.SuspendLayout();
            this.groupBoxOutput_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_KAA
            // 
            this.openFileDialog_KAA.FileName = "openFileDialog1";
            // 
            // toolTip_KAA
            // 
            this.toolTip_KAA.ToolTipTitle = "Подсказка";
            // 
            // buttonLoad_KAA
            // 
            this.buttonLoad_KAA.Location = new System.Drawing.Point(93, 12);
            this.buttonLoad_KAA.Name = "buttonLoad_KAA";
            this.buttonLoad_KAA.Size = new System.Drawing.Size(75, 56);
            this.buttonLoad_KAA.TabIndex = 3;
            this.buttonLoad_KAA.Text = "Загрузить файл";
            this.toolTip_KAA.SetToolTip(this.buttonLoad_KAA, "Загрузить файл");
            this.buttonLoad_KAA.UseVisualStyleBackColor = true;
            this.buttonLoad_KAA.Click += new System.EventHandler(this.buttonLoadListener);
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(12, 74);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(775, 108);
            this.groupBoxCondition_KAA.TabIndex = 0;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(680, 26);
            this.labelCondition_KAA.TabIndex = 0;
            this.labelCondition_KAA.Text = resources.GetString("labelCondition_KAA.Text");
            // 
            // groupBoxInput_KAA
            // 
            this.groupBoxInput_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_KAA.Controls.Add(this.textBoxEnter_KAA);
            this.groupBoxInput_KAA.Location = new System.Drawing.Point(13, 188);
            this.groupBoxInput_KAA.Name = "groupBoxInput_KAA";
            this.groupBoxInput_KAA.Size = new System.Drawing.Size(381, 250);
            this.groupBoxInput_KAA.TabIndex = 1;
            this.groupBoxInput_KAA.TabStop = false;
            this.groupBoxInput_KAA.Text = "Ввод";
            // 
            // textBoxEnter_KAA
            // 
            this.textBoxEnter_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnter_KAA.Location = new System.Drawing.Point(7, 21);
            this.textBoxEnter_KAA.Multiline = true;
            this.textBoxEnter_KAA.Name = "textBoxEnter_KAA";
            this.textBoxEnter_KAA.ReadOnly = true;
            this.textBoxEnter_KAA.Size = new System.Drawing.Size(368, 223);
            this.textBoxEnter_KAA.TabIndex = 0;
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Location = new System.Drawing.Point(12, 12);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(75, 56);
            this.buttonEnter_KAA.TabIndex = 2;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonEnterListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_KAA.Location = new System.Drawing.Point(736, 35);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(51, 33);
            this.buttonAbout_KAA.TabIndex = 4;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.buttonAboutListener);
            // 
            // groupBoxOutput_KAA
            // 
            this.groupBoxOutput_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_KAA.Controls.Add(this.textBoxResult_KAA);
            this.groupBoxOutput_KAA.Location = new System.Drawing.Point(401, 189);
            this.groupBoxOutput_KAA.Name = "groupBoxOutput_KAA";
            this.groupBoxOutput_KAA.Size = new System.Drawing.Size(386, 249);
            this.groupBoxOutput_KAA.TabIndex = 5;
            this.groupBoxOutput_KAA.TabStop = false;
            this.groupBoxOutput_KAA.Text = "Вывод";
            // 
            // textBoxResult_KAA
            // 
            this.textBoxResult_KAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_KAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_KAA.Multiline = true;
            this.textBoxResult_KAA.Name = "textBoxResult_KAA";
            this.textBoxResult_KAA.ReadOnly = true;
            this.textBoxResult_KAA.Size = new System.Drawing.Size(373, 223);
            this.textBoxResult_KAA.TabIndex = 0;
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_KAA);
            this.Controls.Add(this.buttonAbout_KAA);
            this.Controls.Add(this.buttonLoad_KAA);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Controls.Add(this.groupBoxInput_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "| Спринт 6 | Таск 6 | Вариант 19 | Кондраков А.А. | СМАРТб-23-1 |";
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            this.groupBoxInput_KAA.ResumeLayout(false);
            this.groupBoxInput_KAA.PerformLayout();
            this.groupBoxOutput_KAA.ResumeLayout(false);
            this.groupBoxOutput_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog_KAA;
        private ToolTip toolTip_KAA;
        private GroupBox groupBoxCondition_KAA;
        private Label labelCondition_KAA;
        private GroupBox groupBoxInput_KAA;
        private Button buttonEnter_KAA;
        private Button buttonLoad_KAA;
        private Button buttonAbout_KAA;
        private GroupBox groupBoxOutput_KAA;
        private TextBox textBoxEnter_KAA;
        private TextBox textBoxResult_KAA;
    }
}

