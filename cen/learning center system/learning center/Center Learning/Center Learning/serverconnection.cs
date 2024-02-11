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
    public partial class serverconnection : DevExpress.XtraEditors.XtraForm
    {
        public serverconnection()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();
        private void btnsave_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.servername = txtservername.Text.Trim();
            Properties.Settings.Default.databasename = txtdatabasename.Text.Trim();
            Properties.Settings.Default.daatabaseuser_name = txtusername.Text.Trim();
            Properties.Settings.Default.databasepassword = txtpassword.Text.Trim();
            Properties.Settings.Default.Save();

            if (checkdontshow.Checked == false)
            {
                Properties.Settings.Default.updateconnecttoserver = false;
            }
            else if (checkdontshow.Checked == true)
            {
                Properties.Settings.Default.updateconnecttoserver = true;
            }

            if (MessageBox.Show("هل انت متاكد من البيانات المدخله من فضلك تاكد من البيانات قبل الضغط علي زر Yes", "تنبيه هاااااااام", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void serverconnection_Load(object sender, EventArgs e)
        {
            txtservername.Text = Convert.ToString(Properties.Settings.Default.servername);
            txtdatabasename.Text = Convert.ToString(Properties.Settings.Default.databasename);
            txtusername.Text = Properties.Settings.Default.daatabaseuser_name;
            txtpassword.Text = Properties.Settings.Default.databasepassword;

            if (Properties.Settings.Default.updateconnecttoserver == false)
            {
                checkdontshow.Checked = false;
            }
            else if (Properties.Settings.Default.updateconnecttoserver == true)
            {
                checkdontshow.Checked = true;
            }
        }

        private void txtservername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtservername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtdatabasename.Focus();
            }
        }

        private void txtdatabasename_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdatabasename_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtusername.Focus();
            }
        }

        private void txtusername_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnsave_Click(null, null);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}