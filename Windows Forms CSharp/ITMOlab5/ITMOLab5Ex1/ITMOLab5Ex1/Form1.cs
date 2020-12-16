﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace ITMOLab5Ex1
{
    public partial class Form1 : Form
    {
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;

                workbook = app.Workbooks.Open(ofd.FileName);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;

                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum]
                            as ExcelObj.Range).Value2.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Формат файла не поддерживается");
                        app.Quit();
                        this.Close();
                    }
                }

                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];

                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    columnNames[i] = dt.Columns[i].ColumnName;//columnNames[0]
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as
                                ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                dataGridView1.DataSource = dt;
                app.Quit();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия", "Загрузка данных...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
