using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;


namespace Center_Learning
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        int user_id =0;
        

        private bool checkuser(string filed, string table)
        {
            tbl.Clear();
            tbl = db.readdata("select*from addnew_users where user_name=N'" +Properties.Settings.Default.user_name +"'", "");
            user_id = Convert.ToInt32(tbl.Rows[0][0]);
            DataTable tblsearch = new DataTable();
            tblsearch.Clear();
            tblsearch = db.readdata("select " + filed + " from " + table + " where user_id=" + user_id + string.Empty, string.Empty);
            if (Convert.ToInt32(tblsearch.Rows[0][0]) == 0)
            {
                MessageBox.Show("انت غير مسموح لك بفتح هذه الشاشه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("magmou3aat", "user_settings");
            if (check == true)
            {
                magmou3a frm = new magmou3a();
                frm.ShowDialog();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("marahel", "user_settings");
            if (check == true)
            {
                mrahel frm = new mrahel();
                frm.ShowDialog();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = checkuser("student_data", "user_settings");
            if (check == true)
            {
                student_data frm = new student_data();
                frm.ShowDialog();
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("student_attendans", "user_settings");
            if (check == true)
            {
                absentandattendance frm = new absentandattendance();
                frm.ShowDialog();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("student_attendans_reports", "user_settings");
            if (check == true)
            {
                attendans_reports frm = new attendans_reports();
                frm.ShowDialog();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("expenses_type", "user_settings");
            if (check == true)
            {

                expenses_type frm = new expenses_type();
                frm.ShowDialog();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("expeses", "user_settings");
            if (check == true)
            {
                expenses frm = new expenses();
                frm.ShowDialog();
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("add_stoke", "user_settings");
            if (check == true)
            {
                add_stoke frm = new add_stoke();
                frm.ShowDialog();
            }
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("eda3_inkhazna", "user_settings");
            if (check == true)
            {
                eda3in_khazna frm = new eda3in_khazna();
                frm.ShowDialog();
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("withdrowalfromstoke", "user_settings");
            if (check == true)
            {
                withdrowalfrom_stoke frm = new withdrowalfrom_stoke();
                frm.ShowDialog();
            }
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                  bool check = checkuser("copy_data", "user_settings");
                if (check == true)
                {
                    string d = string.Empty;
                d = DateTime.Now.Date.ToString("dd-MM-yyyy");
                SaveFileDialog open = new SaveFileDialog();
                open.Filter = "backup files (*.back)|*.back";
                open.FileName = "Center_backup_"+d;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    db.excutedata(@"backup database Center__Learning To Disk='" + open.FileName + "'", "تم اخذ نسخه احتياطيه");
                }
               }
            }

            catch (Exception)
            { }
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                bool check = checkuser("copy_return", "user_settings");
                if (check == true)
                {

                    Server server = new Server(Properties.Settings.Default.servername);
                    Microsoft.SqlServer.Management.Smo.Database db = server.Databases[Properties.Settings.Default.databasename];
                    if (db != null)
                    {
                        server.KillAllProcesses(db.Name);

                    }
                    Restore restore = new Restore();
                    restore.Database = db.Name;
                    restore.Action = RestoreActionType.Database;
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "backup files (*.back)|*.back";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        restore.Devices.AddDevice(open.FileName, DeviceType.File);
                        restore.ReplaceDatabase = true;
                        restore.NoRecovery = false;
                        restore.SqlRestore(server);
                        MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception) { }
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("expenses_salary", "user_settings");
            if (check == true)
            {
                sandatemployee frm = new sandatemployee();
                frm.ShowDialog();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("exam_degree", "user_settings");
            if (check == true)
            {
                student_degree frm = new student_degree();
                frm.ShowDialog();
            }
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("balance", "user_settings");
            if (check == true)
            {
                balancenow frm = new balancenow();
                frm.ShowDialog();
            }
        }
        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
            login frm = new login();
            frm.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("stoke_reports", "user_settings");
            if (check == true)
            {
                stoke_reports frm = new stoke_reports();
                frm.ShowDialog();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("exam_degree_reports", "user_settings");
            if (check == true)
            {
                student_degree_reports frm = new student_degree_reports();
                frm.ShowDialog();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = checkuser("student_account", "user_settings");
            if (check == true)
            {

                student_account frm = new student_account();
                frm.ShowDialog();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = checkuser("setting", "user_settings");
            if (check == true)
            {
                program_setting frm = new program_setting();
                frm.ShowDialog();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            bool check = checkuser(" sal7iat", "user_settings");
            if (check == true)
            {
                sal7iat_users frm = new sal7iat_users();
                frm.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            barStaticItem1.Caption = "اسم المستخدم|" + " " + Properties.Settings.Default.user_name;
            barStaticItem2.Caption = "التاريخ|" + " " +DateTime.Now.ToString("yyyy-MM-dd") ;
            barStaticItem3.Caption = "الشهر الحالي شهر" + " " + Properties.Settings.Default.month;

            //db.excutedata("delete from madfou3aat_details22", "");


            //DataTable tblcomedata = new DataTable();
            //tblcomedata.Clear();
            //tblcomedata = db.readdata("select*from madfou3aat_details where  month=" +Properties.Settings.Default.month+"", "");
            //for (int i = 0; i <= tblcomedata.Rows.Count - 1; i++)
            //{
            //    db.excutedata("insert into madfou3aat_details22 values(" + tblcomedata.Rows[i][0] + "," + tblcomedata.Rows[i][1] + ",N'" + tblcomedata.Rows[i][2] + "'," + tblcomedata.Rows[i][3] + "," + tblcomedata.Rows[i][4] + "," + tblcomedata.Rows[i][5] + "," + tblcomedata.Rows[i][6] + ",N'" + tblcomedata.Rows[i][7] + "'," + tblcomedata.Rows[i][8] + ",N'" + tblcomedata.Rows[i][9] + "'," + tblcomedata.Rows[i][10] + ",N'" + tblcomedata.Rows[i][11] + "')", "");
            //}
            ////  ====================================



            //DataTable tblstudent_data = new DataTable();
            //tblstudent_data.Clear();
            //tblstudent_data = db.readdata("select*from student_data ", "");

            //DataTable tblorder_id = new DataTable();
            //tblorder_id.Clear();
            //tblorder_id = db.readdata("select*from sandat_id", "");
            //for (int x = 0; x <= tblstudent_data.Rows.Count - 1; x++)
            //{
            //    int order_id = Convert.ToInt32(tblorder_id.Rows[0][0]);

            //    DataTable tblcheck = new DataTable();
            //    tblcheck.Clear();
            //    tblcheck = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر' ", "");

            //    DataTable tblcheck1 = new DataTable();
            //    tblcheck1.Clear();
            //    tblcheck1 = db.readdata("select*from  madfou3aat_details22  where student_id=" + tblstudent_data.Rows[x][0] + " and type=N'مصاريف شهر' ", "");

            //    if (tblcheck.Rows.Count < 1)
            //    {
            //        db.excutedata("insert into madfou3aat_details22 values(" + order_id + "," + tblstudent_data.Rows[x][0] + ",N'" + tblstudent_data.Rows[x][1] + "',0,0,0,0,N'" + Properties.Settings.Default.user_name + "',0,N'لم يقومو بالدفع'," + tblstudent_data.Rows[x][2] + ",N'" + tblstudent_data.Rows[x][10] + "')", "");
            //    }
            //    if (tblcheck1.Rows.Count > 0)
            //    {
            //        db.excutedata("delete from madfou3aat_details22 where student_id=" + tblstudent_data.Rows[x][0] + " and type!=N'مصاريف شهر'", "");
            //    }

            //}


            //if (tblcomedata.Rows.Count>=1)
            //{
               
            //    if (MessageBox.Show("","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            //    {
                   
            //    }
            //}
            
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            expenses_reports frm = new expenses_reports();
            frm.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            student_inmarhlaselected frm = new student_inmarhlaselected();
            frm.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            student_salary frm = new student_salary();
            frm.ShowDialog();


        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addemployee frm = new addemployee();
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeeabsentsanddiscount frm = new employeeabsentsanddiscount();
            frm.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hdourandensraf frm = new hdourandensraf();
            frm.ShowDialog();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeeaccount frm = new employeeaccount();
            frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_magou3a frm = new add_magou3a();
            frm.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            expenses_type frm = new expenses_type();
            frm.ShowDialog();
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            expenses frm = new expenses();
            frm.ShowDialog();
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            expenses_reports frm = new expenses_reports();
            frm.ShowDialog();
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = checkuser("exam_degree", "user_settings");
            if (check == true)
            {
                student_degree frm = new student_degree();
                frm.ShowDialog();
            }
        }

        private void tileItem13_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            student_analys frm = new student_analys();
            frm.ShowDialog();
        }
    }
}
