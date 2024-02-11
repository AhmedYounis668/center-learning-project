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
    public partial class employeeabsentsanddiscount : DevExpress.XtraEditors.XtraForm
    {
        public employeeabsentsanddiscount()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        database db = new database();


        private void autonumber()
        {
            tbl.Clear();
            tbl = db.readdata("select max(order_id)from absentsandkhosomat", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtorder_id.Text = "1";
            }
            else
            {
                txtorder_id.Text = (Convert.ToDecimal(tbl.Rows[0][0]) + 1).ToString();
            }
            cbxemloyeename.Text = "اختر موظف";
            numericnumberofdays.Value = 0;
        }
        private void fillcbx()
        {
            cbxemloyeename.DataSource = db.readdata("select*from add_new_employee where activation='1'", "");
            cbxemloyeename.DisplayMember = "emp_name";
            cbxemloyeename.ValueMember = "emp_id";
        }

        private void employeeabsentsanddiscount_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        private void radioovertime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioovertime.Checked == true)
            {
                lblovertime.Text = ":عدد ايام الوقت الاضافي ";
            }
            else if (radioovertime.Checked == false)
            {
                lblovertime.Text = ":عدد الايام المخصومه";
            }
        }

        private void radiokhasm_CheckedChanged(object sender, EventArgs e)
        {
            if (radiokhasm.Checked == true)
            {
                lblovertime.Text = ":عدد ايام المخصومه ";
            }
            else if (radiokhasm.Checked == false)
            {
                lblovertime.Text = ":عدد الايام المخصومه";
            }
        }

        private void radioabsents_CheckedChanged(object sender, EventArgs e)
        {
            if (radioovertime.Checked == true)
            {
                lblovertime.Text = ":عدد ايام المخصومه ";
            }
          if (radiokhasmmaly.Checked == true)
            {
                lblovertime.Text = "المبلغ المخصوم";
            }
            else if (radiokhasmmaly.Checked == false)
            {
                lblovertime.Text = "عدد الايام المخصومه";
            }            {
                lblovertime.Text = ":عدد الايام المخصومه";
            }

        }

        private void radiokhasmmaly_CheckedChanged(object sender, EventArgs e)
        {
            if (radiokhasmmaly.Checked == true)
            {
                lblovertime.Text = "المبلغ المخصوم";
            }
            else if (radiokhasmmaly.Checked == false)
            {
                lblovertime.Text = "عدد الايام المخصومه";
            }
        }

        private void radiohafez_CheckedChanged(object sender, EventArgs e)
        {
            if (radiohafez.Checked == true)
            {
                lblovertime.Text = "المبلغ :";
            }
        }

        private void radiobadl_entekal_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobadl_entekal.Checked == true)
            {
                lblovertime.Text = "المبلغ";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string date = "", t = "";
            date = dtpdate.Value.ToString("yyyy-MM-dd");
            t = dtpdate.Value.ToString("HH-MM");
            if (numericnumberofdays.Value <= 0)
            {
                MessageBox.Show("لايجب ان يكون عدد الايام اصغر من او تساوي صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxemloyeename.Text == "اختر موظف")
            {
                MessageBox.Show("من فضلك اختر موظف اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioabsents.Checked == false && radiokhasm.Checked == false && radioovertime.Checked == false && radiokhasmmaly.Checked == false && radiohafez.Checked == false && radiobadl_entekal.Checked == false&&radiosolfa.Checked==false)
            {
                MessageBox.Show("يجب ان تحدد عمليه اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radiokhasm.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'خصم',N'" + date + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            else if (radioabsents.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'غياب',N'" + date + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            else if (radioovertime.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'وقت اضافي',N'" + date + "',N'" + txtnotes.Text.Trim() + "')", "");
                //autonumber();
            }
            else if (radiokhasmmaly.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'خصم مالي',N'" + date + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //autonumber();
            }
            else if (radiohafez.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'حافز',N'" + date + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //   autonumber();
            }
            else if (radiobadl_entekal.Checked == true)
            {
                db.excutedata("insert into absentsandkhosomat values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "'," + numericnumberofdays.Value + ",N'بدل انتقالات',N'" + date + "',N'" + txtnotes.Text.Trim() + "') ", "");
                //autonumber();
            }

            tbl.Clear();
            tbl = db.readdata("select*from add_new_employee where emp_id=" + cbxemloyeename.SelectedValue + "", "");
            decimal salary = Convert.ToDecimal(tbl.Rows[0][2]);
            decimal total = 0;
            string description = "";
            if (radioabsents.Checked == true)
            {
                description = "غياب" + " " + numericnumberofdays.Value + " " + "يوم";
                total = salary / 30;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            else if (radiokhasm.Checked == true)
            {
                description = "خصم" + " " + numericnumberofdays.Value + " " + "يوم";
                total = total = salary / 30;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            else if (radiokhasmmaly.Checked == true)
            {
                description = "خصم مالي";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + "," + total + ",0,N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            else if (radioovertime.Checked == true)
            {
                description = "اوفر تايم" + " " + numericnumberofdays.Value + " " + "يوم";
                total = (salary / 30)* numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            else if (radiobadl_entekal.Checked == true)
            {
                description = "بدل انتقال";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();


            }
            else if (radiohafez.Checked == true)
            {
                description = "حافز";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }
            else if (radiosolfa.Checked == true)
            {
                description = "سلفه";
                total = numericnumberofdays.Value;
                db.excutedata("insert into employee_account values(" + txtorder_id.Text + "," + cbxemloyeename.SelectedValue + ",N'" + cbxemloyeename.Text + "',N'" + description + "'," + total + ",0," + total + ",N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + date + "',N'" + description + "',N'" + t + "',0)", "تمت العمليه بنجاح");
                autonumber();
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}