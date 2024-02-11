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
    public partial class student_data : DevExpress.XtraEditors.XtraForm
    {
        public student_data()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void autonumber()
        {
            tbl.Clear();
            tbl = db.readdata("select max(student_id)from student_data ", "");
            if (tbl.Rows[0][0].ToString() == DBNull.Value.ToString())
            {
                txtstu_id.Text = "1";
            }
            else
            {
                txtstu_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            dgvdata.Rows.Clear();
            txtstu_name.Clear();
            txtsearch.Clear();
            txtaddress.Clear();
            txtstu_phone.Clear();
            txtfatherphone.Clear();
            txtstudentcode.Clear();
        }
        private void fillcbx()
        {
            cbxmarhalaname.DataSource = db.readdata("select*from groups ", "");
            cbxmarhalaname.DisplayMember = "group_name";
            cbxmarhalaname.ValueMember = "group_id";

            cbxstudents.DataSource = db.readdata("select*from student_data", "");
            cbxstudents.DisplayMember = "student_name";
            cbxstudents.ValueMember = "student_id";


            cbxmagmou3a.DataSource = db.readdata("select*from magmou3at_data ", "");
            cbxmagmou3a.DisplayMember = "magmou3a_name";
            cbxmagmou3a.ValueMember = "magmou3a_id";
        }
        private void cbxmarhalaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select magmou3a_day as 'اليوم',time_from as'من',time_to as'الي'  from magmou3at where marhala_id=" + cbxmarhalaname.SelectedValue + "", "");
            dgv.DataSource = tbl;
        }



        int row = 0;
        private void show()
        {

            tbl = db.readdata("select*from student_data", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    txtstu_id.Text = tbl.Rows[row][0].ToString();
                    txtstu_name.Text = tbl.Rows[row][1].ToString();
                    cbxmarhalaname.SelectedValue = Convert.ToDecimal(tbl.Rows[row][2]);
                    txtstudentcode.Text = tbl.Rows[row][10].ToString();

                    if (Convert.ToInt32(tbl.Rows[0][5]) == 1)
                    {
                        checkactivation.Checked = true;
                    }
                    else if (Convert.ToInt32(tbl.Rows[0][5]) == 0)
                    {
                        checkactivation.Checked = false;

                    }
                    txtstu_phone.Text = Convert.ToString(tbl.Rows[row][6]);
                    txtfatherphone.Text = Convert.ToString(tbl.Rows[row][7]);
                    txtaddress.Text = Convert.ToString(tbl.Rows[row][8]);

                    txtnotes.Text = tbl.Rows[row][9].ToString();


                    cbxmagmou3a.SelectedValue = tbl.Rows[row][11].ToString();


                    DataTable tblmagmou3a = new DataTable();
                    tblmagmou3a.Clear();
                    tblmagmou3a = db.readdata("select*from student_magmou3a where student_id=" + txtstu_id.Text.Trim() + "", "");
                    dgvdata.Rows.Clear();
                    if (tblmagmou3a.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblmagmou3a.Rows)
                        {
                            dgvdata.Rows.Add(1);
                            int rowindex = dgvdata.Rows.Count - 1;
                            dgvdata.Rows[rowindex].Cells[0].Value = row[4];
                            dgvdata.Rows[rowindex].Cells[1].Value = row[5];
                            dgvdata.Rows[rowindex].Cells[2].Value = row[6];

                        }





                    }
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',activation as'نشط ام لا',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',address as'العنوان',notes as'ملاحظات',date as'تاريخ الحجز',student_id as'رقم الطالب' from student_data where student_id = N'" + txtstu_id.Text.Trim() + "'", "");
                    dgv.DataSource = tblsearch;
                }
                catch (Exception) { }
            }







        }
        private void student_data_Load(object sender, EventArgs e)
        {
            autonumber();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            fillcbx();

        }

        private void btndown_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(1);

            int rowindex1 = dgvdata.Rows.Count - 1;

            dgvdata.Rows[rowindex1].Cells[0].Value = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            dgvdata.Rows[rowindex1].Cells[1].Value = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            dgvdata.Rows[rowindex1].Cells[2].Value = Convert.ToString(dgv.CurrentRow.Cells[2].Value);


        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            //كود جديد
            DataTable tblcode = new DataTable();
            tblcode = db.readdata("select*from student_data where student_code=N'" + txtstudentcode.Text.Trim() + "'", "");
            if (tblcode.Rows.Count >= 1)
            {
                MessageBox.Show("هناك طالب مسجل بهذا الكود من قبل", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtstudentcode.Text == "" && txtstu_id.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كود الطالب  ورقم الطالب اولاااااا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxmagmou3a.Text == "")
            {
                MessageBox.Show("من فضلك حدد اسم المجموعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbl.Clear();
            tbl = db.readdata("select*from student_data where student_id=" + txtstu_id.Text.Trim() + " ", "");
            if (tbl.Rows.Count >= 1)
            {
                MessageBox.Show("يوجد طالب له نفس الكود المكتوب حاليا غير هذا الكود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (checkactivation.Checked == false)
            {
                if (MessageBox.Show("انت متاكد ان هذا الطالب غير نشط او قام بترك الدرس؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
            }
            if (txtstu_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtstu_phone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم تليفون الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtfatherphone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل رقم تليفون ولي امر الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("من فضلك ادخلمواعيد الطالب او مجموعته اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                int activation = 1;
                if (checkactivation.Checked == true)
                {
                    activation = 1;
                }
                else if (checkactivation.Checked == false)
                {
                    activation = 0;
                }
                //ادخال مجموعات الطالب

                for (int i = 0; i <= dgvdata.Rows.Count - 1; i++)
                {
                    db.excutedata("insert into student_magmou3a values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + dgvdata.Rows[i].Cells[0].Value + "',N'" + dgvdata.Rows[i].Cells[1].Value + "',N'" + dgvdata.Rows[i].Cells[2].Value + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
                }
                //ادخال بيانات الطلاب
                db.excutedata("insert into student_data values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + d + "'," + activation + "," + txtstu_phone.Text.Trim() + "," + txtfatherphone.Text.Trim() + ",N'" + txtaddress.Text.Trim() + "',N'" + txtnotes.Text.Trim() + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");

                db.excutedata("insert into absentesonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'غياب',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
                db.excutedata("insert into attendansonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'حضور',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");

                db.excutedata("insert into student_madfou3aat values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text + "',N'" + d + "',0,0,0,0,0,0,0,0,0,0,0,0," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text + "',N'" + txtstudentcode.Text.Trim() + "')", "تم حفظ بيانات الطالب بنجاح");
                autonumber();
                fillcbx();
            }
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            autonumber();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select student_code as'كود الطالب', student_id as'رقم الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',activation as'نشط ام لا',magmo3a_name as'المجموعه',date as'تاريخ الحجز' from student_data where student_name like N'%" + txtsearch.Text.Trim() + "%'", "");
            dgv.DataSource = tbl;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            DataTable tblshow = new DataTable();
            tblshow.Clear();
            tblshow = db.readdata("select count(student_id)from student_data", "");
            row = Convert.ToInt32(tblshow.Rows[0][0]) - 1;
            show();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(student_id)from student_data", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readdata("select count(student_id)from student_data", "");
            if (row == 0)
            {
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();

            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void txtparcodesearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbl.Clear();
                tbl = db.readdata("select*from student_data where student_code=N'" + txtparcodesearch.Text + "'", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        txtstu_id.Text = tbl.Rows[row][0].ToString();
                        txtstu_name.Text = tbl.Rows[row][1].ToString();
                        txtstudentcode.Text = tbl.Rows[row][10].ToString();

                        cbxmarhalaname.SelectedValue = Convert.ToDecimal(tbl.Rows[row][2]);

                        if (Convert.ToInt32(tbl.Rows[0][5]) == 1)
                        {
                            checkactivation.Checked = true;
                        }
                        else if (Convert.ToInt32(tbl.Rows[0][5]) == 0)
                        {
                            checkactivation.Checked = false;

                        }
                        txtstu_phone.Text = Convert.ToString(tbl.Rows[row][6]);
                        txtfatherphone.Text = Convert.ToString(tbl.Rows[row][7]);
                        txtaddress.Text = Convert.ToString(tbl.Rows[row][8]);

                        txtnotes.Text = tbl.Rows[row][9].ToString();


                        cbxmagmou3a.SelectedValue = tbl.Rows[row][11].ToString();




                        DataTable tblmagmou3a = new DataTable();
                        tblmagmou3a.Clear();
                        tblmagmou3a = db.readdata("select*from student_magmou3a where student_code=N'" + txtparcodesearch.Text.Trim() + "'", "");
                        dgvdata.Rows.Clear();
                        if (tblmagmou3a.Rows.Count > 0)
                        {
                            foreach (DataRow row in tblmagmou3a.Rows)
                            {
                                dgvdata.Rows.Add(1);
                                int rowindex = dgvdata.Rows.Count - 1;
                                dgvdata.Rows[rowindex].Cells[0].Value = row[4];
                                dgvdata.Rows[rowindex].Cells[1].Value = row[5];
                                dgvdata.Rows[rowindex].Cells[2].Value = row[6];

                            }





                        }
                        txtparcodesearch.Clear();
                        DataTable tblsearch = new DataTable();
                        tblsearch.Clear();
                        tblsearch = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',activation as'نشط ام لا',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',address as'العنوان',notes as'ملاحظات',date as'تاريخ الحجز',student_id as'رقم الطالب' from student_data where student_id = " + txtstu_id.Text + "", "");
                        dgv.DataSource = tblsearch;
                    }
                    catch (Exception) { }
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count >= 1)
            {
                dgvdata.Rows.RemoveAt(dgvdata.CurrentCell.RowIndex);
            }
        }

        private void cbxstudents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl = db.readdata("select*from student_data where student_id=" + cbxstudents.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات  لهذه الشاشه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    txtstu_id.Text = tbl.Rows[row][0].ToString();
                    txtstu_name.Text = tbl.Rows[row][1].ToString();
                    txtstudentcode.Text = tbl.Rows[row][10].ToString();

                    cbxmarhalaname.SelectedValue = Convert.ToDecimal(tbl.Rows[row][2]);

                    if (Convert.ToInt32(tbl.Rows[0][5]) == 1)
                    {
                        checkactivation.Checked = true;
                    }
                    else if (Convert.ToInt32(tbl.Rows[0][5]) == 0)
                    {
                        checkactivation.Checked = false;

                    }
                    txtstu_phone.Text = Convert.ToString(tbl.Rows[row][6]);
                    txtfatherphone.Text = Convert.ToString(tbl.Rows[row][7]);
                    txtaddress.Text = Convert.ToString(tbl.Rows[row][8]);

                    txtnotes.Text = tbl.Rows[row][9].ToString();

                    cbxmagmou3a.SelectedValue = tbl.Rows[row][11].ToString();




                    DataTable tblmagmou3a = new DataTable();
                    tblmagmou3a.Clear();
                    tblmagmou3a = db.readdata("select*from student_magmou3a where student_id=" + cbxstudents.SelectedValue + "", "");
                    dgvdata.Rows.Clear();
                    if (tblmagmou3a.Rows.Count > 0)
                    {
                        foreach (DataRow row in tblmagmou3a.Rows)
                        {
                            dgvdata.Rows.Add(1);
                            int rowindex = dgvdata.Rows.Count - 1;
                            dgvdata.Rows[rowindex].Cells[0].Value = row[4];
                            dgvdata.Rows[rowindex].Cells[1].Value = row[5];
                            dgvdata.Rows[rowindex].Cells[2].Value = row[6];

                        }





                    }
                    txtparcodesearch.Clear();
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',activation as'نشط ام لا',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',address as'العنوان',notes as'ملاحظات',date as'تاريخ الحجز',student_id as'رقم الطالب' from student_data where student_id = " + cbxstudents.SelectedValue + "", "");
                    dgv.DataSource = tblsearch;
                }
                catch (Exception) { }
            }

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            //db.excutedata("delete from student_data where student_id="+txtstu_id.Text.Trim()+"", "");
            //db.excutedata("delete from absentesonly where student_id=" + txtstu_id.Text.Trim() + "", "");
            panel1.Visible = true;
            //db.excutedata("delete from student_magmou3a where student_id="+txtstu_id.Text.Trim()+"", "");
            //DataTable tblcheckuser = new DataTable();
            //tblcheckuser.Clear();
            //tblcheckuser = db.readdata("select*from addnew_users where type=N'مدير' and user_name=N'"+txtuser.Text.Trim()+"' and user_password=N"+txtpassword.Text.Trim()+"'", "");
            //if(tbl)
            //if (checkactivation.Checked == false)
            //{
            //    if (MessageBox.Show("انت متاكد ان هذا الطالب غير نشط او قام بترك الدرس؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            //if (txtstudentcode.Text == "" && txtstu_id.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل كود الطالب  ورقم الطالب اولاااااا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txtstu_name.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل اسم الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else if (txtaddress.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل عنوان الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else if (txtstu_phone.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل رقم تليفون الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else if (txtfatherphone.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل رقم تليفون ولي امر الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //else if (dgvdata.Rows.Count < 1)
            //{
            //    MessageBox.Show("من فضلك ادخلمواعيد الطالب او مجموعته اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txtstudentcode.Text == "")
            //{
            //    MessageBox.Show("من فضلك ادخل كود الطالب اولا", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    db.excutedata("delete from student_data where student_id=" + txtstu_id.Text.Trim() + "", "");
            //    db.excutedata("delete from absentesonly where student_id=" + txtstu_id.Text.Trim() + "", "");
            //    db.excutedata("delete from attendansonly where student_id=" + txtstu_id.Text.Trim() + "", "");

            //    db.excutedata("delete from student_magmou3a where student_id=" + txtstu_id.Text.Trim() + "", "");
            //    string d = dtpdate.Value.ToString("yyyy-MM-dd");
            //    int activation = 1;
            //    if (checkactivation.Checked == true)
            //    {
            //        activation = 1;
            //    }
            //    else if (checkactivation.Checked == false)
            //    {
            //        activation = 0;
            //    }
            //    //ادخال مجموعات الطالب

            //    for (int i = 0; i <= dgvdata.Rows.Count - 1; i++)
            //    {
            //        db.excutedata("insert into student_magmou3a values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + dgvdata.Rows[i].Cells[0].Value + "',N'" + dgvdata.Rows[i].Cells[1].Value + "',N'" + dgvdata.Rows[i].Cells[2].Value + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
            //    }
            //    //ادخال بيانات الطلاب
            //    db.excutedata("insert into student_data values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + d + "'," + activation + "," + txtstu_phone.Text.Trim() + "," + txtfatherphone.Text.Trim() + ",N'" + txtaddress.Text.Trim() + "',N'" + txtnotes.Text.Trim() + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "تم حفظ بيانات الطالب بنجاح");
            //    db.excutedata("insert into attendansonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'حضور',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");

            //    db.excutedata("insert into absentesonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'غياب',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
            //    db.excutedata("update madfou3aat_details set activation="+activation+" where student_id="+txtstu_id.Text.Trim()+" ", "");
            //    autonumber();
            //    fillcbx();
            //}
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            paneldeletestudent.Visible = true;
            //if (MessageBox.Show("هل انت متاكد من مسح هذا الطالب ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    db.excutedata("delete from student_data where student_id=" + txtstu_id.Text.Trim() + "", "");
            //    db.excutedata("delete from absentesonly where student_id=" + txtstu_id.Text.Trim() + "", "");

            //    db.excutedata("delete from student_magmou3a where student_id=" + txtstu_id.Text.Trim() + "", "تم مسح هذا الطالب");

            //}
            //autonumber();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtparcodesearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbxstudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxmagmou3a_SelectionChangeCommitted(object sender, EventArgs e)
        {





            tbl.Clear();
            tbl = db.readdata("select magmou3a_day as 'اليوم',time_from as'من',time_to as'الي'  from magmou3at where marhala_id=" + cbxmarhalaname.SelectedValue + " and magmo3a_id=" + cbxmagmou3a.SelectedValue + "", "");
            dgv.DataSource = tbl;


            DataTable tblmagmou3a = new DataTable();
            tblmagmou3a.Clear();
            tblmagmou3a = db.readdata("select*from magmou3at where magmo3a_id=" + cbxmagmou3a.SelectedValue + " and marhala_id=" + cbxmarhalaname.SelectedValue + " ", "");
            dgvdata.Rows.Clear();
            if (tblmagmou3a.Rows.Count > 0)
            {
                foreach (DataRow row in tblmagmou3a.Rows)
                {
                    dgvdata.Rows.Add(1);
                    int rowindex = dgvdata.Rows.Count - 1;
                    dgvdata.Rows[rowindex].Cells[0].Value = row[3];
                    dgvdata.Rows[rowindex].Cells[1].Value = row[4];
                    dgvdata.Rows[rowindex].Cells[2].Value = row[5];

                }

            }
        }

        private void txtparcodesearch_FontChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            DataTable tblcheckuser = new DataTable();
            tblcheckuser.Clear();
            tblcheckuser = db.readdata("select*from addnew_users where type=N'مدير' and user_name=N'" + txtuser.Text.Trim() + "' and user_password=N'" + txtpassword.Text.Trim() + "'", "");
            if (tblcheckuser.Rows.Count >= 1)
            {
                if (Convert.ToString(tblcheckuser.Rows[0][1]) == txtuser.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][2]) == txtpassword.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][3]) == "مدير")
                {


                    if (checkactivation.Checked == false)
                    {
                        if (MessageBox.Show("انت متاكد ان هذا الطالب غير نشط او قام بترك الدرس؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        {
                            return;
                        }
                    }
                    if (txtstudentcode.Text == "" && txtstu_id.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل كود الطالب  ورقم الطالب اولاااااا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtstu_name.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل اسم الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (txtaddress.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل عنوان الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (txtstu_phone.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل رقم تليفون الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (txtfatherphone.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل رقم تليفون ولي امر الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (dgvdata.Rows.Count < 1)
                    {
                        MessageBox.Show("من فضلك ادخلمواعيد الطالب او مجموعته اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txtstudentcode.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل كود الطالب اولا", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        db.excutedata("delete from student_data where student_id=" + txtstu_id.Text.Trim() + "", "");
                        db.excutedata("delete from absentesonly where student_id=" + txtstu_id.Text.Trim() + "", "");
                        db.excutedata("delete from attendansonly where student_id=" + txtstu_id.Text.Trim() + "", "");

                        db.excutedata("delete from student_magmou3a where student_id=" + txtstu_id.Text.Trim() + "", "");
                        string d = dtpdate.Value.ToString("yyyy-MM-dd");
                        int activation = 1;
                        if (checkactivation.Checked == true)
                        {
                            activation = 1;
                        }
                        else if (checkactivation.Checked == false)
                        {
                            activation = 0;
                        }
                        //ادخال مجموعات الطالب

                        for (int i = 0; i <= dgvdata.Rows.Count - 1; i++)
                        {
                            db.excutedata("insert into student_magmou3a values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + dgvdata.Rows[i].Cells[0].Value + "',N'" + dgvdata.Rows[i].Cells[1].Value + "',N'" + dgvdata.Rows[i].Cells[2].Value + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
                        }
                        //ادخال بيانات الطلاب
                        db.excutedata("insert into student_data values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "'," + cbxmarhalaname.SelectedValue + ",N'" + cbxmarhalaname.Text.Trim() + "',N'" + d + "'," + activation + "," + txtstu_phone.Text.Trim() + "," + txtfatherphone.Text.Trim() + ",N'" + txtaddress.Text.Trim() + "',N'" + txtnotes.Text.Trim() + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "تم حفظ بيانات الطالب بنجاح");
                        db.excutedata("insert into attendansonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'حضور',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");

                        db.excutedata("insert into absentesonly values(" + txtstu_id.Text.Trim() + ",N'" + txtstu_name.Text.Trim() + "',N'غياب',N'" + d + "',N'" + cbxmarhalaname.Text + "',N'" + cbxmarhalaname.SelectedValue + "',N'" + txtstudentcode.Text.Trim() + "'," + cbxmagmou3a.SelectedValue + ",N'" + cbxmagmou3a.Text + "')", "");
                        db.excutedata("update madfou3aat_details set activation=" + activation + " where student_id=" + txtstu_id.Text.Trim() + " ", "");
                        autonumber();
                        fillcbx();
                        panel1.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("انت لست لك الصلاحيه للتعديل علي بيانات الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("بيانات المستخدم خطا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }

        private void btnclose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnclosedelete_Click(object sender, EventArgs e)
        {
            paneldeletestudent.Visible = false;
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            DataTable tblcheckuser = new DataTable();
            tblcheckuser.Clear();
            tblcheckuser = db.readdata("select*from addnew_users where type=N'مدير' and user_name=N'" + txtuser_delete.Text.Trim() + "' and user_password=N'" + txtpassword_delete.Text.Trim() + "'", "");
            if (tblcheckuser.Rows.Count >= 1)
            {
                if (Convert.ToString(tblcheckuser.Rows[0][1]) == txtuser_delete.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][2]) == txtpassword_delete.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][3]) == "مدير")
                {

                    if (MessageBox.Show("هل انت متاكد من مسح هذا الطالب ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        db.excutedata("delete from student_data where student_id=" + txtstu_id.Text.Trim() + "", "");
                        db.excutedata("delete from absentesonly where student_id=" + txtstu_id.Text.Trim() + "", "");

                        db.excutedata("delete from student_magmou3a where student_id=" + txtstu_id.Text.Trim() + "", "تم مسح هذا الطالب");

                    }
                    autonumber();
                    paneldeletestudent.Visible = false;
                }
                else
                {
                    MessageBox.Show("انت لست لك الصلاحيه لمسح  بيانات الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("بيانات المستخدم خطا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
    }
           
    
