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
    public partial class attendans_reports : DevExpress.XtraEditors.XtraForm
    {
        public attendans_reports()
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
        private void attendans_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            radiosearchwithmarhala.Checked= false;
            radiosearchwithstudent_name.Checked = false;
            radiosearchwithstudentcode.Checked = false;
            radiosearchwithstudentattendansonly.Checked = false;
            radiosearchwithstudentabsentonly.Checked = false;
            dtpdate.Text = DateTime.Now.ToShortDateString();
            dtpdate2.Text = DateTime.Now.ToShortDateString();
            
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            string d = dtpdate.Value.ToString("yyyy-MM-dd");
            string d2 = dtpdate2.Value.ToString("yyyy-MM-dd");
            if (radiosearchwithmarhala.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as 'كود الطالب' from attendans where marhala_id=" + cbxmarhalaname.SelectedValue + " and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;

                int totalstudent = 0;
                DataTable tbltotalstudentcount = new DataTable();
                tbltotalstudentcount.Clear();
                tbltotalstudentcount = db.readdata("select count(student_id)from student_data where marhal_id=" + cbxmarhalaname.SelectedValue + "", "");
                //for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                //{
                totalstudent += Convert.ToInt32(tbltotalstudentcount.Rows[0][0]);
                // }

                DataTable tblstudentcount = new DataTable();
                tblstudentcount.Clear();
                tblstudentcount = db.readdata("select*from attendans where marhala_id="+cbxmarhalaname.SelectedValue+ " and state=N'حضور' and convert(nvarchar,date,105)between N'" + d+"' and N'"+d2+"'", "");
                int totalattendans = 0;
                for (int i=0;i<=tblstudentcount.Rows.Count-1;i++)
                {
                     totalattendans = tblstudentcount.Rows.Count;
                }

                lblnotes.Text = "اجمالي عدد الطلاب في المرحله " + " " + cbxmarhalaname.Text + " " + "=" + " " + totalstudent + " " + "طلاب"+" "+"----"+" "+"عدد الطلاب الذين قامو بالحضور في التاريخ المحدد="+" "+totalattendans;

            }
            else if (radiosearchwithstudentcode.Checked == true)
            {
                if (dgvstudents.Rows.Count >= 1)
                {
                    string student_code = Convert.ToString(dgvstudents.CurrentRow.Cells[0].Value);
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where student_code=N'" + student_code + "' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                    dgv.DataSource = tbl;
                }
            }
            else if (radiosearchwithstudent_name.Checked == true)
            {
                if (dgvstudents.Rows.Count >= 1)
                {
                    string student_name = Convert.ToString(dgvstudents.CurrentRow.Cells[1].Value);
                    string student_code = Convert.ToString(dgvstudents.CurrentRow.Cells[0].Value);
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where student_name=N'" + student_name + "' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                    dgv.DataSource = tbl;
                }
            }
            else if (radiosearchwithstudentattendansonly.Checked == true)
            {

                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'حضور' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;
            }
            else if (radiosearchwithstudentabsentonly.Checked == true)
            {

                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'غياب' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;
            }
            else if (radiomagmo3a.Checked == true)
            {

                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where magmo3a_id="+cbxmagmou3a.SelectedValue+" and marhala_id="+cbxmarhalaname.SelectedValue+"  and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;
            }
            else if(radioattendsonlyinmarhala.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'حضور' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "' and marhala_id="+cbxmarhalaname.SelectedValue+"", "");
                dgv.DataSource = tbl;
            }
            else if(radioabsentsonlyinmarhal.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'غياب' and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "' and marhala_id="+cbxmarhalaname.SelectedValue+"", "");
                dgv.DataSource = tbl;
            }
            else if(radioattendsinmagmo3a.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'حضور' and magmo3a_id=" + cbxmagmou3a.SelectedValue + " and marhala_id=" + cbxmarhalaname.SelectedValue + "  and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;
            }
            else if(radioabsentinmagmo3a.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',date as'التاريخ',time as'الوقت',state as 'الحاله',marhala_name as'المرحله الدراسيه',notes_row as 'ملحوظه',genral_notes as'ملاحظات عامه',user_name as'المستخدم',student_id as'رقم الطالب',student_code as'كود الطالب' from attendans where state=N'غياب'  and magmo3a_id=" + cbxmagmou3a.SelectedValue + " and marhala_id=" + cbxmarhalaname.SelectedValue + "  and convert(nvarchar,date,105)between N'" + d + "' and N'" + d2 + "'", "");
                dgv.DataSource = tbl;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (radiosearchwithstudentcode.Checked == true)
            {
                string student_code = "0";
                if (txtsearch.Text == "")
                {
                    student_code = "0";
                }
                else if (txtsearch.Text != "")
                {
                    student_code =txtsearch.Text;
                }
                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',student_id as 'رقم الطالب' from student_data where student_code=N'"+student_code+"'", "");
                dgvstudents.DataSource = tbl;
            }
            else if(radiosearchwithstudent_name.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',student_id as'رقم الطالب' from student_data where student_name like N'%" + txtsearch.Text.Trim() + "%'", "");
                dgvstudents.DataSource = tbl;
            }
            }

        private void cbxmarhalaname_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cbxmarhalaname_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
    }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من التعديل", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    int student_id= Convert.ToInt32(dgv.CurrentRow.Cells[9].Value);
                    if (Convert.ToString(dgv.CurrentRow.Cells[4].Value) == "غياب")
                    {
                        db.excutedata("update attendans set state=N'حضور',genral_notes=N'تم تعديلها من غياب الي حضور' where order_id=" + order_id + " and student_id=" + student_id + " ", "");
                        db.excutedata("update student_account set description=N'قام الطالب بالحضور' where order_id=" + order_id + " and student_id=" + student_id + " ", "تم التعديل");
                    }
                   else if (Convert.ToString(dgv.CurrentRow.Cells[4].Value) == "حضور")
                    {
                        db.excutedata("update attendans set state=N'غياب',genral_notes=N'تم تعديلها من حضور الي غياب' where order_id=" + order_id + "and student_id=" + student_id + " ", "");
                        db.excutedata("update student_account set description=N'قام الطالب بالغياب' where order_id=" + order_id + " and student_id="+student_id+" ", "تم التعديل");
                    }
                    tileItem1_ItemClick(null, null);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiosearchwithstudentattendansonly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}