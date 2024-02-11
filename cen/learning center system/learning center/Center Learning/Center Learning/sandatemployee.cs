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
    public partial class sandatemployee : DevExpress.XtraEditors.XtraForm
    {
        public sandatemployee()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

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
            txtpersonnamesearch.Text = "";
            numircprice.Enabled = false;
        }
        string stoke_id = Properties.Settings.Default.stoke_id;

        private void sandatemployee_Load(object sender, EventArgs e)
        {
            cbx.DataSource = db.readdata("select*from groups ", "");
            cbx.DisplayMember = "group_name";
            cbx.ValueMember = "group_id";
            cbxmonth.Text = dtp.Value.Month.ToString();


            autonumber();
            dtp.Text = DateTime.Now.ToShortDateString();
            dtp.Text = DateTime.Now.ToShortTimeString();
            dtpsearch.Text = DateTime.Now.ToShortDateString();
            dtpto.Text = DateTime.Now.ToShortDateString();

            lblday.Text = dtp.Value.Day.ToString();
            lblmonthh.Text = dtp.Value.Month.ToString();
            lblyear.Text = dtp.Value.Year.ToString();
        }

        private void txtpersonnamesearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (radiosearchwithstudent_name.Checked == true)
                {
                    tbl.Clear();
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as 'رقم الطالب',activation as'نشط ام لا' from student_data where student_name like N'%" + txtpersonnamesearch.Text.Trim() + "%' and activation=1 and marhal_id="+cbx.SelectedValue+"", "");
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
                    tbl = db.readdata("select student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله الدراسيه',marhal_id as'كود المرحله',student_id as 'رقم الطالب',activation as'نشط ام لا' from student_data where student_code=N'" + student_code + "' and activation=1 and marhal_id="+cbx.SelectedValue+"", "");
                    dgvperson.DataSource = tbl;

                }

            }
            catch (Exception) { }
            }

        private void btndown_Click(object sender, EventArgs e)
        {

            if (dgvperson.Rows.Count >= 1)
            {
                if (numircprice.Value > 0)
                {
                    if(cbxmonth.Text=="")
                    {
                        MessageBox.Show("من فضلك اختر الشهر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(Convert.ToInt32(Properties.Settings.Default.month)!=Convert.ToInt32(cbxmonth.Text)&& radiostudentpaysinmonth.Checked == true )
                    {
                        MessageBox.Show("الشهر الذي قمت بتحديده ليس هو الشهر الحالي من فضلك تاكد من البيانات؟", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lblmoney.Text = Convert.ToDecimal(numircprice.Value).ToString();
                    string person_id = "0";
                    int stu_id = 0;

                    person_id = Convert.ToString(dgvperson.CurrentRow.Cells[0].Value);
                    lblperson_id.Text = person_id.ToString();
                    lblpersonname.Text = Convert.ToString(dgvperson.CurrentRow.Cells[1].Value);
                    lblmarhala.Text= Convert.ToString(dgvperson.CurrentRow.Cells[2].Value);
                    int marhala_id= Convert.ToInt32(dgvperson.CurrentRow.Cells[3].Value);
                    lblmarhala_id.Text = marhala_id.ToString();
                    lblmonth.Text = cbxmonth.Text.ToString();
                    stu_id = Convert.ToInt32(dgvperson.CurrentRow.Cells[4].Value);
                    lblstu_id.Text = stu_id.ToString();
                    lblactivation.Text = Convert.ToString(dgvperson.CurrentRow.Cells[5].Value);
                }
                
            }

        }

        private void print_kabd()
        {
            try
            {
                int id = Convert.ToInt32(txtorder_id.Text);

                DataTable tblprint = new DataTable();
                tblprint.Clear();
                tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو', settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.discriptionnn as'الوصف الفاتوره',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3', sand_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',sand_type as'نوع السند', date as'التاريخ',notes as'ملاحظات',money as'المبلغ',marhal_name as'المرحله',description as'البيان',student_code as'كود الطالببب' from sand_kabd_estrdad,settingprinting_bills where sand_id=" + id+"", "");
                printing frm = new printing();
                frm.crystalReportViewer1.RefreshReport();

               sand_kabd  rpt = new sand_kabd() ;
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
            DataTable tblcheeck = new DataTable();
            tblcheeck.Clear();
            tblcheeck = db.readdata("select*from madfou3aat_details where student_code=N'"+lblperson_id.Text+"' and month="+lblmonthh.Text+" and year="+lblyear.Text+ " and type=N'مصاريف شهر'", "");
           // string order_idinmadfou3aatbefore = Convert.ToString(tblcheeck.Rows[0][0]);
            if(tblcheeck.Rows.Count>0&&radiostudentpaysinmonth.Checked==true)
            {
                MessageBox.Show("هذا الطالب قام بدفع نفس الشهر من قبل تاكد من البيانات رقم الدفع هو", "تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (tblcheeck.Rows.Count > 0 && radiostudentpaysinmonth.Checked == true)
            {
                MessageBox.Show("هذا الطالب قام بدفع نفس الشهر من قبل تاكد من البيانات رقم الدفع هو", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string d = "", type = "", t = "";
            d = dtp.Value.ToString("yyyy-MM-dd");
            t = dtp.Value.ToString("HH-MM");
            type = "سداد مصاريف";
            if (lblmoney.Text == "0")
            {
                MessageBox.Show("من فضلك قم بتحدد المبلغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblperson_id.Text == "0")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lblpersonname.Text == "-")
            {
                MessageBox.Show("من فضلك قم باختيار الشخص", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(radiokabd.Checked==false&&radioestrdad.Checked==false&&radiostudentpaysinmonth.Checked==false&&radiobooksestrdad.Checked==false)
            {
                MessageBox.Show("من فضلك قم باختيار عمليه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //DataTable tblactivation = new DataTable();
                //tblactivation.Clear();
                //tblactivation = db.readdata("select", "");
                if (radiokabd.Checked == true)
                {
                    string typekabd = "قبض";
                    string descriptionkabd = "قام الطالب  " + " " + lblpersonname.Text + " " + "بدفع مصاريف مذكرات بمبلغ" + " " + lblmoney.Text + " " + "جنيه-في شهر"+" "+cbxmonth.Text;
                    db.excutedata("insert into sand_kabd_estrdad values(" + txtorder_id.Text + "," +lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + type + "',N'" + txtnotes.Text.Trim() + "'," + lblmoney.Text + ",N'" + Properties.Settings.Default.user_name + "',N'" + d + "',N'" + lblmarhala.Text + "',N'" + descriptionkabd + "',N'"+lblperson_id.Text+"')", "");

                    //الخزنه
                    db.excutedata("update stoke_money set money=money+" + lblmoney.Text + " where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,order_id2) values (" + stoke_id + "," + lblmoney.Text + ",N'" + d + "',N'" + descriptionkabd + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "'," + txtorder_id.Text + ")", "");
                    db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionkabd + "',N'" + d + "',0,N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", "");
                  db.excutedata("insert into madfou3aat_details values("+txtorder_id.Text+","+ lblstu_id.Text+",N'"+lblpersonname.Text+"',N'"+d+"',N'"+lblday.Text+"',N'"+lblmonthh.Text+"',N'"+lblyear.Text+"',N'"+Properties.Settings.Default.user_name+"',"+lblmoney.Text+",N'"+typekabd+"',"+lblmarhala_id.Text+",N'"+lblperson_id.Text+"',"+Convert.ToInt32(lblactivation.Text)+")", "");
                    MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    print_kabd();
                    autonumber();

                }
                else if (radiostudentpaysinmonth.Checked == true)
                {
                    string typemonth = "مصاريف شهر";
                    // string descriptionkabd = "قام الطالب  " + " " + lblpersonname.Text + " " + "بدفع المبلغ" + " " + lblmoney.Text + " " + "جنيه";
                    string descriptionkabd = "قام الطالب  " + " " + lblpersonname.Text + " " + "بدفع المبلغ" + " " + lblmoney.Text + " " + "جنيه-لشهر" + " " + cbxmonth.Text;

                    db.excutedata("insert into sand_kabd_estrdad values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + type + "',N'" + txtnotes.Text.Trim() + "'," + lblmoney.Text + ",N'" + Properties.Settings.Default.user_name + "',N'" + d + "',N'" + lblmarhala.Text + "',N'" + descriptionkabd + "',N'"+lblperson_id.Text+"')", "");

                    //الخزنه
                    db.excutedata("update stoke_money set money=money+" + lblmoney.Text + " where stoke_id=" + stoke_id + "", "");
                    db.excutedata("insert into stoke_insert(stoke_id,money,date,name,type,notes,user_name,order_id2) values (" + stoke_id + "," + lblmoney.Text + ",N'" + d + "',N'" + descriptionkabd + "',N'" + type + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "'," + txtorder_id.Text + ")", "");
                    db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionkabd + "',N'" + d + "',0,N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", "");
                    db.excutedata("insert into madfou3aat_details values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + d + "',N'" + lblday.Text + "',N'" + lblmonthh.Text + "',N'" + lblyear.Text + "',N'" + Properties.Settings.Default.user_name + "'," + lblmoney.Text + ",N'" + typemonth + "',N'"+lblmarhala_id.Text+"',N'"+lblperson_id.Text+"',"+Convert.ToInt32(lblactivation.Text)+")", "");


                    if (lblmonth.Text =="1")
                            {
                                db.excutedata("update student_madfou3aat set mon_1=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "2")
                            {
                                db.excutedata("update student_madfou3aat set mon_2=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "3")
                            {
                                db.excutedata("update student_madfou3aat set mon_3=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "4")
                            {
                                db.excutedata("update student_madfou3aat set mon_4=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "5")
                            {
                                db.excutedata("update student_madfou3aat set mon_5=" + lblmoney.Text + ",date=N'" + d + "' where student_id=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "6")
                            {
                                db.excutedata("update student_madfou3aat set mon_6=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "7")
                            {
                                db.excutedata("update student_madfou3aat set mon_7=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "8")
                            {
                                db.excutedata("update student_madfou3aat set mon_8=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "9")
                            {
                                db.excutedata("update student_madfou3aat set mon_9=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "10")
                            {
                                db.excutedata("update student_madfou3aat set mon_10=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "11")
                            {
                                db.excutedata("update student_madfou3aat set mon_11=" + lblmoney.Text + ",date=N'" + d + "' where student_code='" + lblperson_id.Text + "' ", "");

                            }
                            if (lblmonth.Text == "12")
                            {
                                db.excutedata("update student_madfou3aat set mon_12=" + lblmoney.Text + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");

                            }
                            MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            print_kabd();
                            autonumber();
                    txtpersonnamesearch.Focus();
                    
                    //MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //print_kabd();
                    //autonumber();
                }
                //===========================================================
                if(radiobooksestrdad.Checked==true)
                {
                   
                    string d1 = "";
                    d1= dtp.Value.ToString("yyyy-MM-dd");
                    decimal money = Convert.ToDecimal(lblmoney.Text);
                    if(dgv.Rows.Count>=1)
                    {
                        int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                        if (dgvperson.Rows.Count >= 1)
                        {

                            decimal moneypaid = 0;
                            moneypaid= Convert.ToDecimal(dgv.CurrentRow.Cells[4].Value);
                            if (numircprice.Value != moneypaid)
                            {
                                MessageBox.Show("من فضلك تاكد من المبلغ المدفوع فلوس المذكرات المدفوعه من قبل لاتساوي هذا المبلغ المكتوب الان", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (MessageBox.Show("هل انت متاكد من استرداد مصاريف مذكرات هذا الطالب", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {


                                string description = "قام الطالب " + " " + lblpersonname.Text + " " + "باسترداد مصاريف المذكرات في المرحله" + " " + cbx.Text;
                                 db.excutedata("update madfou3aat_details set money="+money+" ,type=N'استرداد مصاريف مذكرات' where order_id=" + id+"", "");
                                //db.excutedata("delete from madfou3aat_details where order_id=" + id + "", "");
                                db.excutedata("insert into student_estrdad_book_money (order_id,old_order_id,student_id,student_code,student_name,marhala_id,marhala_name,date,money,type,description,user_name) values("+txtorder_id.Text+"," + id + "," + lblstu_id.Text + ",N'" + lblperson_id.Text.Trim() + "',N'" + lblpersonname.Text.Trim() + "'," + cbx.SelectedValue + ",N'" + cbx.Text + "',N'" + d1 + "'," + lblmoney.Text + ",N'استرداد مصاريف مذكرات',N'" + txtnotes.Text.Trim() + "',N'" + Properties.Settings.Default.user_name + "')", "تم سحب المبلغ بنجاح");
                                int stoke_id = Convert.ToInt32(Properties.Settings.Default.stoke_id);
                                db.excutedata("update stoke_money set money=money-"+money+" where stoke_id="+stoke_id+"", "");

                                db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,order_id2) values("+stoke_id+","+money+",N'"+d1+"',N'"+description+"',N'استرداد مصاريف مذكرات',N'"+txtnotes.Text.Trim()+"',N'"+Properties.Settings.Default.user_name+"',"+txtorder_id.Text+")", "");
                                autonumber();
                                tbl.Clear();
                                dgv.DataSource = tbl;
                            }
                        }
                    }
                }








                //===================================================================
                else if (radioestrdad.Checked == true)
                {
                
                    tbl.Clear();
                    tbl = db.readdata("select*from stoke_money where stoke_id=" + stoke_id + "", "");
                    if (numircprice.Value > Convert.ToDecimal(tbl.Rows[0][1]))
                    {
                        MessageBox.Show("المبلغ المراد سحبه اكبر من المبلغ الموجود في الخزنه من فضلك راجع بياناتك", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {

                        string typeestrdad = "استرداد مبلغ";
                        string descriptionestrdad = "قام الطالب  " + " " + lblpersonname.Text + " " + "باسترداد المبلغ" + " " + lblmoney.Text + " " + "جنيه";
                        db.excutedata("insert into sand_kabd_estrdad values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + typeestrdad + "',N'" + txtnotes.Text.Trim() + "'," + lblmoney.Text + ",N'" + Properties.Settings.Default.user_name + "',N'" + d + "',N'" + lblmarhala.Text + "',N'" + descriptionestrdad + "',N'"+lblperson_id.Text+"')", "");

                        //الخزنه
                        db.excutedata("update stoke_money set money=money-" + lblmoney.Text + " where stoke_id=" + stoke_id + "", "");
                        db.excutedata("insert into stoke_withdrowal(stoke_id,money,date,name,type,notes,user_name,order_id2) values (" + stoke_id + "," + lblmoney.Text + ",N'" + d + "',N'" + descriptionestrdad + "',N'" + typeestrdad + "',N'" + txtnotes.Text + "',N'" + Properties.Settings.Default.user_name + "'," + txtorder_id.Text + ")", "");
                        db.excutedata("insert into student_account values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + descriptionestrdad + "',N'" + d + "',0,N'" + Properties.Settings.Default.user_name + "'," + lblmarhala_id.Text + ",N'" + lblmarhala.Text + "',N'"+lblperson_id.Text+"')", "");
                        db.excutedata("insert into madfou3aat_details values(" + txtorder_id.Text + "," + lblstu_id.Text + ",N'" + lblpersonname.Text + "',N'" + d + "',N'" + lblday.Text + "',N'" + lblmonthh.Text + "',N'" + lblyear.Text + "',N'" + Properties.Settings.Default.user_name + "'," + lblmoney.Text + ",N'" + typeestrdad + "',N'"+lblmarhala_id.Text+"',N'"+lblperson_id.Text+"',"+Convert.ToInt32(lblactivation.Text)+")", "");
                        //student_salary frm = new student_salary();
                        //frm.ShowDialog();


                        decimal money = Convert.ToDecimal(numircprice.Value) * -1;
                        if (lblmonth.Text =="1")
                        {
                            db.excutedata("update student_madfou3aat set mon_1=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'"+lblmonth.Text+"'", "");

                        }
                        if (lblmonth.Text == "2")
                        {
                            db.excutedata("update student_madfou3aat set mon_2=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");


                        }
                        if (lblmonth.Text == "3")
                        {
                            db.excutedata("update student_madfou3aat set mon_3=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "4")
                        {
                            db.excutedata("update student_madfou3aat set mon_4=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "5")
                        {
                            db.excutedata("update student_madfou3aat set mon_5=" + money + ",date=N'" + d + "' where student_id=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");
                        }
                        if (lblmonth.Text == "6")
                        {
                            db.excutedata("update student_madfou3aat set mon_6=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "7")
                        {
                            db.excutedata("update student_madfou3aat set mon_7=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "8")
                        {
                            db.excutedata("update student_madfou3aat set mon_8=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "9")
                        {
                            db.excutedata("update student_madfou3aat set mon_9=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "10")
                        {
                            db.excutedata("update student_madfou3aat set mon_10=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "11")
                        {
                            db.excutedata("update student_madfou3aat set mon_11=" + money + ",date=N'" + d + "' where student_code='" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }
                        if (lblmonth.Text == "12")
                        {
                            db.excutedata("update student_madfou3aat set mon_12=" + money + ",date=N'" + d + "' where student_code=N'" + lblperson_id.Text + "' ", "");
                            db.excutedata("update madfou3aat_details set type=N'لم يقومو بالدفع' , money=" + money + ",date=N'" + d + "' where  type=N'مصاريف شهر' and  student_code=N'" + lblperson_id.Text + "' and month=N'" + lblmonth.Text + "'", "");

                        }







                        MessageBox.Show("تم الاستقبال بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        print_kabd();
                        autonumber();


                    }
                }
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

            paneldeletestudent.Visible = true;
            }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (radiofatra.Checked == true)
            {
                string from = "", to = "";
                from = dtpsearch.Value.ToString("yyyy-MM-dd");
                to = dtpto.Value.ToString("yyyy-MM-dd");
                tbl = db.readdata("select sand_id as 'رقم البيان',student_name as'اسم الطالب',sand_type as'نوع البيان',money as'المبلغ',date as'التاريخ',description as'البيان' from sand_kabd_estrdad where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "'", "");
                dgv.DataSource = tbl;
            }
            else if (radiosandnumbersearch.Checked == true)
            {
                if (txtsandnumbersearch.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم السند اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    tbl.Clear();
                    tbl = db.readdata("select sand_id as 'رقم البيان',student_name as'اسم الطالب',sand_type as'نوع البيان',money as'المبلغ',date as'التاريخ',description as'البيان' from sand_kabd_estrdad where sand_id =" + txtsandnumbersearch.Text.Trim() + "", "");
                    dgv.DataSource = tbl;
                }
            }
            else if(radiosearchwithstudent_name.Checked==true)
            {
                string from = "", to = "";
                from = dtpsearch.Value.ToString("yyyy-MM-dd");
                to = dtpto.Value.ToString("yyyy-MM-dd");
                tbl = db.readdata("select sand_id as 'رقم البيان',student_name as'اسم الطالب',sand_type as'نوع البيان',money as'المبلغ',date as'التاريخ',description as'البيان' from sand_kabd_estrdad where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "' and student_name like N'%"+txtpersonnamesearch.Text.Trim()+"%'", "");
                dgv.DataSource = tbl;
            }
            else if(radiosearchwithcode.Checked==true)
            {
                if (txtpersonnamesearch.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل كود الطالب في خانه البحث", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string from = "", to = "";
                    from = dtpsearch.Value.ToString("yyyy-MM-dd");
                    to = dtpto.Value.ToString("yyyy-MM-dd");
                    tbl = db.readdata("select sand_id as 'رقم البيان',student_name as'اسم الطالب',sand_type as'نوع البيان',money as'المبلغ',date as'التاريخ',description as'البيان' from sand_kabd_estrdad where convert(nvarchar,date,105)between N'" + from + "' and N'" + to + "' and student_code =N'" + txtpersonnamesearch.Text.Trim() + "'", "");
                    dgv.DataSource = tbl;
                }
            }


             if(cbxothersearch.Text=="مذكرات")
            {
               if(dgvperson.Rows.Count<=0)
                {
                    MessageBox.Show("من فضلك حدد اسم الطالب اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               else
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select order_id as'رقم العمليه',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ',type as'نوع العمليه' from madfou3aat_details where student_id="+dgvperson.CurrentRow.Cells[4].Value+ " and type=N'قبض'", "");
                    dgv.DataSource = tblsearch;
                }
            }

             if(cbxothersearch.Text=="مصاريف شهر")
            {
                if (dgvperson.Rows.Count <= 0)
                {
                    MessageBox.Show("من فضلك حدد اسم الطالب اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select order_id as'رقم العمليه',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ',type as'نوع العمليه' from madfou3aat_details where student_id=" + dgvperson.CurrentRow.Cells[4].Value + " and type=N'مصاريف شهر'", "");
                    dgv.DataSource = tblsearch;
                }
            }


            if (cbxothersearch.Text == "استرداد مصاريف")
            {
             
                if (dgvperson.Rows.Count <= 0)
                {
                    MessageBox.Show("من فضلك حدد اسم الطالب اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select order_id as'رقم العمليه',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ',type as'نوع العمليه' from madfou3aat_details where student_id=" + dgvperson.CurrentRow.Cells[4].Value + " and type=N'استرداد مبلغ'", "");
                    dgv.DataSource = tblsearch;
                }
            }

            if(cbxothersearch.Text== "استرداد مصاريف مذكرات")
            {
                if (dgvperson.Rows.Count <= 0)
                {
                    MessageBox.Show("من فضلك حدد اسم الطالب اولا", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readdata("select order_id as'رقم العمليه',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ',type as'نوع العمليه' from madfou3aat_details where student_id=" + dgvperson.CurrentRow.Cells[4].Value + " and type=N'استرداد مصاريف مذكرات'", "");
                    dgv.DataSource = tblsearch;
                }

            }

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            if (radiowhopay.Checked == false)
            {
                try
                {
                    if (dgv.Rows.Count >= 1)
                    {
                        int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                        DataTable tblprint = new DataTable();
                        tblprint.Clear();
                        tblprint = db.readdata("select settingprinting_bills.logo as 'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.discriptionnn as'الوصف الفاتوره',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3', sand_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',sand_type as'نوع السند', date as'التاريخ',notes as'ملاحظات',money as'المبلغ',marhal_name as'المرحله',description as'البيان',student_code as 'كود الطالبببببب' from sand_kabd_estrdad,settingprinting_bills where sand_id=" + id + "", "");
                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();

                        sand_kabd rpt = new sand_kabd();
                        rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                        rpt.SetDataSource(tblprint);
                        rpt.SetParameterValue("id", id);

                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm.ShowDialog();
                        //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                        //rpt.PrintToPrinter(1, true, 0, 0);
                    }
                }
                catch (Exception) { }

            }

            if(radiowhopay.Checked==true)
            {
                try
                {
                    if (dgv.Rows.Count >= 1)
                    {

                        //string type = "قبض";
                        //if (cbxothersearch.Text == "مذكرات")
                        //{
                        //    type = "قبض";
                        //}
                        //else if (cbxothersearch.Text == "مصاريف شهر")
                        //{
                        //    type = "مصاريف شهر";
                        //}
                        //else if (cbxothersearch.Text == "استرداد مصاريف")
                        //{
                        //    type = "استرداد مبلغ";
                        //}
                        ////else if (cbxothersearch.Text == "استرداد مصاريف مذكرات")
                        ////{
                        ////    type = "استرداد مصاريف مذكرات";
                        ////}
                        //tbl.Clear();

                        //tbl = db.readdata("select order_id as'رقم العمليه',student_id as'رقم الطالب',student_code as'كود الطالب',student_name as'اسم الطالب',money as'المبلغ',type as'النوع',date as'التاريخ'  from madfou3aat_details where student_id=" + dgv.CurrentRow.Cells[0].Value + " and type=N'" + type + "'", "");
                        //dgv.DataSource = tbl;
                        //int order_id = Convert.ToInt32(tbl.Rows[0][0]);





                        int id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

                        //lblorder_id.Text = id.ToString();

                        DataTable tblprint = new DataTable();
                        tblprint.Clear();
                        //tblprint = db.readdata("select settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.discriptionnn as'الوصف الفاتوره',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3',select order_id as'رقم العمليه',student_id as'رقم الطالب',student_code as'كود الطالب',student_name as'اسم الطالب',money as'المبلغ',type as'النوع',date as'التاريخ'  from madfou3aat_details,settingprinting_bills where order_id=" + id + "", "");
                        tblprint = db.readdata("select settingprinting_bills.logo as'اللوجو',settingprinting_bills.name as'اسم الشركه',settingprinting_bills.address as'العنوان',settingprinting_bills.discriptionnn as'الوصف الفاتوره',settingprinting_bills.phone1 as'فون1',settingprinting_bills.phone2 as'فون2',settingprinting_bills.phone3 as'فون3', sand_id as'رقم البيان',student_id as'كود الطالب',student_name as'اسم الطالب',sand_type as'نوع السند', date as'التاريخ',notes as'ملاحظات',money as'المبلغ',marhal_name as'المرحله',description as'البيان',student_code as 'كود الطالبببببب' from sand_kabd_estrdad,settingprinting_bills where sand_id=" + id + "", "");

                        printing frm = new printing();
                        frm.crystalReportViewer1.RefreshReport();

                        sand_kabd rpt = new sand_kabd();
                        rpt.SetDatabaseLogon("", "", Properties.Settings.Default.servername, Properties.Settings.Default.databasename);
                        rpt.SetDataSource(tblprint);
                        rpt.SetParameterValue("id", id);

                        frm.crystalReportViewer1.ReportSource = rpt;
                        frm.ShowDialog();
                        //System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();
                        //rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;
                        //rpt.PrintToPrinter(1, true, 0, 0);
                    }
                }
                catch (Exception) { }
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            lblday.Text = dtp.Value.Day.ToString();
            lblmonthh.Text = dtp.Value.Month.ToString();
            lblyear.Text = dtp.Value.Year.ToString();
        }

        private void btnothersearch_Click(object sender, EventArgs e)
        {
            db.excutedata("delete from notpaybooks", "");

            if (radiowhonotpay.Checked == false && radiowhopay.Checked == false)
            {
                MessageBox.Show("من فضلك حدد المرحله التي تريد البحث عنها ثم قم بتحديد نوع البحث من قام بالدفع او من لم يقم علي حسب اختيارك", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            DataTable tblstudentdo = new DataTable();
            tblstudentdo.Clear();
            if (cbxothersearch.Text == "مذكرات")
            {
                tblstudentdo = db.readdata("select*from madfou3aat_details where type=N'قبض' and month=" + cbxmonth.Text + " and marhala_id=" + cbx.SelectedValue + " and activation=1", "");
            }
            else if (cbxothersearch.Text == "مصاريف شهر")
            {
                tblstudentdo = db.readdata("select*from madfou3aat_details where type=N'مصاريف شهر' and month=" + cbxmonth.Text + " and marhala_id=" + cbx.SelectedValue + " and activation=1", "");

            }
            else if (cbxothersearch.Text == "استرداد مصاريف")
            {
                tblstudentdo = db.readdata("select*from madfou3aat_details where type=N'استرداد مبلغ' and month=" + cbxmonth.Text + " and marhala_id=" + cbx.SelectedValue + " and activation=1", "");

            }
            else if (cbxothersearch.Text == "استرداد مصاريف مذكرات")
            {

                tblstudentdo = db.readdata("select*from madfou3aat_details where type=N'استرداد مصاريف مذكرات' and month=" + cbxmonth.Text + " and marhala_id=" + cbx.SelectedValue + " and activation=1", "");

            }
            DataTable tblallstudent = new DataTable();
            //tblallstudent.Clear();
            tblallstudent = db.readdata("select*from student_data where marhal_id=" + cbx.SelectedValue + " and activation=1", "");





            for (int i = 0; i <= tblallstudent.Rows.Count - 1; i++)
            {
                //studentid=Convert.ToInt32( tblallstudent.Rows[i][0]);


                //if (Convert.ToDecimal(tblallstudent.Rows[i][0]) !=studentdo)
                //{
                //    db.excutedata("insert into notpaybooks values(" + tblallstudent.Rows[i][0] + ",N'" + tblallstudent.Rows[i][1] + "',N'not pay book',N'" + tblallstudent.Rows[i][3] + "'," + tblallstudent.Rows[i][2] + ",N'" + tblallstudent.Rows[i][10] + "'," + tblallstudent.Rows[i][11] + ",N'" + tblallstudent.Rows[i][12] + "')", "");
                //}
                //else if (Convert.ToInt32(tblallstudent.Rows[i][0]) == studentdo)
                //{


                //    db.excutedata("insert into notpaybooks values(" + tblallstudent.Rows[i][0] + ",N'" + tblallstudent.Rows[i][1] + "',N'pay book',N'" + tblallstudent.Rows[i][3] + "'," + tblallstudent.Rows[i][2] + ",N'" + tblallstudent.Rows[i][10] + "'," + tblallstudent.Rows[i][11] + ",N'" + tblallstudent.Rows[i][12] + "')", "");

                //}


                db.excutedata("insert into notpaybooks values(" + tblallstudent.Rows[i][0] + ",N'" + tblallstudent.Rows[i][1] + "',N'not pay book',N'" + tblallstudent.Rows[i][3] + "'," + tblallstudent.Rows[i][2] + ",N'" + tblallstudent.Rows[i][10] + "'," + tblallstudent.Rows[i][11] + ",N'" + tblallstudent.Rows[i][12] + "')", "");

                for (int y = 0; y <= tblstudentdo.Rows.Count - 1; y++)
                {
                    if (Convert.ToDecimal(tblallstudent.Rows[i][0]) == Convert.ToInt32(tblstudentdo.Rows[y][1]))
                    {
                        int student_id = Convert.ToInt32(tblstudentdo.Rows[y][1]);


                        db.excutedata("insert into notpaybooks values(" + tblallstudent.Rows[i][0] + ",N'" + tblallstudent.Rows[i][1] + "',N'pay book',N'" + tblallstudent.Rows[i][3] + "'," + tblallstudent.Rows[i][2] + ",N'" + tblallstudent.Rows[i][10] + "'," + tblallstudent.Rows[i][11] + ",N'" + tblallstudent.Rows[i][12] + "')", "");
                        db.excutedata("delete from notpaybooks where student_id=" + student_id + "", "");

                    }

                }

            }





            DataTable tblsearch111 = new DataTable();
            tblsearch111.Clear();

            if (cbxothersearch.Text == "مذكرات")
            {


                if (radiowhopay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ',type as'-' from madfou3aat_details where type=N'قبض' and marhala_id=" + cbx.SelectedValue + " and activation=1", "");
                    dgv.DataSource = tblsearch111;
                }
                else if (radiowhonotpay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'رقم البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',magmo3a_name as'المجموعه' from notpaybooks ", "");
                    dgv.DataSource = tblsearch111;
                }
            }
            else if (cbxothersearch.Text == "مصاريف شهر")
            {
                if (radiowhopay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ' from madfou3aat_details where type=N'مصاريف شهر' and marhala_id=" + cbx.SelectedValue + " and activation=1 ", "");
                    dgv.DataSource = tblsearch111;
                }
                else if (radiowhonotpay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'رقم البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',magmo3a_name as'المجموعه' from notpaybooks ", "");
                    dgv.DataSource = tblsearch111;
                }
            }
            else if (cbxothersearch.Text == "استرداد مصاريف")
            {
                if (radiowhopay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ' from madfou3aat_details where type=N'استرداد مبلغ' and marhala_id=" + cbx.SelectedValue + " and activation=1 ", "");
                    dgv.DataSource = tblsearch111;
                }
                else if (radiowhonotpay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'رقم البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',magmo3a_name as'المجموعه' from notpaybooks ", "");
                    dgv.DataSource = tblsearch111;
                }
            }

            else if (cbxothersearch.Text == "استرداد مصاريف مذكرات")
            {
                if (radiowhopay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'تسلسل البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',date as'التاريخ',money as'المبلغ' from madfou3aat_details where type=N'استرداد مصاريف مذكرات' and marhala_id=" + cbx.SelectedValue + " and activation=1 ", "");
                    dgv.DataSource = tblsearch111;
                }
                else if (radiowhonotpay.Checked == true)
                {
                    tblsearch111 = db.readdata("select student_id as'رقم البرنامج',student_code as'كود الطالب',student_name as'اسم الطالب',marhala_name as'المرحله',magmo3a_name as'المجموعه' from notpaybooks ", "");
                    dgv.DataSource = tblsearch111;
                }
            }


        //    if (dgv.Rows.Count >= 1)
        //    {
        //        string type = "قبض";
        //        if (cbxothersearch.Text == "مذكرات")
        //        {
        //            type = "قبض";
        //        }
        //        else if (cbxothersearch.Text == "مصاريف شهر")
        //        {
        //            type = "مصاريف شهر";
        //        }
        //        else if (cbxothersearch.Text == "استرداد مصاريف")
        //        {
        //            type = "استرداد مبلغ";
        //        }
        //        //else if (cbxothersearch.Text == "استرداد مصاريف مذكرات")
        //        //{
        //        //    type = "استرداد مصاريف مذكرات";
        //        //}
        //        tbl.Clear();

        //        tbl = db.readdata("select order_id as'رقم العمليه',student_id as'رقم الطالب',student_code as'كود الطالب',student_name as'اسم الطالب',money as'المبلغ',type as'النوع',date as'التاريخ'  from madfou3aat_details where student_id=" + dgv.CurrentRow.Cells[0].Value + " and type=N'" + type + "'", "");
        //        dgv.DataSource = tbl;
        //    }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            student_salary frm = new student_salary();
            frm.ShowDialog();
        }

        private void radiokabd_CheckedChanged(object sender, EventArgs e)
        {
            if (radiokabd.Checked == true)
            {
                txtnotes.Text = "دفع مصاريف مذكرات";
                numircprice.Value = 0;
                numircprice.Enabled = true;
            }
            else
            {
                txtnotes.Text = "";
            }
        }

        private void radiostudentpaysinmonth_CheckedChanged(object sender, EventArgs e)
        {
            if(radiostudentpaysinmonth.Checked==true)
            {
                txtnotes.Text = "مصاريف الطالب الشهريه"+ " " + "لشهر" + cbxmonth.Text;
                numircprice.Enabled = false;
                DataTable tblmarhalaprice = new DataTable();
                tblmarhalaprice.Clear();
                tblmarhalaprice = db.readdata("select*from groups where group_id=" + cbx.SelectedValue + "", "");
                numircprice.Value = Convert.ToDecimal(tblmarhalaprice.Rows[0][3]);
            }
            else
            {
                txtnotes.Text = "";
            }
        }

        private void radioestrdad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioestrdad.Checked == true)
            {
                txtnotes.Text = "استرداد الطالب للمصاريف الشهريه"+" "+"لشهر"+cbxmonth.Text;
                numircprice.Enabled = false;
                DataTable tblmarhalaprice = new DataTable();
                tblmarhalaprice.Clear();
                tblmarhalaprice = db.readdata("select*from groups where group_id=" + cbx.SelectedValue + "", "");
                numircprice.Value = Convert.ToDecimal(tblmarhalaprice.Rows[0][3]);
            }
            else
            {
                txtnotes.Text = "";
            }
        }

        private void radiobooksestrdad_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobooksestrdad.Checked == true)
            {
                txtnotes.Text = "استرداد الطالب لمصاريف المذكرات" + " " + "في شهر" + cbxmonth.Text;
                numircprice.Value = 0;
                numircprice.Enabled = true;
            }
            else
            {
                txtnotes.Text = "";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count >= 1)
            {
                string type = "قبض";
                if (cbxothersearch.Text == "مذكرات")
                {
                    type = "قبض";
                }
                else if (cbxothersearch.Text == "مصاريف شهر")
                {
                    type = "مصاريف شهر";
                }
                else if (cbxothersearch.Text == "استرداد مصاريف")
                {
                    type = "استرداد مبلغ";
                }
                //else if (cbxothersearch.Text == "استرداد مصاريف مذكرات")
                //{
                //    type = "استرداد مصاريف مذكرات";
                //}
                tbl.Clear();

                tbl = db.readdata("select order_id as'رقم العمليه',student_id as'رقم الطالب',student_code as'كود الطالب',student_name as'اسم الطالب',money as'المبلغ',type as'النوع',date as'التاريخ'  from madfou3aat_details where student_id=" + dgv.CurrentRow.Cells[0].Value + " and type=N'" + type + "'", "");
                dgv.DataSource = tbl;
            }
        }

        private void cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (radiostudentpaysinmonth.Checked == true || radioestrdad.Checked == true)
                {
                    DataTable tblmarhalaprice = new DataTable();
                    tblmarhalaprice.Clear();
                    tblmarhalaprice = db.readdata("select*from groups where group_id=" + cbx.SelectedValue + "", "");
                    numircprice.Value = Convert.ToDecimal(tblmarhalaprice.Rows[0][3]);
                }
            }
            catch (Exception) { }
        }

        private void btnopnprice_Click(object sender, EventArgs e)
        {
            panelopenprice.Visible = true;
        }

        private void btnclosedelete_Click(object sender, EventArgs e)
        {
            panelopenprice.Visible = false;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            if(txtuser.Text==""||txtpassword.Text=="")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم وكلمه المرور", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable tblcheckuser = new DataTable();
            tblcheckuser.Clear();
            tblcheckuser = db.readdata("select*from addnew_users where type=N'مدير' and user_name=N'" + txtuser.Text.Trim() + "' and user_password=N'" + txtpassword.Text.Trim() + "'", "");
            if (tblcheckuser.Rows.Count >= 1)
            {
                if (Convert.ToString(tblcheckuser.Rows[0][1]) == txtuser.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][2]) == txtpassword.Text.Trim() && Convert.ToString(tblcheckuser.Rows[0][3]) == "مدير")
                {
                    numircprice.Enabled = true;
                }
                else
                {
                    MessageBox.Show("انت لست لك الصلاحيه لفتح   هذه الخانه", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("بيانات المستخدم خطا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                    if (MessageBox.Show("هل انت متاكد من مسح هذا السند ؟ ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (dgv.Rows.Count >= 1)
                        {
                            int order_id = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                            decimal money = Convert.ToDecimal(dgv.CurrentRow.Cells[3].Value);

                            db.excutedata("delete from student_account where order_id=" + order_id + "", "");
                            db.excutedata("delete from stoke_insert where order_id2=" + order_id + "", "");
                            db.excutedata("update stoke_money set money=money-" + money + " where stoke_id=" + Properties.Settings.Default.stoke_id + "", "");
                            db.excutedata("delete from sand_kabd_estrdad where sand_id=" + order_id + "", "");
                            db.excutedata("delete from madfou3aat_details where order_id=" + order_id + "", "");
                            MessageBox.Show("تم تنفيذ العمليه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            paneldeletestudent.Visible = false;
                        }
                    else
                    {
                        MessageBox.Show("انت لست لك الصلاحيه لمسح  بيانات هذا البيان", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    }
                }
                else
                {
                    MessageBox.Show("بيانات المستخدم خطا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            paneldeletestudent.Visible = false;
        }
    }
}