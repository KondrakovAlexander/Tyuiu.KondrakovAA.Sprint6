
namespace Tyuiu.KondrakovAA.Sprint6.Task7.V30
{
    partial class FormMain_KAA
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KAA));
            this.buttonEnter_KAA = new System.Windows.Forms.Button();
            this.buttonLoad_KAA = new System.Windows.Forms.Button();
            this.buttonAbout_KAA = new System.Windows.Forms.Button();
            this.groupBoxEnter_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_KAA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_KAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_KAA = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_KAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_KAA = new System.Windows.Forms.Label();
            this.buttonSave_KAA = new System.Windows.Forms.Button();
            this.openFileDialog_KAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_KAA = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_KAA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxEnter_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_KAA)).BeginInit();
            this.groupBoxOutput_KAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_KAA)).BeginInit();
            this.groupBoxCondition_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEnter_KAA
            // 
            this.buttonEnter_KAA.Enabled = false;
            this.buttonEnter_KAA.Location = new System.Drawing.Point(12, 12);
            this.buttonEnter_KAA.Name = "buttonEnter_KAA";
            this.buttonEnter_KAA.Size = new System.Drawing.Size(75, 41);
            this.buttonEnter_KAA.TabIndex = 0;
            this.buttonEnter_KAA.Text = "Выполнить";
            this.toolTip_KAA.SetToolTip(this.buttonEnter_KAA, "Для обработки необходимо загрузить файл\r\n");
            this.buttonEnter_KAA.UseVisualStyleBackColor = true;
            this.buttonEnter_KAA.Click += new System.EventHandler(this.buttonEnterListener);
            // 
            // buttonLoad_KAA
            // 
            this.buttonLoad_KAA.Location = new System.Drawing.Point(93, 12);
            this.buttonLoad_KAA.Name = "buttonLoad_KAA";
            this.buttonLoad_KAA.Size = new System.Drawing.Size(75, 41);
            this.buttonLoad_KAA.TabIndex = 1;
            this.buttonLoad_KAA.Text = "Загрузить файл";
            this.buttonLoad_KAA.UseVisualStyleBackColor = true;
            this.buttonLoad_KAA.Click += new System.EventHandler(this.buttonReadFileListener);
            // 
            // buttonAbout_KAA
            // 
            this.buttonAbout_KAA.Location = new System.Drawing.Point(736, 27);
            this.buttonAbout_KAA.Name = "buttonAbout_KAA";
            this.buttonAbout_KAA.Size = new System.Drawing.Size(52, 26);
            this.buttonAbout_KAA.TabIndex = 2;
            this.buttonAbout_KAA.Text = "?";
            this.buttonAbout_KAA.UseVisualStyleBackColor = true;
            this.buttonAbout_KAA.Click += new System.EventHandler(this.buttonHelpListener);
            // 
            // groupBoxEnter_KAA
            // 
            this.groupBoxEnter_KAA.Controls.Add(this.dataGridViewInput_KAA);
            this.groupBoxEnter_KAA.Location = new System.Drawing.Point(13, 165);
            this.groupBoxEnter_KAA.Name = "groupBoxEnter_KAA";
            this.groupBoxEnter_KAA.Size = new System.Drawing.Size(355, 273);
            this.groupBoxEnter_KAA.TabIndex = 3;
            this.groupBoxEnter_KAA.TabStop = false;
            this.groupBoxEnter_KAA.Text = "Ввод";
            // 
            // dataGridViewInput_KAA
            // 
            this.dataGridViewInput_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewInput_KAA.Name = "dataGridViewInput_KAA";
            this.dataGridViewInput_KAA.Size = new System.Drawing.Size(342, 247);
            this.dataGridViewInput_KAA.TabIndex = 0;
            // 
            // groupBoxOutput_KAA
            // 
            this.groupBoxOutput_KAA.Controls.Add(this.dataGridViewOutput_KAA);
            this.groupBoxOutput_KAA.Location = new System.Drawing.Point(375, 165);
            this.groupBoxOutput_KAA.Name = "groupBoxOutput_KAA";
            this.groupBoxOutput_KAA.Size = new System.Drawing.Size(413, 273);
            this.groupBoxOutput_KAA.TabIndex = 4;
            this.groupBoxOutput_KAA.TabStop = false;
            this.groupBoxOutput_KAA.Text = "Вывод";
            // 
            // dataGridViewOutput_KAA
            // 
            this.dataGridViewOutput_KAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_KAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOutput_KAA.Name = "dataGridViewOutput_KAA";
            this.dataGridViewOutput_KAA.Size = new System.Drawing.Size(400, 247);
            this.dataGridViewOutput_KAA.TabIndex = 0;
            // 
            // groupBoxCondition_KAA
            // 
            this.groupBoxCondition_KAA.Controls.Add(this.labelCondition_KAA);
            this.groupBoxCondition_KAA.Location = new System.Drawing.Point(12, 59);
            this.groupBoxCondition_KAA.Name = "groupBoxCondition_KAA";
            this.groupBoxCondition_KAA.Size = new System.Drawing.Size(776, 100);
            this.groupBoxCondition_KAA.TabIndex = 5;
            this.groupBoxCondition_KAA.TabStop = false;
            this.groupBoxCondition_KAA.Text = "Условие";
            // 
            // labelCondition_KAA
            // 
            this.labelCondition_KAA.AutoSize = true;
            this.labelCondition_KAA.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_KAA.Name = "labelCondition_KAA";
            this.labelCondition_KAA.Size = new System.Drawing.Size(532, 52);
            this.labelCondition_KAA.TabIndex = 0;
            this.labelCondition_KAA.Text = resources.GetString("labelCondition_KAA.Text");
            // 
            // buttonSave_KAA
            // 
            this.buttonSave_KAA.Enabled = false;
            this.buttonSave_KAA.Location = new System.Drawing.Point(175, 12);
            this.buttonSave_KAA.Name = "buttonSave_KAA";
            this.buttonSave_KAA.Size = new System.Drawing.Size(76, 41);
            this.buttonSave_KAA.TabIndex = 6;
            this.buttonSave_KAA.Text = "Сохранить";
            this.toolTip_KAA.SetToolTip(this.buttonSave_KAA, "Сохранение доступно только после обработки файла программой");
            this.buttonSave_KAA.UseVisualStyleBackColor = true;
            this.buttonSave_KAA.Click += new System.EventHandler(this.buttonSaveListener);
            // 
            // toolTip_KAA
            // 
            this.toolTip_KAA.ShowAlways = true;
            // 
            // FormMain_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave_KAA);
            this.Controls.Add(this.groupBoxCondition_KAA);
            this.Controls.Add(this.groupBoxOutput_KAA);
            this.Controls.Add(this.groupBoxEnter_KAA);
            this.Controls.Add(this.buttonAbout_KAA);
            this.Controls.Add(this.buttonLoad_KAA);
            this.Controls.Add(this.buttonEnter_KAA);
            this.Name = "FormMain_KAA";
            this.Text = "| Спринт 6 | Таск 7 | Вариант 30 | Кондраков А.А. | СМАРТб23-1 |";
            this.groupBoxEnter_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_KAA)).EndInit();
            this.groupBoxOutput_KAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_KAA)).EndInit();
            this.groupBoxCondition_KAA.ResumeLayout(false);
            this.groupBoxCondition_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter_KAA;
        private System.Windows.Forms.Button buttonLoad_KAA;
        private System.Windows.Forms.Button buttonAbout_KAA;
        private System.Windows.Forms.GroupBox groupBoxEnter_KAA;
        private System.Windows.Forms.DataGridView dataGridViewInput_KAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_KAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_KAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_KAA;
        private System.Windows.Forms.Label labelCondition_KAA;
        private System.Windows.Forms.Button buttonSave_KAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_KAA;
        private System.Windows.Forms.ToolTip toolTip_KAA;
    }
}

