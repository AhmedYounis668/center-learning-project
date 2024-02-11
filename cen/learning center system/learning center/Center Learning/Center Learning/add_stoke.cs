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
    public partial class add_stoke : DevExpress.XtraEditors.XtraForm
    {
        public add_stoke()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select*from stokes where stoke_id=" + txtstoke_id.Text + "", "");
            if (tbl.Rows.Count >= 1)
            {
                MessageBox.Show("", "تم اضافه خزنه بنفس الرقم التسلسلي الموجود هل انت تريد عمل تحديث اذا كنت تريد تحديث اضغط علي  زر update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string d = dtp.Value.ToString("yyyy-MM-dd");
            if (txtstoke_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الخزنه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.excutedata("insert into stokes values(" + txtstoke_id.Text + ",N'" + txtstoke_name.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + txtnotes.Text.Trim() + "',N'" + d + "')", "تم حفظ الخزنه بنجاح");
                autonumber();
            }
        }
        private void autonumber()
        {

            tbl = db.readdata("select max(stoke_id)from stokes", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtstoke_id.Text = "1";
            }
            else
            {
                txtstoke_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtstoke_name.Clear();
            tbl.Clear();
            tbl = db.readdata("select stoke_id as 'رقم الخزنه',stoke_name as 'اسم الخزنه',notes as 'ملاحظات',user_name as 'اسم المستخدم' from stokes", "");
            dgv.DataSource = tbl;
            txtnotes.Clear();
            txtstoke_name.Focus();
        }
        private void add_stoke_Load(object sender, EventArgs e)
        {
            dtp.Text = DateTime.Now.ToShortDateString();
            autonumber();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                db.excutedata("update stokes set stoke_name=N'" + dgv.CurrentRow.Cells[1].Value + "' where stoke_id=" + dgv.CurrentRow.Cells[0].Value + " ", "تم تعديل الخزنه بنجاح");

                autonumber();
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();

        }
    }
}