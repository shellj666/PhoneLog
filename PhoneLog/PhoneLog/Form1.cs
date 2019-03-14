using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhoneLog
{
    public partial class Form_PhoneLog : Form
    {
        string PhoneLogFile = @"C:\Users\Michelle\Desktop\PhoneLog\PhoneLog\Items\PhoneLog";

        public Form_PhoneLog()
        {
            InitializeComponent();
            Lbl_Name.Text = "Welcome " + SystemInformation.UserName;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Form_About form_About = new Form_About();
            form_About.Show();
        }

        private void Btn_OpenPhoneLog_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            Excel.Workbook ExcelWrkBook = ExcelApp.Workbooks.Open(PhoneLogFile, Excel.XlFileAccess.xlReadOnly, true);
            ExcelApp.Visible = true;
        }
    }
}
