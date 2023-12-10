using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KondrakovAA.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.KondrakovAA.Sprint6.Task7.V30
{
    public partial class FormMain_KAA : Form
    {
        public FormMain_KAA()
        {
            InitializeComponent();

            openFileDialog_KAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_KAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService resp = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for(int r = 0; r < rows; r++)
            {
                string[] line_ = lines[r].Split(';');
                for(int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_[c]);
                }
            }
            return arrayValues;
        }
        private void buttonHelpListener(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonReadFileListener(object sender, EventArgs e)
        {
            openFileDialog_KAA.ShowDialog();
            openFilePath = openFileDialog_KAA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);


            dataGridViewInput_KAA.ColumnCount = columns;
            dataGridViewInput_KAA.RowCount = rows;
            dataGridViewOutput_KAA.ColumnCount = columns;
            dataGridViewOutput_KAA.RowCount = rows;

            for(int i = 0; i < columns; i++)
            {
                dataGridViewInput_KAA.Columns[i].Width = 25;
                dataGridViewOutput_KAA.Columns[i].Width = 25;
            }

            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < columns; c++)
                {
                    dataGridViewInput_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = resp.GetMatrix(LoadFromFileData(openFilePath));
            buttonEnter_KAA.Enabled = true;
        }

        private void buttonEnterListener(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = resp.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for(int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_KAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KAA.Enabled = true;
        }

        private void buttonSaveListener(object sender, EventArgs e)
        {
            saveFileDialog_KAA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_KAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KAA.ShowDialog();

            string path = saveFileDialog_KAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_KAA.RowCount;
            int columns = dataGridViewOutput_KAA.ColumnCount;

            string str = "";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(j != columns - 1)
                    {
                        str = str + dataGridViewOutput_KAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_KAA.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }
    }
}
