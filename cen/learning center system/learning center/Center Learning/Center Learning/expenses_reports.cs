using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Center_Learning
{
    public partial class expenses_reports : DevExpress.XtraEditors.XtraForm
    {
        public expenses_reports()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            tbl.Clear();
            tbl = db.readdata("select type_name as'البيان',money as'المبلغ',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم' from deserved where convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
            dgv.DataSource = tbl;

            if (dgv.Rows.Count >= 1)
            {
                decimal total = 0;
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(dgv.Rows[i].Cells[1].Value);
                }
                txttotal.Text = total.ToString();
            }
        }

        private void expenses_reports_Load(object sender, EventArgs e)
        {

            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        private void bnprint_Click(object sender, EventArgs e)
        {
            try
            {
                string from = "", to = "";
                from = dtpfrom.Value.ToString("yyyy-MM-dd");
                to = dtpto.Value.ToString("yyyy-MM-dd");

                DataTable tblprint = new DataTable();
                tblprint.Clear();
                tblprint = db.readdata("select deserved_id as'رقم العمليه',type_name as'نوع البيان',money as'المبلغ',notes as'ملاحظات',date as'التاريخ',user_name as'المستخدم' from deserved where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
                printing frm = new printing();
                frm.crystalReportViewer1.RefreshReport();

                expenses_report_print rpt = new expenses_report_print();
                rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                rpt.SetDataSource(tblprint);
                rpt.SetParameterValue("from", from);
                rpt.SetParameterValue("to", to);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.ShowDialog();
                //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                //rpt.PrintToPrinter(1, true, 0, 0);
            }
            catch (Exception) { }


        }
    }
}