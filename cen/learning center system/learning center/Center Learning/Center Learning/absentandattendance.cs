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
    public partial class absentandattendance : DevExpress.XtraEditors.XtraForm
    {
        public absentandattendance()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxmarhalaname.DataSource = db.readdata("select*from groups", "");
            cbxmarhalaname.DisplayMember = "group_name";
            cbxmarhalaname.ValueMember = "group_id";



            cbxmagmou3a.DataSource = db.readdata("select*from magmou3at_data ", "");
            cbxmagmou3a.DisplayMember = "magmou3a_name";
            cbxmagmou3a.ValueMember = "magmou3a_id";
        }

        private void autonumber()
        {
            //tbl = db.readdata("select max(order_id)from attendans ", "");
            //if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            //{
            //    txtorder_id.Text = "1";
            //}
            //else
            //{
            //    txtorder_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            //}
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

            txtnotes.Clear();
            radiosearchwithstudentname.Checked = false;
            searchwithstudent_id.Checked = false;
            cbxmarhalaname.Text = "اختر مرحله";
            txtsearch.Clear();
            dgv.Rows.Clear();
        }
            private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void absentandattendance_Load(object sender, EventArgs e)
        {
            dtpdate.Text = DateTime.Now.ToShortDateString();
            dtptime.Text = DateTime.Now.ToShortTimeString();
            fillcbx();
            autonumber();
           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(radiosearchwithstudentname.Checked==true)
            {
                tbl.Clear();
               tbl= db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',student_id as'رقم الطالب' from student_data where student_name like N'%"+txtsearch.Text.Trim()+"%' and activation=1 and marhal_id="+cbxmarhalaname.SelectedValue+"", "");
                dgvstudents.DataSource = tbl;
            }
            else if(searchwithstudent_id.Checked==true)
            {
                tbl.Clear();
                tbl=db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',student_id as'رفم الطالب' from student_data where student_code= N'" + txtsearch.Text.Trim() + "' and activation=1 and marhal_id="+cbxmarhalaname.SelectedValue+"", "");
                dgvstudents.DataSource = tbl;
            }
            else if(radiosearchwithstudentname.Checked==false&&searchwithstudent_id.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه البحث اولا هتبحث بكود الطالب ولا باسمه ؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if(cbxmarhalaname.Text=="اختر مرحله")
            {
                MessageBox.Show("من فضلك اختر المرحله الدراسيه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbxmagmou3a.Text=="")
            {
                MessageBox.Show("من فضلك حدد اسم المجموعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(dgvstudents.Rows.Count>=1)
            {
                DataTable tblitems = new DataTable();
                tblitems.Clear();
               
               

                    string student_code = Convert.ToString(dgvstudents.CurrentRow.Cells[0].Value);
                string student_id = Convert.ToString(dgvstudents.CurrentRow.Cells[3].Value);

                string student_name = Convert.ToString(dgvstudents.CurrentRow.Cells[1].Value);


                string marhala_name = cbxmarhalaname.Text;
                string date = dtpdate.Value.ToString("yyyy-MM-dd");
                string state = "حضور";
                int marhala_id = Convert.ToInt32(cbxmarhalaname.SelectedValue);


                  

                

                    //====================================================================
                    dgv.Rows.Add(1);

                    int rowindex = dgv.Rows.Count - 1;



                    dgv.Rows[rowindex].Cells[0].Value = student_code;
                    dgv.Rows[rowindex].Cells[1].Value = student_name;
                    dgv.Rows[rowindex].Cells[2].Value =marhala_name ;

                    dgv.Rows[rowindex].Cells[3].Value = date;
                    dgv.Rows[rowindex].Cells[5].Value =state;
                    dgv.Rows[rowindex].Cells[6].Value = marhala_id;
                dgv.Rows[rowindex].Cells[7].Value = student_id;


                dgv.ClearSelection();
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;

                if (dgv.Rows.Count >= 1)
                {
                    lblstudentcount.Text = Convert.ToString(dgv.Rows.Count);
                }
                else if(dgv.Rows.Count<1)
                {
                    lblstudentcount.Text = "0";
                }
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (cbxmarhalaname.Text == "اختر مرحله")
            {
                MessageBox.Show("من فضلك اختر المرحله الدراسيه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvstudents.Rows.Count >= 1)
            {
                DataTable tblitems = new DataTable();
                tblitems.Clear();



                string student_code = Convert.ToString(dgvstudents.CurrentRow.Cells[0].Value);
                string student_id = Convert.ToString(dgvstudents.CurrentRow.Cells[3].Value);

                string student_name = Convert.ToString(dgvstudents.CurrentRow.Cells[1].Value);


                string marhala_name = cbxmarhalaname.Text;
                string date = dtpdate.Value.ToString("yyyy-MM-dd");
                string state = "غياب";
                int marhala_id = Convert.ToInt32(cbxmarhalaname.SelectedValue);






                //====================================================================
                dgv.Rows.Add(1);

                int rowindex = dgv.Rows.Count - 1;



                dgv.Rows[rowindex].Cells[0].Value = student_code;

                dgv.Rows[rowindex].Cells[1].Value = student_name;
                dgv.Rows[rowindex].Cells[2].Value = marhala_name;

                dgv.Rows[rowindex].Cells[3].Value = date;
                dgv.Rows[rowindex].Cells[5].Value = state;
                dgv.Rows[rowindex].Cells[6].Value = marhala_id;
                dgv.Rows[rowindex].Cells[7].Value = student_id;


                dgv.ClearSelection();
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;

                if (dgv.Rows.Count >= 1)
                {
                    lblstudentcount.Text = Convert.ToString(dgv.Rows.Count);
                }
                else if (dgv.Rows.Count < 1)
                {
                    lblstudentcount.Text = "0";
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                try
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);



                    dgv.ClearSelection();
                    dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                    dgv.Rows[dgv.Rows.Count - 1].Selected = true;

                    if (dgv.Rows.Count >= 1)
                    {
                        lblstudentcount.Text = Convert.ToString(dgv.Rows.Count);
                    }
                    else if (dgv.Rows.Count < 1)
                    {
                        lblstudentcount.Text = "0";
                    }
                }
                catch (Exception) { }
                }
           
            
            }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            string d = dtpdate.Value.ToString("yyyy-MM-dd");
            string t = dtptime.Value.ToString("HH:MM");
            if (dgv.Rows.Count >= 1)
            {
                for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                {
                    //ادخال بيانات حضور الطالب او غيابه
                    db.excutedata("insert into attendans values(" + txtorder_id.Text + "," + dgv.Rows[i].Cells[7].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "',N'" + d + "',N'" + t + "',N'" + dgv.Rows[i].Cells[4].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + dgv.Rows[i].Cells[5].Value + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'"+ dgv.Rows[i].Cells[0].Value + "',"+cbxmagmou3a.SelectedValue+",N'"+cbxmagmou3a.Text+"')", "");

                    //حساب الطالب
                    string description = "قام الطالب بال" + dgv.Rows[i].Cells[5].Value;
                    db.excutedata("insert into student_account values("+txtorder_id.Text+","+dgv.Rows[i].Cells[7].Value+",N'"+ dgv.Rows[i].Cells[1].Value + "',N'"+description+"',N'"+d+"',0,N'"+Properties.Settings.Default.user_name+"',"+ dgv.Rows[i].Cells[6].Value + ",N'"+ dgv.Rows[i].Cells[2].Value + "',N'"+ dgv.Rows[i].Cells[0].Value + "')", "");

                    db.excutedata("update absentesonly set type=N'"+dgv.Rows[i].Cells[5].Value+"' where student_id="+dgv.Rows[i].Cells[7].Value+" and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "");
                    db.excutedata("update attendansonly set type=N'" + dgv.Rows[i].Cells[5].Value + "' where student_id=" + dgv.Rows[i].Cells[7].Value + " and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "");

                }
                string descriptionexplian = "تم تسجيل الحضور للمرحله" + " " + cbxmarhalaname.Text;
                db.excutedata("insert into explain values("+txtorder_id.Text+",N'"+descriptionexplian+"',N'"+d+"')", "");
                MessageBox.Show("تم التسجيل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                autonumber();
            }
        }

        private void txtbillid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int row20 = 0;
            if (e.KeyChar == 13)
            {
                if (txtbillid.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره التي تريد تعديلها ثم قم بالضغط علي زر انتر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                DataTable tblsales = new DataTable();
                tblsales.Clear();
                tblsales = db.readdata("select*from attendans where order_id=" + txtbillid.Text.Trim() + " ", "");
                if (tblsales.Rows.Count < 1)
                {
                    MessageBox.Show("لايوجد فاتوره بهذا الرقم", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                  
                    txtorder_id.Text = tblsales.Rows[row20][0].ToString();

                   
                    //============================================================


               
                    //=========================================================================


                    dgv.Rows.Clear();
                    if (tblsales.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblsales.Rows)
                        {
                            dgv.Rows.Add(1);

                            int rowindex = dgv.Rows.Count - 1;

                            dgv.Rows[rowindex].Cells[0].Value = row[1];
                            dgv.Rows[rowindex].Cells[1].Value = row[2];
                            dgv.Rows[rowindex].Cells[2].Value = row[10];
                            dgv.Rows[rowindex].Cells[3].Value = row[3];
                            dgv.Rows[rowindex].Cells[4].Value = row[5];
                            dgv.Rows[rowindex].Cells[5].Value = row[8];
                            dgv.Rows[rowindex].Cells[6].Value = row[9];



                        }

                    }

                   



                }
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            panelupdate.Visible = true;
            tileItem3.Enabled = false;
            simpleButton8.Enabled = false;
            btnupdate.Enabled = true;

                }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            panelupdate.Visible = false;
            tileItem3.Enabled = true;
            simpleButton8.Enabled = false;

        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            simpleButton8.Enabled = true;
            btnupdate.Enabled = false;
            tileItem3.Enabled = false;
            panelupdate.Visible = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من تعديل البيانات ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.excutedata("delete from attendans where order_id=" + txtorder_id.Text + "", "");

                    db.excutedata("delete from student_account where order_id=" + txtorder_id.Text + "", "");

                    string d = dtpdate.Value.ToString("yyyy-MM-dd");
                    string t = dtptime.Value.ToString("HH:MM");
                    if (dgv.Rows.Count >= 1)
                    {
                        for (int i = 0; i <= dgv.Rows.Count - 1; i++)
                        {
                            //ادخال بيانات حضور الطالب او غيابه
                            db.excutedata("insert into attendans values(" + txtorder_id.Text + "," + dgv.Rows[i].Cells[7].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "',N'" + d + "',N'" + t + "',N'" + dgv.Rows[i].Cells[4].Value + "',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "',N'" + dgv.Rows[i].Cells[5].Value + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'"+ dgv.Rows[i].Cells[0].Value + "',"+cbxmagmou3a.SelectedValue+",N'"+cbxmagmou3a.Text+"')", "");

                            //حساب الطالب
                            string description = "قام الطالب بال" + dgv.Rows[i].Cells[5].Value;
                            db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + dgv.Rows[i].Cells[7].Value + ",N'" + dgv.Rows[i].Cells[1].Value + "',N'" + description + "',N'" + d + "',0,N'" + Properties.Settings.Default.user_name + "'," + dgv.Rows[i].Cells[6].Value + ",N'" + dgv.Rows[i].Cells[2].Value + "',N'"+ dgv.Rows[i].Cells[0].Value + "')", "");
                        }
                        string descriptionexplain = "قام الطالب بالحضور للمرحله"+" "+cbxmarhalaname.Text+" "+"تعديل العمليه";
                        db.excutedata("insert into explain values("+txtorder_id.Text+",N'"+descriptionexplain+"',N'"+d+"')", "");
                        MessageBox.Show("تم التسجيل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autonumber();
                    }
                }
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من حذف البيانات ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.excutedata("delete from attendans where order_id=" + txtorder_id.Text + "", "");

                    db.excutedata("delete from student_account where order_id=" + txtorder_id.Text + "", "تم مسح البيانات");
                }
                autonumber();
            }
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            if(cbxmarhalaname.Text=="اختر مرحله")
            {
                MessageBox.Show("من فضلك اختر مرحله اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل انت متاكد من تسجبل الغائبين تلقائيا للمرحله"+cbxmarhalaname.Text, "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Value.ToString("HH:MM");
                DataTable tblorder_id = new DataTable();
                tblorder_id.Clear();
                tblorder_id = db.readdata("select*from sandat_id", "");
                int order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);
                tbl.Clear();
                tbl = db.readdata("select*from absentesonly where type=N'غياب' and marhala_id=" + cbxmarhalaname.SelectedValue + " and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "");
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into attendans values(" + order_id + "," + tbl.Rows[i][0] + ",N'" + tbl.Rows[i][1] + "',N'" + d + "',N'" + t + "',N'',N'غياب تلقائي',N'" + Properties.Settings.Default.user_name + "',N'" + tbl.Rows[i][2] + "'," + tbl.Rows[i][5] + ",N'" + tbl.Rows[i][4] + "',N'"+ tbl.Rows[i][6] + "',"+cbxmagmou3a.SelectedValue+",N'"+cbxmagmou3a.Text+"')", "");

                    string description = "قام الطالب بالغياب";
                    db.excutedata("insert into student_account values("+order_id+"," + tbl.Rows[i][0] + ",N'" + tbl.Rows[i][1] + "',N'"+description+"',N'"+d+"',0,N'"+Properties.Settings.Default.user_name+"',"+ tbl.Rows[i][5] + ",N'" + tbl.Rows[i][4] +  "',N'"+ tbl.Rows[i][6] + "')", "");
                }
                string descriptionabsent = "تم تسجيل الغياب للمرحله" + " " + cbxmarhalaname.Text;
                db.excutedata("insert into explain values(" + txtorder_id.Text + ",N'" + descriptionabsent + "',N'" + d + "')", "");
                db.excutedata("update absentesonly set type=N'غياب' where marhala_id=" + cbxmarhalaname.SelectedValue + " and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "تم تسجل الطلبه الغائبين تلقائيا");

                autonumber();
            }
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            if (cbxmarhalaname.Text == "اختر مرحله")
            {
                MessageBox.Show("من فضلك اختر مرحله اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل انت متاكد من تسجبل الغائبين تلقائيا للمرحله" + cbxmarhalaname.Text, "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string t = dtptime.Value.ToString("HH:MM");
                DataTable tblorder_id = new DataTable();
                tblorder_id.Clear();
                tblorder_id = db.readdata("select*from sandat_id", "");
                int order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);
                tbl.Clear();
                tbl = db.readdata("select*from attendansonly where type=N'حضور' and marhala_id=" + cbxmarhalaname.SelectedValue + " and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "");
                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into attendans values(" + order_id + "," + tbl.Rows[i][0] + ",N'" + tbl.Rows[i][1] + "',N'" + d + "',N'" + t + "',N'',N'حضور تلقائي',N'" + Properties.Settings.Default.user_name + "',N'" + tbl.Rows[i][2] + "'," + tbl.Rows[i][5] + ",N'" + tbl.Rows[i][4] + "',N'"+ tbl.Rows[i][6] + "',"+cbxmagmou3a.SelectedValue+",N'"+cbxmagmou3a.Text+"')", "");

                    string description = "قام الطالب بالحضور";
                    db.excutedata("insert into student_account values(" + order_id + "," + tbl.Rows[i][0] + ",N'" + tbl.Rows[i][1] + "',N'" + description + "',N'" + d + "',0,N'" + Properties.Settings.Default.user_name + "'," + tbl.Rows[i][5] + ",N'" + tbl.Rows[i][4] + "',N'"+ tbl.Rows[i][6] + "')", "");
                }
                string descriptionattendans = "تم تسجيل الحضور للمرحله" + " " + cbxmarhalaname.Text;
                db.excutedata("insert into explain values(" + txtorder_id.Text + ",N'" + descriptionattendans + "',N'" + d + "')", "");
                db.excutedata("update attendansonly  set type=N'حضور' where marhala_id=" + cbxmarhalaname.SelectedValue + " and magmo3a_id="+cbxmagmou3a.SelectedValue+"", "تم تسجل الطلبه الحاضريين تلقائيا");

                autonumber();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            attendans_reports frm = new attendans_reports();
            frm.ShowDialog();
        }
    }
}