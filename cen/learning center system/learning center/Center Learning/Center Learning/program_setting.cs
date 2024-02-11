using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Center_Learning
{
    public partial class program_setting : DevExpress.XtraEditors.XtraForm
    {
        public program_setting()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        database db = new database();

        private void btnsaveprinter_Click(object sender, EventArgs e)
        {
            if (cbxprinter.Text == "")
            {
                MessageBox.Show("من فضلك اختر طابعه اولا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked == true)
            {
                Properties.Settings.Default.printtype = "8cm";

            }
            else if (radioButton2.Checked == true)
            {
                Properties.Settings.Default.printtype = "a4";

            }
            if(checkBox1.Checked==true)
            {
                Properties.Settings.Default.printingorno = true;
            }
            else if(checkBox1.Checked==false)
            {
                Properties.Settings.Default.printingorno = false;
            }
            Properties.Settings.Default.numberofcopy = Convert.ToInt32(nomberofcopes.Value);
            Properties.Settings.Default.mindaysabsent = Convert.ToInt32(miniabsentes.Value);
            Properties.Settings.Default.printername = cbxprinter.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الطابعه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void showprinters()
        {
            string printer_name = "";
            for (int i = 0; i <= PrinterSettings.InstalledPrinters.Count - 1; i++)
            {
                printer_name = PrinterSettings.InstalledPrinters[i];
                cbxprinter.Items.Add(printer_name);
            }
            if (Properties.Settings.Default.printername == "")
                cbxprinter.SelectedIndex = 0;
            else
                cbxprinter.Text = Properties.Settings.Default.printername;
        }


        private void showdata()
        {
            tbl.Clear();
            tbl = db.readdata("select*from settingprinting_bills", "");
            if (tbl.Rows.Count >= 1)
            {
                txtshopename.Text = tbl.Rows[0][1].ToString();
                txtshopaddress.Text = tbl.Rows[0][2].ToString();
                txtdescription.Text = tbl.Rows[0][3].ToString();
                txtphone1.Text = tbl.Rows[0][4].ToString();
                txtphone2.Text = tbl.Rows[0][5].ToString();
                txtphone3.Text = tbl.Rows[0][6].ToString();

            }
            try
            {
                byte[] byteimage = new byte[0];
                byteimage = (byte[])(tbl.Rows[0][0]);
                MemoryStream memoryStream = new MemoryStream(byteimage);
                picturelogo.BackgroundImageLayout = ImageLayout.Stretch;
                picturelogo.BackgroundImage = Image.FromStream(memoryStream);
            }
            catch (Exception)
            {

            }
        }

        //=========================================



        //داله حفظ الصوره واسترجعها
        private void saveimage(string stmt, string paramitername, string Message)
        {
            SqlConnection conn = new SqlConnection(@"Data Source="+Properties.Settings.Default.servername+";Initial Catalog="+Properties.Settings.Default.databasename+";Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stmt, conn);

            FileStream filestream = new FileStream(picturepath, FileMode.Open, FileAccess.Read);
            byte[] bytestream = new byte[filestream.Length];
            filestream.Read(bytestream, 0, bytestream.Length);
            filestream.Close();

            SqlParameter parameter = new SqlParameter(paramitername, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);
            cmd.Parameters.Add(parameter);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            if (Message != "")
            {
                MessageBox.Show(Message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void program_setting_Load(object sender, EventArgs e)
        {
            showprinters();
            showdata();
            cbxprinter.Text = Properties.Settings.Default.printername;
            nomberofcopes.Value = Properties.Settings.Default.numberofcopy;
            miniabsentes.Value = Properties.Settings.Default.mindaysabsent;

            if (Properties.Settings.Default.printtype == "8cm")
            {
                radioButton1.Checked = true;
            }
            else if (Properties.Settings.Default.printtype == "a4")
            {
                radioButton2.Checked = true;
            }
            if(Properties.Settings.Default.printingorno==true)
            {
                checkBox1.Checked = true;
            }
            else if(Properties.Settings.Default.printingorno==false)
       {
                checkBox1.Checked = false;
            }
                    }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (picturepath == "")
                {
                    MessageBox.Show("من فضلك اختر لوجو للمكان", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tbl.Clear();
                tbl = db.readdata("select*from settingprinting_bills", "");
                if (tbl.Rows.Count >= 1)
                {


                    saveimage("update settingprinting_bills set logo=@logo,name=N'" + txtshopename.Text + "',address=N'" + txtshopaddress.Text + "',discriptionnn=N'" + txtdescription.Text.Trim() + "',phone1=" + txtphone1.Text.Trim() + ",phone2=" + txtphone2.Text.Trim() + ",phone3=" + txtphone3.Text.Trim() + "", "@logo", "تم التعديل بنجاح");
                }
                else
                {
                    saveimage("insert into settingprinting_bills values(@logo,N'" + txtshopename.Text + "',N'" + txtshopaddress.Text + "',N'" + txtdescription.Text + "'," + txtphone1.Text + "," + txtphone2.Text + "," + txtphone3.Text.Trim() + ")", "@logo", "تم الادخال بنجاح");
                }
                picturepath = "";
            }
            catch (Exception) { }
        }
        string picturepath = "";

        private void btnchooselogo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "all files(*.*)|*.*";
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                picturepath = openfiledialog.FileName.ToString();
                picturelogo.Image = null;
                picturelogo.ImageLocation = picturepath;
            }
        }

        private void btndeletelogo_Click(object sender, EventArgs e)
        {
            picturelogo.BackgroundImage = null;
            picturelogo.Image = null;
            picturepath = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت متاكد من فتح سنه جديده ؟","تاكيد",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                db.excutedata("update student_madfou3aat set mon_1=0,mon_2=0,mon_3=0,mon_4=0,mon_5=0,mon_6=0,mon_7=0,mon_8=0,mon_9=0,mon_10=0,mon_11=0,mon_12=0", "تم التاكيد علي فتح سنه جديده");
            }
        }
    }
    }