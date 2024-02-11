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
    public partial class student_degree : DevExpress.XtraEditors.XtraForm
    {
        public student_degree()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblpersonname_Click(object sender, EventArgs e)
        {

        }

        private void lblperson_id_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblmoney_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnstaticnotes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.staticnotes = txtnotes.Text.Trim();
            Properties.Settings.Default.Save();
            txtnotes.Text = Properties.Settings.Default.staticnotes;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtnotes.Clear();
            Properties.Settings.Default.staticnotes = "";
            Properties.Settings.Default.Save();

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void txtpersonnamesearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtpersonnamesearch.Text != "")
                {
                    if (radiosearchwithstudent_name.Checked == true)
                    {
                        tbl.Clear();
                        tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as'رقم الطالب' from student_data where student_name like N'%" + txtpersonnamesearch.Text.Trim() + "%' and marhal_id="+cbx.SelectedValue+"", "");
                        dgvperson.DataSource = tbl;
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
                        tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as'رقم الطالب' from student_data where student_code=N'" + student_code + "' and marhal_id="+cbx.SelectedValue+"", "");
                        dgvperson.DataSource = tbl;

                    }

                    else if (radiosearchwithcode.Checked == false && radiosearchwithstudent_name.Checked == false)
                    {
                        MessageBox.Show("من فضلك حدد عمليه البحث اولا هتبحث بكود الطالب ولا باسمه ؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
            catch (Exception) { }
            
        }

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

            lblmoney.Text = "0";
            lblperson_id.Text = "0";
            lblpersonname.Text = "-";
            numircprice.Value = 0;
            //txtnotes.Clear();
            
        }

        private void student_degree_Load(object sender, EventArgs e)
        {
            cbx.DataSource = db.readdata("select*from groups ", "");
            cbx.DisplayMember = "group_name";
            cbx.ValueMember = "group_id";
            autonumber();
            dtpdate.Text = DateTime.Now.ToShortDateString();
            dtpsearch.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtdegree.Enabled = false;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtdegree.Enabled = true;
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            if(radioexam.Checked==false&&radiotasme3.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvperson.Rows.Count >= 1)
            {
                if (numircprice.Value==0)
                {
                    MessageBox.Show("هل انت متاكد من ان درجه هذا الطالب تساوي صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    if (txtdegree.Text == "")
                    {
                        MessageBox.Show("من فضلك ادخل درجه الامتحان المقرره من الاستاذ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lblmoney.Text = Convert.ToDecimal(numircprice.Value).ToString();
                    string person_id = "0";
                    person_id = Convert.ToString(dgvperson.CurrentRow.Cells[0].Value);
                    lblperson_id.Text = person_id.ToString();
                    lblpersonname.Text = Convert.ToString(dgvperson.CurrentRow.Cells[1].Value);
                    lbldegree.Text = Convert.ToString(txtdegree.Text);
                    lblmarhala.Text = Convert.ToString(dgvperson.CurrentRow.Cells[2].Value);
                    int marhala_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[3].Value);
                    lblmarhala_id.Text = marhala_id.ToString();
                int stu_id = 0;
                stu_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[4].Value);
                lblstu_id.Text = stu_id.ToString();
            }
            
        }

        private void print()
        {
            try
            {
                int id = Convert.ToInt32(txtorder_id.Text);

                DataTable tblprint = new DataTable();
                tblprint.Clear();
                tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',order_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',marhala_name as'المرحله',exam_degree as'الدرجه المقرره',user_name as'المستخدم',student_code as 'كود الطالببب' from settingprinting_bills,exam_degree where order_id="+id+"", "");
                printing frm = new printing();
                frm.crystalReportViewer1.RefreshReport();

                exam_degree_printing rpt = new exam_degree_printing();
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
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            if (radiotasme3.Checked == true)
            {
                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string descriptiontasme3 = "قام الطالب بالحصول علي الدرجه" + " " + lblmoney.Text + " " + "من اصل" + " " + lbldegree.Text+" "+"في التسميع";
                db.excutedata("insert into exam_degree values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptiontasme3 + "',N'" + txtnotes.Text.Trim() + "',N'" + d + "',N'" + Properties.Settings.Default.dayuse + "',N'" + lblmarhala.Text + "'," + lbldegree.Text + ",N'" + Properties.Settings.Default.user_name + "',N'"+lblperson_id.Text+"')", "");

                db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptiontasme3 + "',N'" + d + "',N'" + lblmoney.Text + "',N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", "");

                db.excutedata("insert into student_degrees_only values("+ txtorder_id.Text + ","+ lblstu_id.Text + ",N'"+lblperson_id.Text+"',N'"+lblpersonname.Text+"',"+txtdegree.Text+","+lblmoney.Text+",N'تسميع',N'"+d+"',"+cbx.SelectedValue+",N'"+cbx.Text+"')", "تم التسجيل");
                // autonumber();

            }
            else if(radioexam.Checked==true)
            {

                string d = dtpdate.Value.ToString("yyyy-MM-dd");
                string descriptionexam = "قام الطالب بالحصول علي الدرجه" + " " + lblmoney.Text + " " + "من اصل" + " " + lbldegree.Text + " " + "في الاختبار";
                db.excutedata("insert into exam_degree values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionexam + "',N'" + txtnotes.Text.Trim() + "',N'" + d + "',N'" + Properties.Settings.Default.dayuse + "',N'" + lblmarhala.Text + "'," + lbldegree.Text + ",N'" + Properties.Settings.Default.user_name + "',N'"+lblperson_id.Text+"')", "");

                db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionexam + "',N'" + d + "'," + lblmoney.Text + ",N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", " ");
                db.excutedata("insert into student_degrees_only values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblperson_id.Text + "',N'" + lblpersonname.Text + "'," + txtdegree.Text + "," + lblmoney.Text + ",N'اختبار',N'" + d + "'," + cbx.SelectedValue + ",N'" + cbx.Text + "')", "تم التسجيل");
            }
            if (Properties.Settings.Default.printingorno == true)
            {
                print();
            }

                autonumber();

            {

            }
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات ؟", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dgv.Rows.Count >= 1)
                {
                    int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    db.excutedata("delete from student_account where order_id="+order_id+"", "");
                    db.excutedata("delete from exam_degree where order_id="+order_id+"", "");
                    db.excutedata("delete from student_degrees_only where order_id=" + order_id + "", "");

                    btnchange_Click(null, null);               }
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if(radiosandnumbersearch.Checked==false&&radiofatra.Checked==false)
            {
                MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string dfrom = "", dto = "";
            dfrom = dtpsearch.Value.ToString("yyyy-MM-dd");
            dto = dtpto.Value.ToString("yyyy-MM-dd");
            if (radiofatra.Checked == true)
            {
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_name as'اسم الطالب',description as'البيان',date as'التاريخ',day_use as'اليوم',student_code as'كود الطالب' from exam_degree where convert(nvarchar,date,105)between N'"+dfrom+"' and N'"+dto+"'", "");
                dgv.DataSource = tbl;
            }
            else if(radiosandnumbersearch.Checked==true)
            {
            if(txtsandnumbersearch.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل رقم العمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tbl.Clear();
                tbl = db.readdata("select order_id as'رقم العمليه',student_name as'اسم الطالب',description as'البيان',date as'التاريخ',day_use as'اليوم',student_code as'كود الطالب' from exam_degree where order_id="+txtsandnumbersearch.Text+"", "");
                dgv.DataSource = tbl;
            }
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if(dgv.Rows.Count>=1)
            {
                try
                {
                    int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                    DataTable tblprint = new DataTable();
                    tblprint.Clear();
                    tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',order_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',description as'البيان',notes as'ملاحظات',date as'التاريخ',marhala_name as'المرحله',exam_degree as'الدرجه المقرره',user_name as'المستخدم',student_code as 'كود الطالببب' from settingprinting_bills,exam_degree where order_id=" + id + "", "");
                    printing frm = new printing();
                    frm.crystalReportViewer1.RefreshReport();

                    exam_degree_printing rpt = new exam_degree_printing();
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

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                if (radioexam.Checked == false && radiotasme3.Checked == false)
                {
                    MessageBox.Show("من فضلك حدد عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                    
                        if (txtdegree.Text == "")
                        {
                            MessageBox.Show("من فضلك ادخل درجه الامتحان المقرره من الاستاذ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                if (lblperson_id.Text == ""|| lblperson_id.Text =="0")
                {
                    MessageBox.Show("من فضلك اختر الطالب اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(lblmoney.Text=="")
                {
                    MessageBox.Show("من فضلك ادخل الدرجه التي حصل عليها الطالب", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                if (MessageBox.Show("هل انت متاكد من التعديل ؟", "هل انت متاكد من التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.excutedata("delete from student_account where order_id=" + order_id + "", "");
                    db.excutedata("delete from exam_degree where order_id=" + order_id + "", "");
                    db.excutedata("delete from student_degrees_only where order_id=" + order_id + "", "");

                    if (radiotasme3.Checked == true)
                    {
                        string d = dtpdate.Value.ToString("yyyy-MM-dd");
                        string descriptiontasme3 = "قام الطالب بالحصول علي الدرجه" + " " + lblmoney.Text + " " + "من اصل" + " " + lbldegree.Text + " " + "في التسميع";
                        db.excutedata("insert into exam_degree values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptiontasme3 + "',N'" + txtnotes.Text.Trim() + "',N'" + d + "',N'" + Properties.Settings.Default.dayuse + "',N'" + lblmarhala.Text + "'," + lbldegree.Text + ",N'" + Properties.Settings.Default.user_name + "',N'"+lblperson_id.Text+"')", "");

                        db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptiontasme3 + "',N'" + d + "',N'" + lblmoney.Text + "',N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", "تم التسجيل");
                        db.excutedata("insert into student_degrees_only values(" + txtorder_id.Text + "," + lblstu_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "'," + txtdegree.Text + "," + lblmoney.Text + ",N'تسميع',N'" + d + "'," + cbx.SelectedValue + ",N'" + cbx.Text + "')", "تم التسجيل");

                        // autonumber();
                    }
                    else if (radioexam.Checked == true)
                    {

                        string d = dtpdate.Value.ToString("yyyy-MM-dd");
                        string descriptionexam = "قام الطالب بالحصول علي الدرجه" + " " + lblmoney.Text + " " + "من اصل" + " " + lbldegree.Text + " " + "في الاختبار";
                        db.excutedata("insert into exam_degree values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionexam + "',N'" + txtnotes.Text.Trim() + "',N'" + d + "',N'" + Properties.Settings.Default.dayuse + "',N'" + lblmarhala.Text + "'," + lbldegree.Text + ",N'" + Properties.Settings.Default.user_name + "',N'"+ lblperson_id.Text + "')", "");

                        db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionexam + "',N'" + d + "'," + lblmoney.Text + ",N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+ lblperson_id.Text + "')", "تم التسجيل");
                        db.excutedata("insert into student_degrees_only values(" + txtorder_id.Text + "," + lblstu_id.Text + "," + lblperson_id.Text + ",N'" + lblpersonname.Text + "'," + txtdegree.Text + "," + lblmoney.Text + ",N'اختبار',N'" + d + "'," + cbx.SelectedValue + ",N'" + cbx.Text + "')", "تم التسجيل");

                        //autonumber();
                    }
                    print();
                    autonumber();
                }
            }
                }

        private void dtpdate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdegree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}