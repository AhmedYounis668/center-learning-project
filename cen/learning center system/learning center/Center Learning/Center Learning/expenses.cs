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
    public partial class expenses : DevExpress.XtraEditors.XtraForm
    {
        public expenses()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();


        private void autonumber()
        {
            tbl.Clear();
            tbl = db.readdata("select*from sandat_id", "");
            if (tbl.Rows.Count < 1)
            {
                db.excutedata("insert into sandat_id values(1000000)", "");
            }
            else if (tbl.Rows.Count >= 1)
            {
                db.excutedata("update sandat_id set sand_id=sand_id+1", "");
            }
            DataTable tblorder_id = new DataTable();
            tblorder_id.Clear();
            tblorder_id = db.readdata("select*from sandat_id", "");
            txtorder_id.Text = Convert.ToString(tblorder_id.Rows[0][0]);

        }

        private void total()
        {
            decimal total = 0;
            for (int i = 0; i <= dgv.Rows.Count - 1; i++)
            {
                total += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);

            }
            txttotal.Text = total.ToString();
        }

        int stoke_id = Convert.ToInt32(Properties.Settings.Default.stoke_id);
        private void fillcbx()
        {
            cbxdeserved_type.DataSource = db.readdata("select*from deserved_type ", "");
            cbxdeserved_type.DisplayMember = "type_name";
            cbxdeserved_type.ValueMember = "type_id";
        }


        private void tileitem11_ItemClick(object sender, TileItemEventArgs e)
        {

            string d = dtpdate.Value.ToString("yyyy-MM-dd");
            if (Convert.ToDecimal(lblbalancenow.Text) < Convert.ToDecimal(txttotal.Text))
            {
                MessageBox.Show("من فضلك تاكد من المبلغ الموجود في الخزنه اولا المبلغ المنصرف اكبر من المبلغ الموجود في الخزنه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           if(Convert.ToDecimal(txttotal.Text)>Convert.ToDecimal(lblbalancenow.Text))
            {
                MessageBox.Show("من فضلك راجع بياناتك اجمالي المبلغ المنصرف اكبر من المبلغ الموجود في الخزنه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                if (dgv.Rows.Count >= 1)
                {
                    for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                    {

                        db.excutedata("insert into deserved values(" + dgv.Rows[i].Cells[0].Value + "," + dgv.Rows[i].Cells[1].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "'," + dgv.Rows[i].Cells[4].Value + ",N'" + dgv.Rows[i].Cells[3].Value + "',N'" + d + "',N'" + Properties.Settings.Default.user_name + "')", "");

                        db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name)values(" + stoke_id + "," + dgv.Rows[i].Cells[4].Value + ",N'" + d + "',N'عمليه صرف رقم'+N' '+N'" + dgv.Rows[i].Cells[0].Value + "',N'مصروفات يوميه ..سحب مباشر من الخزنه',N'" + dgv.Rows[i].Cells[3].Value + "',N'" + Properties.Settings.Default.user_name + "')", "");
                    }
                    db.excutedata("update stoke_money set money=money-" + txttotal.Text + " where stoke_id=" + stoke_id + "", "");

                }

                autonumber2();
                autonumber();
                MessageBox.Show("تم الادخال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void autonumber2()
        {
            dgv.Rows.Clear();
            numircprice.Value = 0;
            txtnotes.Clear();
            txttotal.Text = "0";
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);

        }
        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber2();
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

            try
            {
                if (dgv.Rows.Count >= 1)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);


                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;

                }
                total();
                if (dgv.Rows.Count < 1)
                {
                    txttotal.Text = "0";
                }

            }
            catch (Exception) { }
        }

        private void expenses_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            autonumber();
            tbl.Clear();
            tbl = db.readdata("select*from stoke_money where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
            lblbalancenow.Text = Convert.ToString(tbl.Rows[0][1]);
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if (numircprice.Value == 0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxdeserved_type.Text == "")
            {
                MessageBox.Show("من فضلك حدد التاريخ اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Convert.ToDecimal(lblbalancenow.Text) == 0)
            {
                MessageBox.Show("من فضلك تاكد من انه يوجد رصيد في الخزنه اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                int order_id = Convert.ToInt32(txtorder_id.Text);
                int expense_id = Convert.ToInt32(cbxdeserved_type.SelectedValue);
                string expense_name = cbxdeserved_type.Text;
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string notes = txtnotes.Text;
                decimal money = numircprice.Value;








                dgv.Rows.Add(1);
                int rowindex = dgv.Rows.Count - 1;

                dgv.Rows[rowindex].Cells[0].Value = order_id;
                dgv.Rows[rowindex].Cells[1].Value = expense_id;
                dgv.Rows[rowindex].Cells[2].Value = expense_name;
                dgv.Rows[rowindex].Cells[3].Value = notes;
                dgv.Rows[rowindex].Cells[4].Value = money;

                dgv.Rows[rowindex].Cells[5].Value = d;

                dgv.Rows[rowindex].Cells[6].Value = dgv.Rows.Count;
                autonumber();
                total();
            }
            }
    }
    }