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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();
        private void btnenter_Click(object sender, EventArgs e)
        {
            if(cbxmonth.Text=="")
            {
                MessageBox.Show("من فضلك اختر الشهر الحالي اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (Properties.Settings.Default.product_key == "no")
            //{
            //    serialnumber frm = new serialnumber();
            //    frm.ShowDialog();

            //}
            //else
            //{
           // int stoke_id =1;
                if (radiomanger.Checked == false && radioemployee.Checked == false)
                {
                    MessageBox.Show("اختر اولا اذا كنت مدير ام مستخدم", "اختر قبل التنفيذ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbl.Clear();
                if (radiomanger.Checked == true)
                    tbl = db.readdata("select*from addnew_users where user_name=N'" + txtusername.Text + "' and user_password=N'" + txtpassword.Text + "' and type=N'مدير'", "");
                else if (radioemployee.Checked == true)
                    tbl = db.readdata("select*from addnew_users where user_name=N'" + txtusername.Text + "' and user_password=N'" + txtpassword.Text + "' and type=N'مستخدم' ", "");




            string user_name = "123";
            string d = DateTime.Now.ToString("yyyy-MM-dd");
                DataTable tbluser = new DataTable();
                tbluser.Clear();
                tbluser = db.readdata("select*from addnew_users", "");
                if (tbluser.Rows.Count <= 0)
                {
                    if (radioemployee.Checked == true)
                    {
                        MessageBox.Show("انت لست مدير وليس لك اي بيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (radiomanger.Checked == true && txtusername.Text != "123" && txtpassword.Text != "123")
                    {
                        MessageBox.Show("من فضلك تاكد من بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DataTable tblstoke = new DataTable();
                    tblstoke.Clear();
                    tblstoke = db.readdata("select*from stokes", "");
                    if (tblstoke.Rows.Count <= 0)
                    {
                        db.excutedata("insert into stokes values(1,N'الخزنه الرئيسيه',N'"+user_name+"',N'',N'"+d+"')", "");

                    }




                   




                    string type = "مدير";
                   
                    db.excutedata("insert into addnew_users values(1,N'123',N'123',N'" + type + "' ,1 )", "");
                    db.excutedata("insert into user_settings values(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1)", "");
                    

                    tbl.Clear();
                    if (radiomanger.Checked == true)
                        tbl = db.readdata("select*from addnew_users where user_name=N'" + txtusername.Text + "' and user_password=N'" + txtpassword.Text + "' and type=N'مدير' ", "");
                    else if (radioemployee.Checked == true)
                        tbl = db.readdata("select*from addnew_users where user_name=N'" + txtusername.Text + "' and user_password=N'" + txtpassword.Text + "' and type=N'مستخدم' ", "");

                }



                else if (tbl.Rows.Count >= 1)
                {
                    //تشغيل كود النسخه التجريبيه

                    //bool check;
                    //check = trial();
                    //if (check == false)
                    //{
                    //    return;
                    //}
                    Properties.Settings.Default.user_name = txtusername.Text;
                    Properties.Settings.Default.stoke_id = Convert.ToString(tbl.Rows[0][4]);
                Properties.Settings.Default.month =Convert.ToInt32( cbxmonth.Text);
                    Properties.Settings.Default.Save();
                    this.Hide();

                  //  speek.SpeakAsync("Welcome to Your Sales Program" + Properties.Settings.Default.user_name);
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("هذه البيانات خاطئه من فضلك تاكد من اسم المستخدم وكلمه السر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


           // }



        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               btnenter_Click(null,null);
            }
        }

        private void connectonline_Click(object sender, EventArgs e)
        {
            serverconnection frm = new serverconnection();
            frm.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblcurrentmonth.Text = dtp.Value.Month.ToString();
            cbxmonth.Text = lblcurrentmonth.Text;
            tbl.Clear();
            tbl = db.readdata("select*from settingprinting_bills", "");
            if (tbl.Rows.Count >= 1)
            {
                label7.Text = "Welcome To Simple ToucH"+" "+ Convert.ToString(tbl.Rows[0][1]);
            }
            else if (tbl.Rows.Count < 1)
            {
                label7.Text = "Welcome To Simple ToucH"+" "+ "...";
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblcurrentmonth.Text = dtp.Value.Month.ToString();

        }
    }
}