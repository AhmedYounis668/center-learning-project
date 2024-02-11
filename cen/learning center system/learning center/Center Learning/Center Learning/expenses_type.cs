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
    public partial class expenses_type : DevExpress.XtraEditors.XtraForm
    {
        public expenses_type()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txttypename.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المصروف ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.excutedata("insert into deserved_type values(" + txttypenumber.Text + ",N'" + txttypename.Text.Trim() + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "')", "تم الادخال");
                autonumber();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                db.excutedata("update deserved_type set type_name=N'" + dgv.CurrentRow.Cells[1].Value + "',notes=N'" + dgv.CurrentRow.Cells[2].Value + "' where type_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم التعديل بنجاح");
                
                autonumber();
            }
        }
        private void autonumber()
        {

            tbl = db.readdata("select max(type_id)from deserved_type", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txttypenumber.Text = "1";
            }
            else
            {
                txttypenumber.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txttypename.Clear();
            tbl.Clear();
            tbl = db.readdata("select type_id as 'رقم النوع',type_name as 'اسم المصروف',notes as 'ملاحظات' from deserved_type", "");
            dgv.DataSource = tbl;
            txttypename.Focus();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select type_id as 'رقم النوع',type_name as 'اسم المصروف',notes as 'ملاحظات' from deserved_type where type_name like N'%" + txttypename.Text.Trim() + "%'", "");
            dgv.DataSource = tbl;
        }

        private void expenses_type_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
    }
}