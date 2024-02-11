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
    public partial class hdourandensraf : DevExpress.XtraEditors.XtraForm
    {
        public hdourandensraf()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxemployee.DataSource = db.readdata("select*from add_new_employee where activation=1", "");
            cbxemployee.DisplayMember = "emp_name";
            cbxemployee.ValueMember = "emp_id";
        }

        private void autonumber()
        {
            txtsearch.Clear();
            txtnotes.Clear();

        }
        private void hdourandensraf_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            dtptime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radioensraf.Checked == false && radioattend.Checked == false)
            {
                MessageBox.Show("من فضلك حدد اما اذا كان هذا حضور اما انصراف", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Value.ToString("HH:MM");
                string description = "";
                if (radioattend.Checked == true)
                {
                    description = "حضور";
                }
                else if (radioensraf.Checked == true)
                {
                    description = "انصراف";
                }

                db.excutedata("insert into employee_attendans(emp_id,emp_name,description,date,time,notes,user_name) values(" + cbxemployee.SelectedValue + ",N'" + cbxemployee.Text + "',N'" + description + "',N'" + d + "',N'" + t + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "')", "تم التسجيل");
                autonumber();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select order_id as'رقم اليبان',emp_name as'اسم الموظف',description as'البيان',notes as'ملاحظات',date as'التاريخ',time as'الوقت',user_name as'المستخدم' from employee_attendans where emp_name like N'%" + txtsearch.Text.Trim() + "%'", "");
            dgv.DataSource = tbl;
        }
    }
}