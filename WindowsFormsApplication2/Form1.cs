using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            killPr();
           TopMost = true;
            Screen currentScreen = Screen.FromRectangle(Bounds);
            this.WindowState = FormWindowState.Maximized;


            InitializeComponent();
            // int vid = 0;
            
            using (TextReader fstream = File.OpenText(@"C:\MNTR\WindowsFormsApplication2\instruments.txt"))
            {
                int x = int.Parse(fstream.ReadLine());
                if (x != 2)
                {
                    обучение обучение = new обучение();
                     обучение.ShowDialog();
                }
            }

        }


        
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutform = new about();
            aboutform.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            System.Data.DataTable dt = new System.Data.DataTable();
            workbook = app.Workbooks.Open(FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
            ShtRange = NwSheet.UsedRange;
            // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(
             new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            dt.AcceptChanges();
            // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dr[Cnum - 1] =
               (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
                app.AlertBeforeOverwriting = false;
            }
            //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
            dataGridGIsxh.DataSource = dt;
          
            app.Quit();
            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = comboBox1.SelectedIndex;
            if (a != -1)
            {


                this.Cursor = Cursors.AppStarting;
                string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

                ExcelObj.Application app = new ExcelObj.Application();
                ExcelObj.Workbook workbook;
                ExcelObj.Worksheet NwSheet2;
                ExcelObj.Range ShtRange;
                System.Data.DataTable dt = new System.Data.DataTable();

                workbook = app.Workbooks.Open(FileName);
                NwSheet2 = (ExcelObj.Worksheet)workbook.Sheets.get_Item(3 + a);
                ShtRange = NwSheet2.UsedRange;
                // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {

                    dt.Columns.Add(
                 new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                   (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                    app.AlertBeforeOverwriting = false;
                }
                //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
                dataGridGIsxh.DataSource = dt;
                app.Quit();
                this.Cursor = Cursors.Default;

            }
            else
            {
                MessageBox.Show(" Выберите вид скота из перечня");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a = comboBox2.SelectedIndex;
            if (a != -1)
            {

                this.Cursor = Cursors.AppStarting;
                string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

                ExcelObj.Application app = new ExcelObj.Application();
                ExcelObj.Workbook workbook;
                ExcelObj.Worksheet NwSheet2;
                ExcelObj.Range ShtRange;
                System.Data.DataTable dt = new System.Data.DataTable();

                workbook = app.Workbooks.Open(FileName);
                NwSheet2 = (ExcelObj.Worksheet)workbook.Sheets.get_Item(11 + a);
                //какой лист из эксель документа выбирается
                ShtRange = NwSheet2.UsedRange;
                // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(
                 new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                                (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                    app.AlertBeforeOverwriting = false;
                }
                //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
                dataGridGIsxh.DataSource = dt;
                app.Quit();
                this.Cursor = Cursors.Default;

            }
            else
            {
                MessageBox.Show(" Выберите вид скота из перечня");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int a = comboBox3.SelectedIndex;
            if (a != -1)
            {

                this.Cursor = Cursors.AppStarting;
                string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

                ExcelObj.Application app = new ExcelObj.Application();
                ExcelObj.Workbook workbook;
                ExcelObj.Worksheet NwSheet2;
                ExcelObj.Range ShtRange;
                System.Data.DataTable dt = new System.Data.DataTable();

                workbook = app.Workbooks.Open(FileName);
                NwSheet2 = (ExcelObj.Worksheet)workbook.Sheets.get_Item(19 + a);
                ShtRange = NwSheet2.UsedRange;
                // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(
                 new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                   (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                    app.AlertBeforeOverwriting = false;
                }
                //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
                dataGridGIsxh.DataSource = dt;
                app.Quit();
                this.Cursor = Cursors.Default;

            }
            else
            {
                MessageBox.Show(" Выберите вид скота из перечня");
            }
        }

       

        void killPr()
        {// открывается диспетчер задач и удаляются все процессы, где в названии есть "Эксель"
            string name = "excel";
            System.Diagnostics.Process[] etc = System.Diagnostics.Process.GetProcesses();
            try
            {
                foreach (System.Diagnostics.Process anti in etc)
                {
                    if (anti.ProcessName.ToLower().Contains(name.ToLower()))
                        anti.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {// КНОПКА СОХРАНИТЬ
            killPr();
            int a = comboBox1.SelectedIndex;
            SaveTable(dataGridGIsxh, a);
        }
        void SaveTable(DataGridView WhatSave, int a)
        {
            MessageBox.Show(" Изменять можно только значения коэффициентов");
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook = app.Workbooks.Open(FileName); ;
            ExcelObj.Worksheet wSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(3 + a);

            // Яцейка которую можно сохранить - сохранить
            for (int i = 4; i < WhatSave.RowCount + 1; i++)
            {
                for (int j = 2; j < 12; j++)
                {
                    wSheet.Rows[i].Columns[j] = WhatSave.Rows[i - 2].Cells[j - 1].Value;
                }
            }

            // остальные сделать - как в оригинале
            wSheet.Rows[2].Columns[10] = WhatSave.Rows[0].Cells[9].Value;
            wSheet.Rows[2].Columns[11] = WhatSave.Rows[0].Cells[10].Value;
            wSheet.Rows[2].Columns[12] = WhatSave.Rows[0].Cells[11].Value;





            app.AlertBeforeOverwriting = false;
            workbook.SaveAs(FileName);
            app.Quit();

            this.Cursor = Cursors.Default;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            killPr();
            int a = comboBox2.SelectedIndex;
            SaveTable(dataGridGIsxh, a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            killPr();
            int a = comboBox3.SelectedIndex;
            SaveTable(dataGridGIsxh, a);//сохранение листа эксель
        }

       

        void b1rast(int item)
        {
            killPr();
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\RastB1.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            System.Data.DataTable dt = new System.Data.DataTable();
            workbook = app.Workbooks.Open(FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(item);
            ShtRange = NwSheet.UsedRange;
            // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(
             new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dr[Cnum - 1] =
               (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
                app.AlertBeforeOverwriting = false;
            }
            //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
            dataGridGIsxh.DataSource = dt;
            app.Quit();
            this.Cursor = Cursors.Default;
        }

         void butGIV(int a)
        {
            killPr();
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            System.Data.DataTable dt1 = new System.Data.DataTable();
            workbook = app.Workbooks.Open(FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(a);
            ShtRange = NwSheet.UsedRange;
            // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {
                dt1.Columns.Add(
             new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            dt1.AcceptChanges();
            // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt1.NewRow();
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dr[Cnum - 1] =
               (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                    }
                }
                dt1.Rows.Add(dr);
                dt1.AcceptChanges();
                app.AlertBeforeOverwriting = false;
            }
            //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
            dataGridGIsxh.DataSource = dt1;

            app.Quit();
            this.Cursor = Cursors.Default;

            }


         private void button5_Click(object sender, EventArgs e)
         {
             int a = comboBox4.SelectedIndex;
             if (a != -1)
             {
                 a = a + 27;
                 butGIV(a);
             }
             else
             {
                 MessageBox.Show(" Выберите показатель из перечня");
             }
         }

         private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
         {
            

         } 
        private void button10_Click(object sender, EventArgs e)
        {  // растениеводство б1
            int a = comboBox5.SelectedIndex;
            if (a != -1)
            {
                a = a + 4;
                b1rast(a);
            }
            else
            {
                MessageBox.Show(" Выберите показатель из перечня");
            }
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            killPr();
            // растениеводство исходные
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\RastB1.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            System.Data.DataTable dt = new System.Data.DataTable();
            workbook = app.Workbooks.Open(FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
            ShtRange = NwSheet.UsedRange;
            // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(
             new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            dt.AcceptChanges();
            // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dr[Cnum - 1] =
               (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
                app.AlertBeforeOverwriting = false;
            }
            //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
            dataGridGIsxh.DataSource = dt;
            app.Quit();
            this.Cursor = Cursors.Default;
        }

        private void button13_Click(object sender, EventArgs e)
        {// растениеводство б2
            int a = comboBox6.SelectedIndex;
            if (a != -1)
            {
                a = a + 14;
                b1rast(a);
            }
            else
            {
                MessageBox.Show(" Выберите показатель из перечня");
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // растениеводство б3
            int a = comboBox7.SelectedIndex;
            if (a != -1)
            {
                a = a + 24;
                b1rast(a);
            }
            else
            {
                MessageBox.Show(" Выберите показатель из перечня");
            }
        }

        private void экспортПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pathToFile = @"C:\MNTR\WindowsFormsApplication2\Data\GivB.xls";


            String s = DateTime.Now.ToString("dd-MM-yyyy");
            string sPath = Convert.ToString(s) + "date";
            string Outpath = Path.Combine(@"C:\MNTR\WindowsFormsApplication2\Output\", sPath);
            Directory.CreateDirectory(Outpath);
            // Скопируем наш файл на локальный диск C
            // true говорит о том, что файл будет перезаписан
            string p = Outpath + @"\GivB.xls";
            File.Copy(pathToFile, p, true);
            p = Outpath + @"\RastB1.xls";
            File.Copy(pathToFile, p, true);
            p = Outpath + @"\RastVG.xls";
            File.Copy(pathToFile, p, true);
            MessageBox.Show("Готово");

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // растениеводство сводная
            int a = comboBox7.SelectedIndex;
            if (a != -1)
            {
                a = a + 34;
                b1rast(a);
            }
            else
            {
                MessageBox.Show(" Выберите показатель из перечня");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {// растениеводство сводная
            this.Cursor = Cursors.AppStarting;
            string FileName = @"C:\MNTR\WindowsFormsApplication2\Data\RastVG.xls";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            System.Data.DataTable dt = new System.Data.DataTable();
            workbook = app.Workbooks.Open(FileName);
            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
            ShtRange = NwSheet.UsedRange;
            // После получения объекта «Range», с помощью цикла «For» загружается первая строка из таблицы и каждое значение устанавливается в качестве имени колонки таблицы.
            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
            {
                dt.Columns.Add(
             new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
            }
            // Далее таким же способом загружаются все оставшиеся строки с добавлением в таблицу.
            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
            {
                DataRow dr = dt.NewRow();
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                    {
                        dr[Cnum - 1] =
               (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(dr);
                dt.AcceptChanges();
            }
            //  По завершении загрузки данных с указанного листа, сформированная таблица «dt» подключается к элементу управления «dataGridView1». Так же открытый объект «Application» или приложение «Excel» закрывается.
            dataGridGIsxh.DataSource = dt;
            app.Quit();
            this.Cursor = Cursors.Default;
        }

        public void exportToExel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridGIsxh.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridGIsxh.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridGIsxh.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

        private void GIVprilG_Click(object sender, EventArgs e)
        {
            int a = 27;
            butGIV(a);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            int a = 29;
            butGIV(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int a = 32;
            butGIV(a);
        }

        
    }
};
