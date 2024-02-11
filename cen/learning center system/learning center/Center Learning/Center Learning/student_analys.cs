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
    public partial class student_analys : DevExpress.XtraEditors.XtraForm
    {
        public student_analys()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string from = "", to = "";
            from = dtpfrom.Value.ToString("yyyy-MM-dd");
            to = dtpto.Value.ToString("yyyy-MM-dd");
            decimal countattend=0;
            decimal finaltotal = 0;
            decimal finaltotaltasme3 = 0;

            DataTable tblstu = new DataTable();
            tblstu.Clear();

            DataTable stu_attends = new DataTable();
            stu_attends.Clear();
            if (dgv.Rows.Count >= 1)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);   
                tblstu = db.readdata("select student_id as'-', student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',magmo3a_name as'المجموعه' from student_data where student_id ="+id+" ", "");
                stu_attends = db.readdata("select * from attendans where student_id="+id+ " and state=N'حضور' and convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
            }
            else
            {
                MessageBox.Show("من فضلك ابحث عن الطالب اولا ثم قم بتحديده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            countattend = Convert.ToDecimal(stu_attends.Rows.Count)*10;

            string totalattend = Convert.ToString(stu_attends.Rows.Count);

            string student_name = Convert.ToString(dgv.CurrentRow.Cells[1].Value);


            decimal totallessonsinmonth = 120;
            string degree = "excellent";


            if (countattend == totallessonsinmonth)
            {
                degree = "excellent";
            }
            //from 7000 to 11000 very good
            else if (countattend < totallessonsinmonth && countattend > 90)
            {
                degree = "very good";
            }
            else if(countattend<90&&countattend>=60)
            {
                degree = "good";
            }
            else if(countattend<60)
            {
                degree = "very week يجب علي هذا الطالب المتابعه مع ولي امره واخذ الللزم معه ";
            }



            lblattend.Text = "تم حضور الطالب عدد" + totalattend+"حصه من اصل 12 حصه في الشهر "+"تثييم الطالب /////"+degree;
            lblname.Text = student_name;



            //=============================================الاختبار

            decimal totaldegrees = 0;
            decimal totaldegressstudent = 0;

            DataTable tbldegree = new DataTable();
            tbldegree.Clear();
            if (dgv.Rows.Count >= 1)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
                tbldegree = db.readdata("select*from student_degrees_only where student_id=" + id + " and type=N'اختبار' and convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "' ", "");
          
                 for(int i=0;i<=tbldegree.Rows.Count-1;i++)
                {
                    totaldegrees +=Convert.ToDecimal(tbldegree.Rows[i][4]);
                    totaldegressstudent+= Convert.ToDecimal(tbldegree.Rows[i][5]);

                }

                finaltotal = totaldegrees - totaldegressstudent;//اجمالي الدرجات اللي نقصها فقط
                decimal totalexams = tbldegree.Rows.Count;  //اجمالي عدد الاختبارات

                string exam_degree = "excellent";
                if(finaltotal<=10)
                {
                    exam_degree = "excellent";
                }
                else if(finaltotal>10&&finaltotal<15)
                {
                    exam_degree = "very good";
                }
                else if(finaltotal>15)
                {
                    exam_degree = "very week";
                }

               lblexamdegree.Text = "تم حصول الطالب علي عدد درجات" + totaldegressstudent + "من اصل اجمالي" + totaldegrees + "في كل اختبارات الفتره المحدده" + "من اصل عدد" + totalexams + "اختبارات" + "يتم تقييم الطالب ب" + exam_degree;
                    }



            //=============================================
            decimal totaldegreestasme3 = 0;
            decimal totaldegressstudenttasme3 = 0;

            DataTable tbldegreetasme3 = new DataTable();
            tbldegreetasme3.Clear();
            if (dgv.Rows.Count >= 1)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
                tbldegreetasme3 = db.readdata("select*from student_degrees_only where student_id=" + id + " and type=N'تسميع' and convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "' ", "");

                for (int i = 0; i <= tbldegreetasme3.Rows.Count - 1; i++)
                {
                    totaldegreestasme3 += Convert.ToDecimal(tbldegreetasme3.Rows[i][4]);
                    totaldegressstudenttasme3 += Convert.ToDecimal(tbldegreetasme3.Rows[i][5]);

                }

                finaltotaltasme3 = totaldegreestasme3 - totaldegressstudenttasme3;//اجمالي الدرجات اللي نقصها فقط في التسميع
                decimal totalexamstasme3 = tbldegreetasme3.Rows.Count;  //اجمالي عدد التسميعات

                string exam_degree_tasme3 = "excellent";
                if (finaltotaltasme3 <= 10)
                {
                    exam_degree_tasme3 = "excellent";
                }
                else if (finaltotaltasme3 > 10 && finaltotaltasme3 < 15)
                {
                    exam_degree_tasme3 = "very good";
                }
                else if (finaltotaltasme3 > 15)
                {
                    exam_degree_tasme3 = "very week";
                }

               lbltasme3.Text = "تم حصول الطالب علي عدد درجات" + totaldegressstudenttasme3 + "من اصل اجمالي" + totaldegreestasme3 + "في كل تسميعات الفتره المحدده" + "من اصل عدد" + totalexamstasme3 + "تسميع" + "يتم تقييم الطالب ب" + exam_degree_tasme3;
            }






            //=====================================

            DataTable tbl = new DataTable();
            tbl.Columns.Add("empname");
            tbl.Columns.Add("salary",typeof(Int32));

            tbl.Rows.Add("حضور", countattend);
            tbl.Rows.Add("الامتحانات", finaltotal);
            tbl.Rows.Add(" التسميع", finaltotaltasme3);


            chart1.DataSource = tbl;
            chart1.Series["Series1"].YValueMembers = "salary";
            chart1.Series["Series1"].XValueMember = "empname";
            chart1.Series["Series1"].YValueType= System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;




        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void student_analys_Load(object sender, EventArgs e)
        {
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            txtpersonnamesearch.Focus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (radiosearchwithstudent_name.Checked == true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as 'رقم الطالب' from student_data where student_name like N'%" + txtpersonnamesearch.Text.Trim() + "%' and activation=1 ", "");
                    dgv.DataSource = tbl;
                }
                else if (radiosearchwithcode.Checked == true)
                {

                    string student_code = "0";
                    if (txtpersonnamesearch.Text == "")
                    {
                        student_code = "0";
                    }
                    else if (txtpersonnamesearch.Text != "")
                    {
                        student_code = Convert.ToString(txtpersonnamesearch.Text);
                    }
                    tbl.Clear();
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as 'رقم الطالب' from student_data where student_code=N'" + student_code + "' and activation=1 ", "");
                    dgv.DataSource = tbl;

                }

            }
            catch (Exception) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            update_degrees frm = new update_degrees();
            frm.ShowDialog();
        }
    }
}