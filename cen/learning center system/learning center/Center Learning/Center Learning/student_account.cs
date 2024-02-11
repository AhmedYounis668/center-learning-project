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
    public partial class student_account : DevExpress.XtraEditors.XtraForm
    {
        public student_account()
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
        private void student_account_Load(object sender, EventArgs e)
        {
            fillcbx();
            dtpfrom.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
            txtsearchwithstudentcode.Focus();
        }

        private void txt_write_student_TextChanged(object sender, EventArgs e)
        {
            if (radiostudentnameorpart.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',activation as'الحاله' from student_data where student_name like N'%" + txt_write_student.Text.Trim() + "%'", "");
                dgv.DataSource = tbl;
            }
        }

        private void radioselectdstudent_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void radioallstudentinmarhala_CheckedChanged(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radioallstudentinmarhala.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_code as 'كود الطالب',student_name as'اسم الطالب',description as'البيان',degree as'الدرجه',date as'التاريخ',marhala_name as'المرحله الدراسيه',user_name as'المستخدم' from student_account where marhala_id=" + cbx.SelectedValue + " order by date", "");
                dgv.DataSource = tbl;
            }
            else if (radioselectdstudent.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_code as 'كود الطالب',student_name as'اسم الطالب',description as'البيان',degree as'الدرجه',date as'التاريخ',marhala_name as'المرحله الدراسيه',user_name as'المستخدم' from student_account where student_id=" + cbx.SelectedValue + " order by date", "");
                dgv.DataSource = tbl;
            }
            else if (radiostudentnameorpart.Checked == true)
            {
                if (dgv.Rows.Count >= 1)
                {

                    int student_code = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    tbl.Clear();
                    tbl = db.readdata("select order_id as'رقم العمليه',student_code as 'كود الطالب',student_name as'اسم الطالب',description as'البيان',degree as'الدرجه',date as'التاريخ',marhala_name as'المرحله الدراسيه',user_name as'المستخدم' from student_account where student_code=N'" + student_code + "' order by date", "");
                    dgv.DataSource = tbl;
                }
            }
            else if (radiosearchfatra.Checked == true)
            {
                string dfrom = dtpfrom.Value.ToString("yyyy-MM-dd");
                string dto = dtpto.Value.ToString("yyyy-MM-dd");

                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_code as 'كود الطالب',student_name as'اسم الطالب',description as'البيان',degree as'الدرجه',date as'التاريخ',marhala_name as'المرحله الدراسيه',user_name as'المستخدم' from student_account where student_id=" + cbx.SelectedValue + " and convert (nvarchar,date,105)between N'" + dfrom + "' and N'" + dto + "' order by date", "");
                dgv.DataSource = tbl;

            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioselectdstudent.Checked == true)
                {


                    int id2 = Convert.ToInt32(cbx.SelectedValue);

                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.discriptionnn as'الوصف',settingprinting_bills.address as'العنوان', student_id as'كود الطالب',student_name as'اسم الطالب',description as'البيان',date as'التاريخ',degree as'الدرجه',user_name as'المستخدم',marhala_name as'المرحله الدراسيه',student_code as 'كود الطالببب' from student_account ,settingprinting_bills where student_id=" + id2 + "", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    student_account_printing rpt = new student_account_printing();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    rpt.SetParameterValue("id2", id2);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
            }
            catch (Exception) { }
        }

        private void txtsearchwithstudentcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_code as 'كود الطالب',student_name as'اسم الطالب',description as'البيان',degree as'الدرجه',date as'التاريخ',marhala_name as'المرحله الدراسيه',user_name as'المستخدم' from student_account where student_code=N'" + txtsearchwithstudentcode.Text.Trim() + "' order by date", "");
                dgv.DataSource = tbl;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void print()
        {
            if (txtsearchwithstudentcode.Text != "")
            {
                try
                {
                    string id = Convert.ToString(txtsearchwithstudentcode.Text.Trim());

                    DataTable tblprint1 = new DataTable();
                    tblprint1.Clear();
                    tblprint1 = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',settingprinting_bills.address as'العنوان', student_id as'رقم الطالب',student_code as 'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',printstudentstatement.description as'الوصف',money as'المبلغ',notes as'ملاحظات' from printstudentstatement,settingprinting_bills where printstudentstatement.student_code=N'" + id + "'", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    st_statementprint rpt = new st_statementprint();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint1);
                    rpt.SetParameterValue("id", id);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }

        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtsearchwithstudentcode.Text != "")
            {
                DataTable tblstudentdata = new DataTable();
                tblstudentdata.Clear();
                tblstudentdata = db.readdata("select*from student_data where student_code=N'" + txtsearchwithstudentcode.Text.Trim() + "'", "");
                if (tblstudentdata.Rows.Count == 1)
                {
                    try
                    {

                        //الغيابات
                        //db.excutedata("delete from printstudentstatement ", "");
                        DataTable tblabsent = new DataTable();
                        tblabsent.Clear();

                        tblabsent = db.readdata("select*from attendans where student_code=N'" + txtsearchwithstudentcode.Text + "' and state=N'غياب'", "");

                        for (int i = 0; i <= tblabsent.Rows.Count-1; i++)
                        {

                            db.excutedata("insert into printstudentstatement values(" + tblabsent.Rows[i][1] + ",N'" + tblabsent.Rows[i][11] + "',N'" + tblabsent.Rows[i][2] + "',N'" + tblabsent.Rows[i][3] + "',N'" + tblabsent.Rows[i][8] + "',0,N'')", "");
                        }

                        //المدفوعات
                        DataTable tblpays = new DataTable();
                       // tblpays.Clear();

                        tblpays = db.readdata("select*from madfou3aat_details  where student_code=N'" + txtsearchwithstudentcode.Text + "' ", "");

                        for (int x = 0; x <= tblpays.Rows.Count-1; x++)
                        {

                            string notes = "شهر"+" "+Convert.ToString(tblpays.Rows[x][5]);
                            db.excutedata("insert into printstudentstatement values(" + tblpays.Rows[x][1] + ",N'" + tblpays.Rows[x][11] + "',N'" + tblpays.Rows[x][2] + "',N'" + tblpays.Rows[x][3] + "',N'" + tblpays.Rows[x][9] + "'," + tblpays.Rows[x][8] + ",N'" + notes + "')", "");

                        }


                    }
                    catch (Exception) { }
                    }
                
                

                else
                {
                    MessageBox.Show("لايوجد طالب بهذا الكود تاكد من الكود من فضلك", "تنبيه هام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                print();

                db.excutedata("delete from printstudentstatement ", "");

            }
        }
            }
}