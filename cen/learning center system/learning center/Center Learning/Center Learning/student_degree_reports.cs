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
    public partial class student_degree_reports : DevExpress.XtraEditors.XtraForm
    {
        public student_degree_reports()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void fillcbx()
        {
            cbxmarhala.DataSource = db.readdata("select*from groups ", "");
            cbxmarhala.DisplayMember = "group_name";
            cbxmarhala.ValueMember = "group_id";
        }
        private void student_degree_reports_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
            string dto = dtpto.Value.ToString("yyyy-MM-dd");
            if(radioallstudent.Checked==false&&radiostudent_name.Checked==false&&radiosearchwithcode.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(radioallstudent.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',day_use as'اليوم',marhala_name as'المرحله الدراسيه',exam_degree as'درجه الامتحان المقرره',user_name as'المستخدم' from exam_degree where marhala_name=N'"+cbxmarhala.Text+"' and convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
            }
            else if(radiostudent_name.Checked==true)
            {
                string student_code = Convert.ToString(dgvstudent.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',day_use as'اليوم',marhala_name as'المرحله الدراسيه',exam_degree as'درجه الامتحان المقرره',user_name as'المستخدم' from exam_degree where student_code=N'" + student_code + "' and convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
            }
            else if(radiosearchwithcode.Checked==true)
            {
                string student_code = Convert.ToString(dgvstudent.CurrentRow.Cells[0].Value);
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم البيان',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',day_use as'اليوم',marhala_name as'المرحله الدراسيه',exam_degree as'درجه الامتحان المقرره',user_name as'المستخدم' from exam_degree where student_code=N'" + student_code + "' and convert(nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "'", "");
                dgv.DataSource = tbl;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radiostudent_name.Checked == true)
                {

                    tbl.Clear();
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',student_id as'رقم الطالب' from student_data where student_name like N'%" + txtsearch.Text.Trim() + "%' and activation=1", "");
                    dgvstudent.DataSource = tbl;

                }
                else if (radiosearchwithcode.Checked == true)
                {

                    string student_code = "0";
                    if (txtsearch.Text == "")
                    {
                        student_code = "0";
                    }
                    else if (txtsearch.Text != "")
                    {
                        student_code = Convert.ToString(txtsearch.Text);
                    }
                    tbl.Clear();
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as'رقم الطالب' from student_data where student_code=N'" + student_code + "'", "");
                    dgvstudent.DataSource = tbl;

                }
            }
            catch (Exception)
            { }


        }
    }
}