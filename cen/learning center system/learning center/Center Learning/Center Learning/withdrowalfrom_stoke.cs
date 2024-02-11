using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Center_Learning
{
    public partial class withdrowalfrom_stoke : DevExpress.XtraEditors.XtraForm
    {
        public withdrowalfrom_stoke()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void autnumber()
        {
            numericaddnewbalance.Value = 0;
            txteda3reason.Clear();
            txtnamemode3.Clear();
            lbltotal_khaznanow.Text = "......";
            radiotasfeeer.Checked = false;
            radiowithdrowal3aady.Checked = false;
        }

        private void fillcbx()
        {
            cbxkhaznaname.DataSource = db.readdata("select*from stokes", "");
            cbxkhaznaname.DisplayMember = "stoke_name";
            cbxkhaznaname.ValueMember = "stoke_id";
        }
        private void withdrowalfrom_stoke_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //if (Convert.ToDecimal(lbltotal_khaznanow.Text) < numericaddnewbalance.Value)
            //{
            //    MessageBox.Show("المبلغ المراد سحبه اكبر من المبلغ الموجود في الخزنه من فضلك راجع بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (numericaddnewbalance.Value <= 0)
            //{
            //    MessageBox.Show("لايجب ان تكون القيمه المسحوبه اصغر من اوتساوي صفر  0", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (txtnamemode3.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المسؤل عن السحب اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(radiotasfeeer.Checked==false&&radiowithdrowal3aady.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string d1 = "";
            d1 = dtpdate.Value.ToString("yyyy-MM-dd");
            if (radiowithdrowal3aady.Checked == true)
            {
                if (Convert.ToDecimal(lbltotal_khaznanow.Text) < numericaddnewbalance.Value)
                {
                    MessageBox.Show("المبلغ المراد سحبه اكبر من المبلغ الموجود في الخزنه من فضلك راجع بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numericaddnewbalance.Value <= 0)
                {
                    MessageBox.Show("لايجب ان تكون القيمه المسحوبه اصغر من اوتساوي صفر  0", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.excutedata("update stoke_money set money=money-" + numericaddnewbalance.Value + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name)values(" + cbxkhaznaname.SelectedValue + "," + numericaddnewbalance.Value + ",'" + d1 + "',N'" + txtnamemode3.Text + "',N'سحب يدوي من الخزنه مباشر',N'" + txteda3reason.Text + "',N'" + Properties.Settings.Default.user_name + "')", "تم السحب بنجاح");
            }
            else if(radiotasfeeer.Checked==true)
            {
                if(lbltotal_khaznanow.Text== ".............")
                {
                    MessageBox.Show("من فضلك حدد الخزنه اولا", "من فضلك حدد الخزنه اولا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else if(Convert.ToDecimal(lbltotal_khaznanow.Text)==0)
                {
                    MessageBox.Show("من فضلك انتبه المبلغ الموجود الان في الخزنه يساوي صفر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.excutedata("update stoke_money set money=money-" + Convert.ToDecimal(lbltotal_khaznanow.Text) + "where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name)values(" + cbxkhaznaname.SelectedValue + "," + numericaddnewbalance.Value + ",'" + d1 + "',N'" + txtnamemode3.Text + "',N'تصفير الخزنه تلقائي',N'" + txteda3reason.Text + "',N'" + Properties.Settings.Default.user_name + "')", "تم السحب بنجاح");

            }

            autnumber();
        }

        private void cbxkhaznaname_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }

        private void cbxkhaznaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                tbl = db.readdata("select*from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbltotal_khaznanow.Text = Convert.ToDecimal(tbl.Rows[0][1]).ToString();
            }
        }
    }
}