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
    public partial class addemployee : DevExpress.XtraEditors.XtraForm
    {
        public addemployee()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void autonumber()
        {
            tbl.Clear();
            tbl = db.readdata("select max(emp_id)from add_new_employee", "");

            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtemp_id.Text = "1";
            }
            else
            {
                txtemp_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtemp_name.Clear();
            txtnationalid.Clear();
            txtphone.Clear();
            txtaddress.Clear();
            numericsalary.Value = 0;
            checkactivation.Checked = true;
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee ", "");
            dgv.DataSource = tbl;
        }

        private void totalemployeesalary()
        {
            try
            {
                DataTable tbltotalemployeesalary = new DataTable();
                tbltotalemployeesalary = db.readdata("select *from add_new_employee where activation='1'", "");
                decimal total = 0;
                for (int i = 0; i <= tbltotalemployeesalary.Rows.Count - 1; i++)
                {
                    total += Convert.ToDecimal(tbltotalemployeesalary.Rows[i][2]);
                }
                txttotalemployeesalary.Text = total.ToString();
            }
            catch (Exception)
            {


            }
        }
        private void addemployee_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdateofadd.Text = DateTime.Now.ToShortDateString();

            btndelete.Enabled = false;
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee ", "");
            dgv.DataSource = tbl;
            totalemployeesalary();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtemp_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموظف اولا ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtnationalid.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم بطاقه الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtphone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل تليفون الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numericsalary.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل راتب الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string datetoday = "";
            datetoday = dtpdateofadd.Value.ToString("yyyy-MM-dd");
            // d = dtpreminder.Value.ToString("yyyy-MM-dd");
            try
            {

                db.excutedata("insert into add_new_employee values(" + txtemp_id.Text + ",N'" + txtemp_name.Text.Trim() + "'," + numericsalary.Value + ",'" + datetoday + "'," + txtphone.Text + "," + txtnationalid.Text + ",N'" + txtaddress.Text + "','true')", "تم الادخال بنجاح");
            }
            catch (Exception)
            {
            }
            autonumber();
            totalemployeesalary();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            autonumber();

        }
        string emp_activation;

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {

                if (txtemp_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الموظف اولا ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtnationalid.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم بطاقه الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtphone.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل تليفون الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numericsalary.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل راتب الموظف اولا  ", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkactivation.Checked == true)
                {
                    emp_activation = "true";
                }
                if (checkactivation.Checked == false)
                {
                    emp_activation = "false";
                }
                int emp_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                string dateoftoday = "";
                dateoftoday = dtpdateofadd.Value.ToString("yyyy-MM-dd");
                // d = dtpreminder.Value.ToString("yyyy-MM-dd");
                tbl.Clear();

                db.excutedata("update add_new_employee set emp_name=N'" + txtemp_name.Text.Trim() + "' , emp_salary=" + numericsalary.Value + " , start_date=N'" + dateoftoday + "' , phone=" + txtphone.Text + " , national_id=" + txtnationalid.Text + " , address=N'" + txtaddress.Text + "',activation=N'" + emp_activation + "' where emp_id=" + emp_id + "", "تم تعديل البيانات بنجاح");
                autonumber();
                totalemployeesalary();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select emp_id as 'رقم الموظف' , emp_name as 'اسم الموظف', emp_salary as 'المرتب' , start_date as 'تاريخ بدايه العمل' , phone as 'رقم التليفون' , national_id as 'رقم البطاقه' , address as 'العنوان',activation as 'نشط ام لا'  from add_new_employee where emp_name like N'%" + txtsearch.Text.Trim() + "%'", "");
            dgv.DataSource = tbl;
        }
    }
}