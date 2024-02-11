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
    public partial class magmou3a : DevExpress.XtraEditors.XtraForm
    {
        public magmou3a()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxmarhalaname.DataSource = db.readdata("select*from groups ", "");
            cbxmarhalaname.DisplayMember = "group_name";
            cbxmarhalaname.ValueMember = "group_id";


            cbxmarhalasearch.DataSource = db.readdata("select*from groups ", "");
            cbxmarhalasearch.DisplayMember = "group_name";
            cbxmarhalasearch.ValueMember = "group_id";


            cbxmagmou3aname.DataSource = db.readdata("select*from magmou3at_data ", "");
            cbxmagmou3aname.DisplayMember = "magmou3a_name";
            cbxmagmou3aname.ValueMember = "magmou3a_id";

            cbxmagmou3asearch.DataSource = db.readdata("select*from magmou3at_data ", "");
            cbxmagmou3asearch.DisplayMember = "magmou3a_name";
            cbxmagmou3asearch.ValueMember = "magmou3a_id";
        }

        private void autonumber()
        {
            tbl.Clear();
            tbl = db.readdata("select max(magmou3a_id)from magmou3at ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtorderid.Text = "1";
            }
            else
            {
                txtorderid.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtnotes.Clear();
            dgv.Rows.Clear();
            txtfrom.Clear();
            txtto.Clear();
            lblday.Text = ".......................................";
            btnupdate.Enabled = true;
            tileItem1.Enabled = true;
            tileItem2.Enabled = true;
            tileItem3.Enabled = true;
            simpleButton1.Enabled = true;
        }
        private void magmou3a_Load(object sender, EventArgs e)
        {
            fillcbx();
            autonumber();
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (lblday.Text == "......................................." || lblday.Text == "")
            {
                MessageBox.Show("من فضلك اختر اليوم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (txtfrom.Text == "" || txtto.Text == "")
            {
                MessageBox.Show("من فضلك حدد معاد المجموعه ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(cbxmagmou3aname.Text=="")
            {
                MessageBox.Show("من فضلك حدد اسم المجموعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {


                string order_id = txtorderid.Text;
                string day = lblday.Text;
                string from = txtfrom.Text;
                string to = txtto.Text;
                string marhala = cbxmarhalaname.Text;
                int marhalanumber = Convert.ToInt32(cbxmarhalaname.SelectedValue);






                dgv.Rows.Add(1);
                int rowindex = dgv.Rows.Count - 1;

                dgv.Rows[rowindex].Cells[0].Value = order_id;
                dgv.Rows[rowindex].Cells[1].Value = day;
                dgv.Rows[rowindex].Cells[2].Value = from;
                dgv.Rows[rowindex].Cells[3].Value = to;
                dgv.Rows[rowindex].Cells[5].Value = marhala;
                dgv.Rows[rowindex].Cells[6].Value = marhalanumber;
                dgv.Rows[rowindex].Cells[7].Value = cbxmagmou3aname.Text;









                dgv.ClearSelection();
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblday.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblday.Text = button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblday.Text = button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblday.Text = button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblday.Text = button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblday.Text = button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblday.Text = button7.Text;

        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            mrahel frm = new mrahel();
            frm.ShowDialog();
            fillcbx();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                int index = dgv.SelectedRows[0].Index;
                dgv.Rows.RemoveAt(index);

                
                dgv.ClearSelection();
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;
            }
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(cbxmagmou3aname.Text=="")
            {
                MessageBox.Show("من فضلك حدد اسم المجموعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgv.Rows.Count >= 1)
            {
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into magmou3at values(" + dgv.Rows[i].Cells[0].Value + ","+ dgv.Rows[i].Cells[6].Value + ",N'"+ dgv.Rows[i].Cells[5].Value + "',N'"+ dgv.Rows[i].Cells[1].Value + "',"+ dgv.Rows[i].Cells[2].Value + ","+ dgv.Rows[i].Cells[3].Value + ",N'"+ dgv.Rows[i].Cells[4].Value + "',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',"+cbxmagmou3aname.SelectedValue+",N'"+cbxmagmou3aname.Text+"')", "");
                }
                MessageBox.Show("تم حفظ البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            autonumber();
        }
        int row20 = 0;

        private void txtbillid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataTable tblmagmou3a = new DataTable();
                tblmagmou3a.Clear();
                tblmagmou3a = db.readdata("select*from magmou3at where magmou3a_id=" + txtbillid.Text.Trim() + "", "");
                txtorderid.Text = tblmagmou3a.Rows[row20][0].ToString();
                dgv.Rows.Clear();
                if (tblmagmou3a.Rows.Count > 0)
                {
                    foreach (DataRow row in tblmagmou3a.Rows)
                    {
                        dgv.Rows.Add(1);

                        int rowindex = dgv.Rows.Count - 1;

                        dgv.Rows[rowindex].Cells[0].Value = row[0];
                        dgv.Rows[rowindex].Cells[1].Value = row[3];
                        dgv.Rows[rowindex].Cells[2].Value = row[4];
                        dgv.Rows[rowindex].Cells[3].Value = row[5];
                        dgv.Rows[rowindex].Cells[4].Value = row[6];
                        dgv.Rows[rowindex].Cells[5].Value = row[2];
                        dgv.Rows[rowindex].Cells[6].Value = row[1];



                    }
                }


            }

        }

        private void txtfrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtto.Focus();
            }
        }

        private void txtto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btndown_Click(null,null);
                txtfrom.Focus();
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            panelupdate.Visible = true;
            tileItem1.Enabled = false;
            tileItem3.Enabled = false;
            simpleButton1.Enabled = false;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                //db.excutedata("delete from magmou3at where magmo3a_id="+cbxmagmou3asearch.SelectedValue+","");
                db.excutedata("delete from  magmou3at where magmo3a_id=" + cbxmagmou3asearch.SelectedValue + "", "");

                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into magmou3at values(" + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[5].Value + "',N'" + dgv.Rows[i].Cells[1].Value + "'," + dgv.Rows[i].Cells[2].Value + "," + dgv.Rows[i].Cells[3].Value + ",N'" + dgv.Rows[i].Cells[4].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',"+cbxmagmou3aname.SelectedValue+",N'"+cbxmagmou3aname.Text+"')", "");

                }
                MessageBox.Show("تم حفظ البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            autonumber();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            panelupdate.Visible = true;
            tileItem1.Enabled = false;
            tileItem2.Enabled = false;
            btnupdate.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متاكد من المسح","تاكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                db.excutedata("delete from magmou3at where magmo3a_id="+cbxmagmou3asearch.SelectedValue+"", "تم المسح بنجاح");
                DataTable tblmagmou3a = new DataTable();
                tblmagmou3a.Clear();
                tblmagmou3a = db.readdata("select*from magmou3at where magmou3a_id=" + txtbillid.Text.Trim() + "", "");
                dgv.Rows.Clear();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            add_magou3a frm = new add_magou3a();
            frm.ShowDialog();
        }

        private void cbxmagmou3asearch_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable tblmagmou3a = new DataTable();
            tblmagmou3a.Clear();
            tblmagmou3a = db.readdata("select*from magmou3at where  marhala_id=" + cbxmarhalasearch.SelectedValue + " and magmo3a_id=" + cbxmagmou3asearch.SelectedValue + "  ", "");
            if (tblmagmou3a.Rows.Count >= 1)
            {


                txtorderid.Text = tblmagmou3a.Rows[row20][0].ToString();
                txtbillid.Text = tblmagmou3a.Rows[row20][0].ToString();

                dgv.Rows.Clear();
                if (tblmagmou3a.Rows.Count > 0)
                {
                    foreach (DataRow row in tblmagmou3a.Rows)
                    {
                        dgv.Rows.Add(1);

                        int rowindex = dgv.Rows.Count - 1;

                        dgv.Rows[rowindex].Cells[0].Value = row[0];
                        dgv.Rows[rowindex].Cells[1].Value = row[3];
                        dgv.Rows[rowindex].Cells[2].Value = row[4];
                        dgv.Rows[rowindex].Cells[3].Value = row[5];
                        dgv.Rows[rowindex].Cells[4].Value = row[6];
                        dgv.Rows[rowindex].Cells[5].Value = row[2];
                        dgv.Rows[rowindex].Cells[6].Value = row[1];
                        dgv.Rows[rowindex].Cells[7].Value = row[10];



                    }
                }
            }
            else
            {
                MessageBox.Show("لايوجد بينات اي مجموعه حاليا للبحث المحدد", "خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }
    }
}
    
    
