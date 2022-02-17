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

using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proiect_IPLA_Bebereche_Alexandru_Eugen
{
    public partial class MainForm : Form
    {
        List<Employee> employees;
        public MainForm()
        {
            InitializeComponent();
            employees = new List<Employee>();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();

            AddForm addForm = new AddForm(em);

            if(addForm.ShowDialog() == DialogResult.OK)
            {
                employees.Add(addForm.item);
                Display();
            }

        }

        private void Display()
        {
            lvEmp.Items.Clear();


            foreach (Employee item in employees)
            {
                var lvItem = new ListViewItem(item.Name);

                lvItem.SubItems.Add(item.Salary.ToString());
                lvItem.SubItems.Add(item.Position);
                lvItem.SubItems.Add(item.HideDate.ToShortDateString());
                lvItem.SubItems.Add(item.FreeDaysLeft.ToString());

                lvItem.Tag = item;

                lvEmp.Items.Add(lvItem);


            }
        }

        private void generateWordReport(string baseFileName)
        {
            string datafilepath = baseFileName + ".txt";
            string wordfilepath = baseFileName + ".docx";


            var wordApp = new Word.Application() as Word._Application; // deschiderea aplicatiei
            var document = wordApp.Documents.Add();

            // setam a4
            document.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            // 
            var headerRange = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range; // indexii in enumerari incep de la 1

            //headerRange.InlineShapes.AddPicture(siglaFilePath);
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // footer
            var footerRange = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range; // indexii in enumerari incep de la 1
            footerRange.Text = string.Format("tiparit la data de {0}", DateTime.Now.ToString
                ("dd MMMM yyyy"), new CultureInfo("ro-ro"));
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            var docRange = document.Range();
            docRange.Text = "Lista angajati";
            docRange.set_Style("Heading 1");
            docRange.Font.Color = Word.WdColor.wdColorBlack;
            docRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            docRange.InsertParagraphAfter();
            docRange.InsertParagraphAfter();

            docRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            var table = document.Tables.Add(docRange, employees.Count + 1, 5);

            table.Cell(1, 1).Range.Text = "Nume";
            table.Cell(1, 2).Range.Text = "Salariu";
            table.Cell(1, 3).Range.Text = "Pozitie";
            table.Cell(1, 4).Range.Text = "Data angajare";
            table.Cell(1, 5).Range.Text = "Zile libere";

            for (int i = 0; i < employees.Count; i++)
            {
                table.Cell(i + 2, 1).Range.Text = employees[i].Name;
                table.Cell(i + 2, 2).Range.Text = employees[i].Salary.ToString();
                table.Cell(i + 2, 3).Range.Text = employees[i].Position;
                table.Cell(i + 2, 4).Range.Text = employees[i].HideDate.ToShortDateString();
                table.Cell(i + 2, 5).Range.Text = employees[i].FreeDaysLeft.ToString();

                table.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table.Cell(i + 2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table.Cell(i + 2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table.Cell(i + 2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                table.Cell(i + 2, 5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            }

            // stil de tabel
            table.set_Style("Table professional");
            table.Columns.AutoFit();
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);

            document.SaveAs(wordfilepath);
            wordApp.Quit();
            System.Diagnostics.Process.Start(wordfilepath);

        }

        private void saveAsCSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "Save as CSV File";
            dialog.Filter = "CSV File | *.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("Name , Salary, Position, HideDate, FreeDaysLeft");

                    foreach (Employee ei in employees)
                    {
                        writer.WriteLine("{0}, {1}, {2}, {3}, {4}",
                            ei.Name,
                            ei.Salary,
                            ei.Position,
                            ei.HideDate.ToShortDateString(),
                            ei.FreeDaysLeft);
                    }
                }
            }
        }

        private void generateWordReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generateWordReport(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Data\\employees"));
        }

        private void excelFct(string excelTemplate, string excelFilePath)
        {
            var excelApp = new Excel.Application() as Excel._Application;
            var workbook = excelApp.Workbooks.Open(excelTemplate);

            Excel.Worksheet sheetData = workbook.Sheets[2];

            for (int i = 0; i < employees.Count; i++)
            {
                (sheetData.Cells[i + 2, 1] as Excel.Range).Value2 = employees[i].Name;
                (sheetData.Cells[i + 2, 2] as Excel.Range).Value2 = employees[i].Salary;
                (sheetData.Cells[i + 2, 3] as Excel.Range).Value2 = employees[i].Position;
                (sheetData.Cells[i + 2, 4] as Excel.Range).Value2 = employees[i].HideDate.ToShortDateString();
                (sheetData.Cells[i + 2, 5] as Excel.Range).Value2 = employees[i].FreeDaysLeft;
            }

            sheetData.get_Range("D2", "D" + (employees.Count + 1).ToString()).Name = "DateAngajare";
            sheetData.get_Range("B2", "B" + (employees.Count + 1).ToString()).Name = "Salarii";
            sheetData.get_Range("C2", "C" + (employees.Count + 1).ToString()).Name = "Pozitii";
            excelApp.DisplayAlerts = false;

            workbook.Close(SaveChanges: true, Filename: excelFilePath);
            excelApp.Quit();

            System.Diagnostics.Process.Start(excelFilePath);
        }

        private void excelStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string basePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) , "Data\\employees");
            excelFct(basePath + "Template.xlsx", basePath + ".xlsx");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream stream = File.OpenRead("data.bin"))
                {
                    employees = (List<Employee>)formatter.Deserialize(stream);
                    Display();
                }
            }
            catch (Exception s)
            {
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream stream = File.Create("data.bin"))
                {
                    formatter.Serialize(stream, employees);
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void lvEmp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvEmp.SelectedItems.Count != 0)
            {
                ListViewItem lvi = lvEmp.SelectedItems[0];
                Employee em = (Employee)lvi.Tag;

                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    employees.Remove(em);
                }

                Display();
            }
            else
            {
                MessageBox.Show("Choose an item");
            }
        }
    }
}
