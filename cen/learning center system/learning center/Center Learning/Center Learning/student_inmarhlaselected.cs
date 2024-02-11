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
    public partial class student_inmarhlaselected : DevExpress.XtraEditors.XtraForm
    {
        public student_inmarhlaselected()
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


            cbxmagmou3a.DataSource = db.readdata("select*from magmou3at_data", "");
            cbxmagmou3a.DisplayMember = "magmou3a_name";
            cbxmagmou3a.ValueMember = "magmou3a_id";

        }
        private void student_inmarhlaselected_Load(object sender, EventArgs e)
        {
            fillcbx();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(radioallstudent.Checked==false&&radiomagmou3aonly.Checked==false&&radioallnotactivationinallmarahel.Checked==false&&radioallnotactivationin_selected_marhala.Checked==false)
            {
                MessageBox.Show("من فضلك حدد طريقه بحث ماذا تريد ان تبحث", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (radioallstudent.Checked == true)
            {

                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',student_id as'رقم الطالب' from student_data where marhal_id=" + cbxmarhalaname.SelectedValue + " and activation=1", "");
                dgv.DataSource = tbl;
            }
            else if(radiomagmou3aonly.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',student_id as'رقم الطالب' from student_data where  marhal_id=" + cbxmarhalaname.SelectedValue + " and  magmo3a_id=" + cbxmagmou3a.SelectedValue + " and activation=1", "");
                dgv.DataSource = tbl;
            }
            else if(radioallnotactivationinallmarahel.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhal_id as'رقم المرحله',marhala_name as'المرحله',activation as'نشط ام لا',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر' from student_data where activation = 0", "");
                dgv.DataSource = tbl;

            }
            else if(radioallnotactivationin_selected_marhala.Checked==true)
            {
                tbl.Clear();
                tbl = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر' from student_data where activation = 0 and marhal_id="+cbxmarhalaname.SelectedValue+"", "");
                dgv.DataSource = tbl;
            }
            txttotal.Text = dgv.Rows.Count.ToString();
        }

        private void bnprint_Click(object sender, EventArgs e)
        {
            if(radioallstudent.Checked==false&&radiomagmou3aonly.Checked==false&&radioallnotactivationinallmarahel.Checked==false&&radioallnotactivationin_selected_marhala.Checked==false)
            {
                MessageBox.Show("من فضل حدد طريقه بحث اولا قبل الطباعه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (radioallstudent.Checked == true)
            {

                try
                {
                    int id = Convert.ToInt32(cbxmarhalaname.SelectedValue);

                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select student_id as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله' from student_data where marhal_id=" + id + " and activation=1", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    studentinmarhala rpt = new studentinmarhala();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    rpt.SetParameterValue("id", id);

                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }

            else if(radiomagmou3aonly.Checked==true)
            {
                try
                {
                    int id = Convert.ToInt32(cbxmarhalaname.SelectedValue);
                    int mid = Convert.ToInt32(cbxmagmou3a.SelectedValue);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where marhal_id =" + id + " and magmo3a_id="+mid+" and activation=1", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    student_in_marhala_and_magmou3a rpt = new student_in_marhala_and_magmou3a();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                    rpt.SetParameterValue("id", id);
                    rpt.SetParameterValue("mid", mid);
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }

            else if(radioallnotactivationinallmarahel.Checked==true)
            {
                try
                {
              
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where activation=0 ", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                   allstudent_notactivation_inallmrahel rpt = new allstudent_notactivation_inallmrahel();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
                   
                    frm.crystalReportViewer1.ReportSource = rpt;
                    frm.ShowDialog();
                    //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                    //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                    //rpt.PrintToPrinter(1, true, 0, 0);
                }
                catch (Exception) { }
            }

            else if(radioallnotactivationin_selected_marhala.Checked==true)
            {
                try
                {
                    int id = Convert.ToInt32(cbxmarhalaname.SelectedValue);
                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select student_id as'رقم  الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',marhal_id as'رقم المرحله',student_code as'كود الطالب',phone as'تليفون الطالب',father_phone as'تليفون ولي الامر',magmo3a_id as'رقم المجموعه',magmo3a_name as'اسم المجموعه' from student_data where activation=0 and marhal_id="+id+"", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    allstudent_notactivation_in_selected_marhala rpt = new allstudent_notactivation_in_selected_marhala();
                    rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                    rpt.SetDataSource(tblprint);
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
    }
}