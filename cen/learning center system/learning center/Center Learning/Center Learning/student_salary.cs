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
    public partial class student_salary : DevExpress.XtraEditors.XtraForm
    {
        public student_salary()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            if (radioallstudentinmarhala.Checked == true)
            {
                cbx.DataSource = db.readdata("select*from groups ", "");
                cbx.DisplayMember = "group_name";
                cbx.ValueMember = "group_id";
            }
            else if (radioselectdstudent.Checked == true)
            {
                cbx.DataSource = db.readdata("select*from student_data ", "");
                cbx.DisplayMember = "student_name";
                cbx.ValueMember = "student_id";
            }
        }
        private void student_salary_Load(object sender, EventArgs e)
        {
            cbxmonth.Text = dtp.Value.Month.ToString();

            fillcbx();
            //dtpfrom.Text = DateTime.Now.ToShortDateString();
            //dtpto.Text = DateTime.Now.ToShortDateString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radioallstudentinmarhala.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as 'كود الطالب',student_name as 'اسم الطالب',marhala_name as 'المرحله الدراسيه',date as 'التاريخ',mon_1 as'شهر1',mon_2 as'شهر2',mon_3 as 'شهر3',mon_4 as 'شهر4',mon_5 as 'شهر5',mon_6 as 'شهر6',mon_7 as 'شهر7',mon_8 as 'شهر8',mon_9 as 'شهر9',mon_10 as'شهر10',mon_11 as'شهر 11',mon_12 as 'شهر 12',student_id as 'رقم الطالب' from student_madfou3aat where marhala_id=" + cbx.SelectedValue + "", "");
                dgv.DataSource = tbl;
            }
            else if (radioselectdstudent.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as 'كود الطالب',student_name as 'اسم الطالب',marhala_name as 'المرحله الدراسيه',date as 'التاريخ',mon_1 as'شهر1',mon_2 as'شهر2',mon_3 as 'شهر3',mon_4 as 'شهر4',mon_5 as 'شهر5',mon_6 as 'شهر6',mon_7 as 'شهر7',mon_8 as 'شهر8',mon_9 as 'شهر9',mon_10 as'شهر10',mon_11 as'شهر 11',mon_12 as 'شهر 12',student_id as 'رقم الطالب' from student_madfou3aat where student_id=" + cbx.SelectedValue + "", "");
                dgv.DataSource = tbl;
            }
            else if (radiostudentnameorpart.Checked == true)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select student_code as 'كود الطالب',student_name as 'اسم الطالب',marhala_name as 'المرحله الدراسيه',date as 'التاريخ',mon_1 as'شهر1',mon_2 as'شهر2',mon_3 as 'شهر3',mon_4 as 'شهر4',mon_5 as 'شهر5',mon_6 as 'شهر6',mon_7 as 'شهر7',mon_8 as 'شهر8',mon_9 as 'شهر9',mon_10 as'شهر10',mon_11 as'شهر 11',mon_12 as 'شهر 12',student_id as 'رقم الطالب' from student_madfou3aat where student_name=N'" + txt_write_student.Text.Trim() + "'", "");
                dgv.DataSource = tbl;
            }
            else if (radiosearchwithcode.Checked == true)
            {
                try
                {
                    if (txtsearch.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل كود الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int id = Convert.ToInt32(txtsearch.Text);


                    tbl.Clear();
                    tbl = db.readdata("select student_code as 'كود الطالب',student_name as 'اسم الطالب',marhala_name as 'المرحله الدراسيه',date as 'التاريخ',mon_1 as'شهر1',mon_2 as'شهر2',mon_3 as 'شهر3',mon_4 as 'شهر4',mon_5 as 'شهر5',mon_6 as 'شهر6',mon_7 as 'شهر7',mon_8 as 'شهر8',mon_9 as 'شهر9',mon_10 as'شهر10',mon_11 as'شهر 11',mon_12 as 'شهر 12',student_id as 'رقم الطالب' from student_madfou3aat where student_code=" + id + "", "");
                    dgv.DataSource = tbl;
                }
                catch (Exception) { }
            }

            if (radiopays.Checked == true)
            {
                if (cbx.Text == "" || cbxmonth.Text == "")
                {
                    MessageBox.Show("من فضلك اختر المرحله واختر الشهر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    db.excutedata("delete from madfou3aat_details22", "");


                    DataTable tblcomedata = new DataTable();
                    tblcomedata.Clear();
                    tblcomedata = db.readdata("select*from madfou3aat_details where marhala_id=" + cbx.SelectedValue + " and month=" + cbxmonth.Text + "", "");
                    for (int i = 0; i <= tblcomedata.Rows.Count - 1; i++)
                    {
                        db.excutedata("insert into madfou3aat_details22 values(" + tblcomedata.Rows[i][0] + "," + tblcomedata.Rows[i][1] + ",N'" + tblcomedata.Rows[i][2] + "'," + tblcomedata.Rows[i][3] + "," + tblcomedata.Rows[i][4] + "," + tblcomedata.Rows[i][5] + "," + tblcomedata.Rows[i][6] + ",N'" + tblcomedata.Rows[i][7] + "'," + tblcomedata.Rows[i][8] + ",N'" + tblcomedata.Rows[i][9] + "'," + tblcomedata.Rows[i][10] + ",N'" + tblcomedata.Rows[i][11] + "',"+Convert.ToInt32( tblcomedata.Rows[i][12]) + ")", "");
                    }
                    //  ====================================



                    DataTable tblstudent_data = new DataTable();
                    tblstudent_data.Clear();
                    tblstudent_data = db.readdata("select*from student_data where marhal_id=" + cbx.SelectedValue + " ", "");

                    DataTable tblorder_id = new DataTable();
                    tblorder_id.Clear();
                    tblorder_id = db.readdata("select*from sandat_id", "");
                    for (int x = 0; x <= tblstudent_data.Rows.Count - 1; x++)
                    {
                        int order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);

                        DataTable tblcheck = new DataTable();
                        tblcheck.Clear();
                        tblcheck = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر' ", "");

                        DataTable tblcheck1 = new DataTable();
                        tblcheck1.Clear();
                        tblcheck1 = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type=N'مصاريف شهر' ", "");

                        if (tblcheck.Rows.Count < 1)
                        {
                            db.excutedata("insert into madfou3aat_details22 values(" + order_id + "," + tblstudent_data.Rows[x][0] + ",N'" + tblstudent_data.Rows[x][1] + "',0,0,0,0,N'" + Properties.Settings.Default.user_name + "',0,N'لم يقومو بالدفع'," + tblstudent_data.Rows[x][2] + ",N'" + tblstudent_data.Rows[x][10] + "',"+Convert.ToInt32(tblstudent_data.Rows[x][5]) +")", "");

                        }
                        if (tblcheck1.Rows.Count > 0)
                        {
                            db.excutedata("delete from madfou3aat_details22 where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر'", "");
                        }

                    }





                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه', student_code as'كود الطالب',student_name as'اسم الطالب ',day as'اليوم',month as'الشهر',year as'السنه',type as'-',student_id as 'رقم الطالب' from madfou3aat_details22 where  marhala_id=" + cbx.SelectedValue + " and type=N'مصاريف شهر'and month=" + cbxmonth.Text + "", "");
                    dgv.DataSource = tbl;
                }
            }
            else if(radionotpays.Checked==true)
            {
                if (cbx.Text == "" || cbxmonth.Text == "")
                {
                    MessageBox.Show("من فضلك اختر المرحله واختر الشهر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    db.excutedata("delete from madfou3aat_details22", "");


                    DataTable tblcomedata = new DataTable();
                    tblcomedata.Clear();
                    tblcomedata = db.readdata("select*from madfou3aat_details where marhala_id=" + cbx.SelectedValue + " and month=" + cbxmonth.Text + "", "");
                    for (int i = 0; i <= tblcomedata.Rows.Count - 1; i++)
                    {
                        db.excutedata("insert into madfou3aat_details22 values(" + tblcomedata.Rows[i][0] + "," + tblcomedata.Rows[i][1] + ",N'" + tblcomedata.Rows[i][2] + "'," + tblcomedata.Rows[i][3] + "," + tblcomedata.Rows[i][4] + "," + tblcomedata.Rows[i][5] + "," + tblcomedata.Rows[i][6] + ",N'" + tblcomedata.Rows[i][7] + "'," + tblcomedata.Rows[i][8] + ",N'" + tblcomedata.Rows[i][9] + "'," + tblcomedata.Rows[i][10] + ",N'" + tblcomedata.Rows[i][11] + "',"+Convert.ToInt32(tblcomedata.Rows[i][12]) +")", "");
                    }
                    //  ====================================



                    DataTable tblstudent_data = new DataTable();
                    tblstudent_data.Clear();
                    tblstudent_data = db.readdata("select*from student_data where marhal_id=" + cbx.SelectedValue + " ", "");

                    DataTable tblorder_id = new DataTable();
                    tblorder_id.Clear();
                    tblorder_id = db.readdata("select*from sandat_id", "");
                    for (int x = 0; x <= tblstudent_data.Rows.Count - 1; x++)
                    {
                        int order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);

                        DataTable tblcheck = new DataTable();
                        tblcheck.Clear();
                        tblcheck = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر' ", "");

                        DataTable tblcheck1 = new DataTable();
                        tblcheck1.Clear();
                        tblcheck1 = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type=N'مصاريف شهر' ", "");

                        if (tblcheck.Rows.Count < 1)
                        {
                            db.excutedata("insert into madfou3aat_details22 values(" + order_id + "," + tblstudent_data.Rows[x][0] + ",N'" + tblstudent_data.Rows[x][1] + "',0,0,0,0,N'" + Properties.Settings.Default.user_name + "',0,N'لم يقومو بالدفع'," + tblstudent_data.Rows[x][2] + ",N'" + tblstudent_data.Rows[x][10] + "',"+Convert.ToInt32(tblstudent_data.Rows[x][5]) + ")", "");
                            //db.excutedata("update madfou3aat_details22 set type=N'لم يقومو بالدفع'  where  type=N'مصاريف شهر' and  student_code=" + tblstudent_data.Rows[x][0] +" and month=N'" + cbxmonth.Text+ "'", "");

                        }
                        if (tblcheck1.Rows.Count > 0)
                        {
                            db.excutedata("delete from madfou3aat_details22 where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر'", "");
                            //db.excutedata("update madfou3aat_details22 set type=N'لم يقومو بالدفع'  where  type=N'مصاريف شهر' and  student_code=" + tblstudent_data.Rows[x][0] + " and month=N'" + cbxmonth.Text + "'", "");

                        }

                    }





                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه', student_code as'كود الطالب',student_name as'اسم الطالب ',day as'اليوم',month as'الشهر',year as'السنه',type as'-',student_id as 'رقم الطالب' from madfou3aat_details22 where  marhala_id=" + cbx.SelectedValue + " and type=N'لم يقومو بالدفع'", "");
                    dgv.DataSource = tbl;
                }
            }
        }

        private void radioallstudentinmarhala_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void radioselectdstudent_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void txt_write_student_TextChanged(object sender, EventArgs e)
        {
            if (radiostudentnameorpart.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',activation as'الحاله',student_id as 'رقم الطالب' from student_data where student_name like N'%" + txt_write_student.Text.Trim() + "%'", "");
                dgv.DataSource = tbl;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                if(MessageBox.Show("هل انت متاكد من تنفيذ هذا الاسترداد","تاكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    db.excutedata("update student_madfou3aat set mon_1="+dgv.CurrentRow.Cells[4].Value+ ",mon_2=" + dgv.CurrentRow.Cells[5].Value + ",mon_3=" + dgv.CurrentRow.Cells[6].Value + ",mon_4=" + dgv.CurrentRow.Cells[7].Value + ",mon_5=" + dgv.CurrentRow.Cells[8].Value + ",mon_6=" + dgv.CurrentRow.Cells[9].Value + ",mon_7=" + dgv.CurrentRow.Cells[10].Value + ",mon_8=" + dgv.CurrentRow.Cells[11].Value + ", mon_9=" + dgv.CurrentRow.Cells[12].Value + ",mon_10=" + dgv.CurrentRow.Cells[13].Value + ",mon_11=" + dgv.CurrentRow.Cells[14].Value + ",mon_12=" + dgv.CurrentRow.Cells[15].Value + " where student_id="+ dgv.CurrentRow.Cells[16].Value + " ", "");
                    MessageBox.Show("تم التنفيذ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                btnsearch_Click(null, null);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sandatemployee frm = new sandatemployee();
            frm.ShowDialog();
        }
    }
}