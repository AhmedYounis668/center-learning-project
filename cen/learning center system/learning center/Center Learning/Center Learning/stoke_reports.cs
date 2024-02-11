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
    public partial class stoke_reports : DevExpress.XtraEditors.XtraForm
    {
        public stoke_reports()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxkhaznaname.DataSource = db.readdata("select*from stokes", "");
            cbxkhaznaname.DisplayMember = "stoke_name";
            cbxkhaznaname.ValueMember = "stoke_id";
        }
        private void stoke_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text= DateTime.Now.ToShortDateString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = "", dto = "";
            dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            if(radioeda3aat.Checked==false&&radiowithdrowal.Checked==false&&radiotasfeeronly.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(radioeda3aat.Checked==true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه',stokes.stoke_name as'الخزنه',money as'المبلغ',stoke_insert.date as'التاريخ',name as'-',type as'نوع الايداع',stoke_insert.notes as'ملاحظات',stoke_insert.user_name as'اسم المستخدم' from stoke_insert,stokes where stoke_insert.stoke_id=stokes.stoke_id and stoke_insert.stoke_id="+cbxkhaznaname.SelectedValue+" and convert(nvarchar,stoke_insert.date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                    dgv.DataSource = tbl;
                }
                else if(radiowithdrowal.Checked==true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه',stokes.stoke_name as'الخزنه',money as'المبلغ',stoke_withdrowal.date as'التاريخ',name as'-',type as'نوع السحب',stoke_withdrowal.notes as'ملاحظات',stoke_withdrowal.user_name as'اسم المستخدم' from stoke_withdrowal,stokes where stoke_withdrowal.stoke_id=stokes.stoke_id and stoke_withdrowal.stoke_id="+cbxkhaznaname.SelectedValue+ " and convert(nvarchar,stoke_withdrowal.date,105)between N'" + dfrom + "' and N'" + dto + "' ", "");
                    dgv.DataSource = tbl;
                }
                else if(radiotasfeeronly.Checked==true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه',stokes.stoke_name as'الخزنه',money as'المبلغ',stoke_withdrowal.date as'التاريخ',name as'-',type as'نوع السحب',stoke_withdrowal.notes as'ملاحظات',stoke_withdrowal.user_name as'اسم المستخدم' from stoke_withdrowal,stokes where stoke_withdrowal.stoke_id=stokes.stoke_id and stoke_withdrowal.stoke_id=" + cbxkhaznaname.SelectedValue + " and convert(nvarchar,stoke_withdrowal.date,105)between N'" + dfrom + "' and N'" + dto + "' and type=N'تصفير الخزنه تلقائي' ", "");
                    dgv.DataSource = tbl;
                }

                decimal totalmoney = 0;
                for(int i=0;i<=dgv.Rows.Count-1;i++)
                {
                    totalmoney += Convert.ToDecimal(dgv.Rows[i].Cells[2].Value);
                }
                txttotal.Text = totalmoney.ToString();
            }
        }
    }
}