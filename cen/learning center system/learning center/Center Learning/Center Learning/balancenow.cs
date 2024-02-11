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
    public partial class balancenow : DevExpress.XtraEditors.XtraForm
    {
        public balancenow()
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


        private void totalkhaznanow()
        {
            try
            {
                tbl.Clear();
                tbl = db.readdata("select *from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
                if (tbl.Rows.Count <= 0)
                {
                    db.excutedata("insert into stoke_money values(" + cbxkhaznaname.SelectedValue + ",'0')", "");
                    tbl = db.readdata("select *from stoke_money where stoke_id=" + cbxkhaznaname.SelectedValue + "", "");
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
            catch (Exception) { }

        }

        private void balancenow_Load(object sender, EventArgs e)
        {
            fillcbx();
         
            totalkhaznanow();
        }

        private void cbxkhaznaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            totalkhaznanow();
        }
    }
}