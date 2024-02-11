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
    public partial class sal7iat_users : DevExpress.XtraEditors.XtraForm
    {
        public sal7iat_users()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {

        }

        private void btnlast_Click(object sender, EventArgs e)
        {

        }
        private void autonumber()
        {
            DataTable tblshowdataindgv = new DataTable();
            tblshowdataindgv.Clear();
            tblshowdataindgv = db.readdata("select user_id as 'رقم المستخدم' ,addnew_users.user_name as'اسم المستخدم', user_password as 'الرقم السري' , type as 'نوع المستخدم' , stokes.stoke_name as 'الخزنه المحدده له'  from addnew_users,stokes where stokes.stoke_id=addnew_users.stoke_id", "");
            dgv.DataSource = tblshowdataindgv;
            tbl.Clear();
            tbl = db.readdata("select max(user_id)from addnew_users", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtseries.Text = "1";
            }
            else
            {
                txtseries.Text = (Convert.ToInt16(tbl.Rows[0][0]) + 1).ToString();
            }
            txtuser_name.Clear();
            txtpassword.Clear();
            cbxstokename.Text = "اختر خزنه";
            cbxtype.Text = "اختر نوع";
        }


        //show

        int row = 0;
        private void show()
        {
            try
            {
                tbl.Clear();
                tbl = db.readdata("select*from addnew_users", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات تخص هذه الشاشه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtseries.Text = tbl.Rows[row][0].ToString();
                    txtuser_name.Text = tbl.Rows[row][1].ToString();
                    txtpassword.Text = tbl.Rows[row][2].ToString();
                    cbxtype.Text = tbl.Rows[row][3].ToString();
                    cbxstokename.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                }
            }
            catch (Exception) { }
        }

        private void fillcbx()
        {
            cbxstokename.DataSource = db.readdata("select*from stokes ", "");
            cbxstokename.DisplayMember = "stoke_name";
            cbxstokename.ValueMember = "stoke_id";
            //=================================================================

            cbxsetting.DataSource = db.readdata("select*from addnew_users", "");
            cbxsetting.DisplayMember = "user_name";
            cbxsetting.ValueMember = "user_id";
            //============================================

         
        }
            private void btnadd_Click_1(object sender, EventArgs e)
        {

            if (txtuser_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمه سر للمستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxstokename.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل خزنه اولا في شاشه اضافه خزن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxstokename.Text == "اختر خزنه")
            {
                MessageBox.Show("من فضلك اختر خزنه اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    db.excutedata("insert into addnew_users values(" + txtseries.Text + ",N'" + txtuser_name.Text.Trim() + "',N'" + txtpassword.Text.Trim() + "',N'" + cbxtype.Text + "'," + cbxstokename.SelectedValue + ")", "تم ادخال بيانات المستخدم بنجاح");
                    db.excutedata("insert into user_settings values(" + txtseries.Text + ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)", "");
                    
                }
                catch (Exception) { }
            }
            fillcbx();
            autonumber();
        }

        private void btnlast_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(user_id)from addnew_users", "");
            if (row == 0)
            {
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();

            }
            else
            {
                row--;
                show();
            }
        }

        private void btnfirst_Click_1(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            autonumber();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            if (txtuser_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمه سر للمستخدم اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            db.excutedata("update addnew_users set user_name=N'" + txtuser_name.Text.Trim() + "',user_password=N'" + txtpassword.Text.Trim() + "',type=N'" + cbxtype.Text + "',stoke_id=" + cbxstokename.SelectedValue + " where user_id=" + txtseries.Text + "", "تم تعديل بيانات هذا المستخدم بنجاح");
            fillcbx();
            autonumber();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح بيانات هذا الممستخدم ....تنبيه هذا المستخدم لايمكنه الدخول علي البرنامج بعد حذفه", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.excutedata("delete from addnew_users where user_id=" + txtseries.Text + "", "");
                db.excutedata("delete from user_settings where user_id=" + txtseries.Text + "", "");
             
                MessageBox.Show("تم مسح هذا المستخدم بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable tblusers = new DataTable();
                tblusers.Clear();
                tblusers = db.readdata("select*from addnew_users", "");
                string type = "مدير";
                if (tblusers.Rows.Count <= 0)
                {
                    db.excutedata("insert into addnew_users values(1,123,123,N'" + type + "' ,1)", "");
                    db.excutedata("insert into user_settings values(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1)", "");
                   
                }
                fillcbx();
                autonumber();
            }
        }

        private void btnsavesetting_Click(object sender, EventArgs e)
        {
            try
            {
                int  balance=0, Setting = 0, sal7iat = 0, marahel = 0, magmou3aat = 0, studentdata = 0, absentandattendans = 0, absentandattendans_reports = 0, expenses_type = 0, expenses = 0, expenses_salary = 0, exam_degree = 0, exam_degree_reports = 0, add_stoke = 0, stoke_insert = 0, stoke_withdrowal = 0, stoke_reports = 0,student_account=0,copy_data=0,copy_return=0;

              
                if (checksetting.Checked == true)
                    Setting = 1;
                else
                    Setting = 0;
                if (checkusers_sal7iat.Checked == true)
                    sal7iat = 1;
                else
                    sal7iat = 0;
                if (checkmarahel.Checked == true)
                    marahel = 1;
                else
                    marahel = 0;
                if (checkmagmou3aat.Checked == true)
                    magmou3aat = 1;
                else
                    magmou3aat = 0;
                if (checkstudentdata.Checked == true)
                    studentdata= 1;
                else
                    studentdata = 0;
                if (checkabsentandattendans.Checked == true)
                    absentandattendans = 1;
                else
                    absentandattendans = 0;
                if (checkabsentandattendansreport.Checked == true)
                   absentandattendans_reports = 1;
                else
                    absentandattendans_reports = 0;
                if (checkexpensestype.Checked == true)
                    expenses_type = 1;
                else
                    expenses_type = 0;
                if (checkexpenses.Checked == true)
                   expenses = 1;
                else
                    expenses = 0;
                if (checkexpensessalary.Checked == true)
                    expenses_salary = 1;
                else
                    expenses_salary = 0;
                if (checkdegreeofexam.Checked == true)
                    exam_degree = 1;
                else
                    exam_degree = 0;

                if (checkexamdegree_reports.Checked == true)
                    exam_degree_reports = 1;
                else
                    exam_degree_reports = 0;
                if (checkaddstoke.Checked == true)
                    add_stoke = 1;
                else
                    add_stoke = 0;
                if (checkeda3inkhazna.Checked == true)
                    stoke_insert = 1;
                else
                    stoke_insert = 0;
                if (checkwithdrowalfromstoke.Checked == true)
                    stoke_withdrowal = 1;
                else
                    stoke_withdrowal= 0;
                if (checkkhaznareports.Checked == true)
                    stoke_reports = 1;
                else
                    stoke_reports = 0;
                if (checkcopy.Checked == true)
                    copy_data = 1;
                else
                    copy_data = 0;
                if (checkcopyreturn.Checked == true)
                    copy_return = 1;
                else
                    copy_return = 0;
                if (checkbalancenow.Checked == true)
                    balance = 1;
                else
                    balance = 0;
                if (checkstudent_reports.Checked == true)
                    student_account = 1;
                else
                    student_account = 0;

                db.excutedata("update user_settings set setting=" + Setting + ",sal7iat=" + sal7iat + ",marahel=" + marahel + ",magmou3aat=" + magmou3aat + ",student_data=" + studentdata + ",student_attendans=" + absentandattendans + ",student_attendans_reports=" + absentandattendans_reports + ",expenses_type=" + expenses_type + ",expeses=" + expenses + ",expenses_salary=" + expenses_salary + ",exam_degree=" + exam_degree + ",exam_degree_reports=" + exam_degree_reports + ",eda3_inkhazna=" + stoke_insert + ",withdrowalfromstoke=" + stoke_withdrowal + ",stoke_reports=" + stoke_reports + ",student_account=" + student_account + ",copy_data="+copy_data+",copy_return="+ copy_return+ ",balance="+balance+",add_stoke="+add_stoke+" where user_id=" + cbxsetting.SelectedValue + "", "تم تعديل صلاحيات هذا المستخدم بنجاح");


            }
            catch (Exception)
            { }
        }

        private void cbxsetting_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbxsetting_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblsearch = new DataTable();
            tblsearch.Clear();
            tblsearch = db.readdata("select*from user_settings where user_id=" + cbxsetting.SelectedValue + "", "");
            if (tblsearch.Rows.Count >= 1)
            {
                if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                {
                    checksetting.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                {
                    checksetting.Checked = false;
                }
                //==============================
                if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                {
                    checkusers_sal7iat.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                {
                    checkusers_sal7iat.Checked = false;
                }
                //=================================
                if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                {
                    checkmarahel.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                {
                    checkmarahel.Checked = false;
                }
                //================================
                if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                {
                    checkmagmou3aat.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                {
                    checkmagmou3aat.Checked = false;
                }
                //================================
                if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                {
                    checkstudentdata.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                {
                    checkstudentdata.Checked = false;
                }
                //================================
                if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                {
                    checkabsentandattendans.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                {
                    checkabsentandattendans.Checked = false;
                }
                //====================================
                if (Convert.ToInt32(tblsearch.Rows[0][7]) == 1)
                {
                    checkabsentandattendansreport.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][7]) == 0)
                {
                    checkabsentandattendansreport.Checked = false;
                }
                //====================================================
                if (Convert.ToInt32(tblsearch.Rows[0][8]) == 1)
                {
                    checkexpensestype.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][8]) == 0)
                {
                    checkexpensestype.Checked = false;
                }

                //========================================
                if (Convert.ToInt32(tblsearch.Rows[0][9]) == 1)
                {
                    checkexpenses.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][9]) == 0)
                {
                    checkexpenses.Checked = false;
                }
                //===========================================
                if (Convert.ToInt32(tblsearch.Rows[0][10]) == 1)
                {
                    checkexpensessalary.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][10]) == 0)
                {
                    checkexpensessalary.Checked = false;
                }
                //============================================
                if (Convert.ToInt32(tblsearch.Rows[0][11]) == 1)
                {
                    checkdegreeofexam.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][11]) == 0)
                {
                    checkdegreeofexam.Checked = false;
                }
                //============================================
                if (Convert.ToInt32(tblsearch.Rows[0][12]) == 1)
                {
                    checkexamdegree_reports.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][12]) == 0)
                {
                    checkexamdegree_reports.Checked = false;
                }
                //=============================================
                if (Convert.ToInt32(tblsearch.Rows[0][13]) == 1)
                {
                    checkeda3inkhazna.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][13]) == 0)
                {
                    checkeda3inkhazna.Checked = false;
                }
                //=================================================
                if (Convert.ToInt32(tblsearch.Rows[0][14]) == 1)
                {
                    checkwithdrowalfromstoke.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][14]) == 0)
                {
                    checkwithdrowalfromstoke.Checked = false;
                }
                //===============================================
                if (Convert.ToInt32(tblsearch.Rows[0][15]) == 1)
                {
                    checkkhaznareports.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][15]) == 0)
                {
                    checkkhaznareports.Checked = false;
                }
                //=============================================
                if (Convert.ToInt32(tblsearch.Rows[0][16]) == 1)
                {
                    checkstudent_reports.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][16]) == 0)
                {
                    checkstudent_reports.Checked = false;
                }
              

                //=================================================
                if (Convert.ToInt32(tblsearch.Rows[0][17]) == 1)
                {
                    checkcopy.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][17]) == 0)
                {
                    checkcopy.Checked = false;
                }
                if (Convert.ToInt32(tblsearch.Rows[0][18]) == 1)
                {
                    checkcopyreturn.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][18]) == 0)
                {
                    checkcopyreturn.Checked = false;
                }
                if (Convert.ToInt32(tblsearch.Rows[0][19]) == 1)
                {
                    checkbalancenow.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][19]) == 0)
                {
                    checkbalancenow.Checked = false;
                }
                if (Convert.ToInt32(tblsearch.Rows[0][20]) == 1)
                {
                    checkaddstoke.Checked = true;
                }
                else if (Convert.ToInt32(tblsearch.Rows[0][20]) == 0)
                {
                   checkaddstoke.Checked = false;
                }
            }
            }

        private void sal7iat_users_Load(object sender, EventArgs e)
        {
            autonumber();
            fillcbx();
        }
    }
}