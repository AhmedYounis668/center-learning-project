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
    public partial class mrahel : DevExpress.XtraEditors.XtraForm
    {
        public mrahel()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void autonumber()
        {

            tbl = db.readdata("select max(group_id)from groups", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtmarhalaid.Text = "1";
            }
            else
            {
                txtmarhalaid.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtmarhalaname.Clear();
            txtnotes.Clear();
            tbl.Clear();
            tbl = db.readdata("select group_id as 'رقم المرحله',group_name as 'اسم المرحله',price as'سعر الطالب في المرحله' from groups", "");
            dgv.DataSource = tbl;
            txtmarhalaname.Focus();
        }
        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void mrahel_Load(object sender, EventArgs e)
        {
            autonumber();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtmarhalaname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المرحله اولا قبل الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(numircprice.Value<=0)
            {
                MessageBox.Show("من فضلك ادخل سعر الشهر للطالب في هذه المرحله", "خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            else
            {
                db.excutedata("insert into groups values(" + txtmarhalaid.Text + ",N'" + txtmarhalaname.Text.Trim() + "',N'"+txtnotes.Text.Trim()+"',"+numircprice.Value+")", "تم الحفظ بنجاح");
                autonumber();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (txtmarhalaname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المرحله اولا قبل الحفظ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (numircprice.Value <= 0)
            {
                MessageBox.Show("من فضلك ادخل سعر الشهر للطالب في هذه المرحله", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                db.excutedata("update groups set group_name=N'" + txtmarhalaname.Text.Trim() + "' , notes= N'"+txtnotes.Text.Trim()+"',price="+numircprice.Value+" where group_id=" + dgv.CurrentRow.Cells[0].Value + "", "تم التعديل بنجاح");
                autonumber();
            }
        }

        private void txtmarhalaname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtnotes.Focus();
            }
        }

        private void txtnotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tileItem1_ItemClick(null,null);
            }
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count<=0)
            {
                MessageBox.Show("من فضلك يجب ان تكون محدد السطر الذي تريد مسحه ", "خطا");
                return;
            }
            else
            {
                db.excutedata("delete from groups where group_id="+dgv.CurrentRow.Cells[0].Value+"", "تم المسح بنجاح");
                tbl.Clear();
                tbl = db.readdata("select group_id as 'رقم المرحله',group_name as 'اسم المرحله' from groups", "");
                dgv.DataSource = tbl;
                txtmarhalaname.Focus();
            }
        }
    }
}