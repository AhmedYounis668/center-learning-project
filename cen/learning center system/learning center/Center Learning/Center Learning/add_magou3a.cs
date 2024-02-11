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
    public partial class add_magou3a : DevExpress.XtraEditors.XtraForm
    {
        public add_magou3a()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void autonumber()
        {

            tbl = db.readdata("select max(magmou3a_id)from magmou3at_data", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtmagmou3aid.Text = "1";
            }
            else
            {
                txtmagmou3aid.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtmagmou3aname.Clear();
            tbl.Clear();
            tbl = db.readdata("select magmou3a_id as 'رقم المجموعه',magmou3a_name as 'اسم المجموعه' from magmou3at_data", "");
            dgv.DataSource = tbl;
            txtmagmou3aname.Focus();
        }

        private void add_magou3a_Load(object sender, EventArgs e)
        {
            autonumber();

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtmagmou3aname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعه اولا قبل الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                db.excutedata("insert into magmou3at_data values(" + txtmagmou3aid.Text + ",N'" + txtmagmou3aname.Text.Trim() + "')", "تم الحفظ بنجاح");
                autonumber();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtmagmou3aname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المرحله اولا قبل الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                db.excutedata("update magmou3at_data set magmou3a_name=N'" + txtmagmou3aname.Text.Trim() + "'  where magmou3a_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم التعديل بنجاح");
                autonumber();
            }
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count <= 0)
            {
                MessageBox.Show("من فضلك يجب ان تكون محدد السطر الذي تريد مسحه ", "خطا");
                return;
            }
            else
            {
                db.excutedata("delete from magmou3at_data where magmou3a_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم المسح بنجاح");
                tbl.Clear();
                tbl = db.readdata("select magmou3a_id as 'رقم المجموعه',magmou3a_name as 'اسم المجموعه' from magmou3at_data", "");
                dgv.DataSource = tbl;
                txtmagmou3aname.Focus();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
    }
}