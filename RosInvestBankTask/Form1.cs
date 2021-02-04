using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace RosInvestBankTask
{
    public partial class Form1 : Form
    {
        Excel.Application exApp = new Excel.Application(); //объект класса Aplication

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testTaskDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.testTaskDataSet.Clients);

        }

        private void FindINN_Click(object sender, EventArgs e)
        {

            if (INN == null)
            {
                ResultTexBox.Text = "Введите ИНН!";
            }
            else
            {
                clientsBindingSource.Filter = "SocialNumber = \'" + INN.Text + "\'";
                ResultTexBox.Text = "ИНН найден";
            }
            INN.Clear();
        }

        private void FindAll_Click(object sender, EventArgs e)
        {
            clientsBindingSource.Filter = null;
            ResultTexBox.Clear();
            INN.Clear();
        }

        private void Import_Click(object sender, EventArgs e)
        {
            ReadEx(@"E:\Template\example.xlsx", 1);
        }


        public void ReadEx(string path, int Sheet)
        {
            MessageBox.Show(dataGridView1.RowCount.ToString());
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                var wb = exApp.Workbooks.Open(path);
                Excel.Worksheet ws = wb.Worksheets[Sheet];
                ws = GetValue(wb, ws, "[ID]", 0,i);
                ws = GetValue(wb, ws, "[Name]", 1,i);
                ws = GetValue(wb, ws, "[BirthDate]", 2, i);
                ws = GetValue(wb, ws, "[PhoneNumber]", 3, i);
                ws = GetValue(wb, ws, "[Address]", 4, i);
                ws = GetValue(wb, ws, "[SocialNumber]", 5, i);
                wb.SaveAs($@"E:\RosInvestBankTask\RosInvestBankTask\Result\{DateTime.Now.ToShortDateString() + new Random().Next(9999)}.xlsx");
                exApp.Quit();
            }
        }


        private Excel.Worksheet GetValue(Excel.Workbook WB, Excel.Worksheet WS, string key,int index, int Row)
        {
            Excel.Range last = WS.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = WS.get_Range("A1", last);
            var findResult = range.Find(key, Missing.Value,
                    Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                    Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                    Missing.Value, Missing.Value);

            var firstFindResult = findResult;

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (j == index)
                    {
                        var val1 = dataGridView1[j, Row].Value;
                        
                        bool isFirst = false;
                        while (findResult != null)
                        {

                            var result = findResult;

                            //ws.Cells = result.Address[Excel.XlReferenceStyle.xlA1]; 

                            //MessageBox.Show(result.Address[Excel.XlReferenceStyle.xlA1]);
                            string loc = result.Address[Excel.XlReferenceStyle.xlA1];

                            if (isFirst && firstFindResult.Address[Excel.XlReferenceStyle.xlA1] == findResult.Address[Excel.XlReferenceStyle.xlA1])
                            {
                                findResult = null;
                            }
                            isFirst = true;
                            findResult = range.FindNext(findResult);
                            //MessageBox.Show(loc.Split('$')[1]);
                            //MessageBox.Show(loc.Split('$')[2]);
                            WS.Cells[int.Parse(loc.Split('$')[2]), loc.Split('$')[1]] = val1;

                        }


                    }
                
            }
            return WS;
        }
    }
}
