namespace Center_Learning
{
    partial class addemployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addemployee));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotalemployeesalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpdateofadd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkactivation = new System.Windows.Forms.CheckBox();
            this.txtnationalid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericsalary = new System.Windows.Forms.NumericUpDown();
            this.txtemp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemp_id = new System.Windows.Forms.TextBox();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(12, 287);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1136, 197);
            this.dgv.TabIndex = 143;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(191, 255);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(946, 26);
            this.txtsearch.TabIndex = 140;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 23);
            this.label9.TabIndex = 139;
            this.label9.Text = "بحث باسم الموظف او بجزء منه :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(533, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 28);
            this.label10.TabIndex = 142;
            this.label10.Text = "اضافه موظف";
            // 
            // btnexit
            // 
            this.btnexit.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnexit.Appearance.Options.UseFont = true;
            this.btnexit.Appearance.Options.UseForeColor = true;
            this.btnexit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.ImageOptions.Image")));
            this.btnexit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnexit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(1026, 205);
            this.btnexit.Name = "btnexit";
            this.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnexit.Size = new System.Drawing.Size(122, 46);
            this.btnexit.TabIndex = 137;
            this.btnexit.Text = "خروج";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndelete.Appearance.Options.UseFont = true;
            this.btndelete.Appearance.Options.UseForeColor = true;
            this.btndelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btndelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndelete.ImageOptions.SvgImage")));
            this.btndelete.Location = new System.Drawing.Point(1026, 163);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btndelete.Size = new System.Drawing.Size(122, 46);
            this.btndelete.TabIndex = 138;
            this.btndelete.Text = "حذف";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotalemployeesalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpdateofadd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkactivation);
            this.groupBox1.Controls.Add(this.txtnationalid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericsalary);
            this.groupBox1.Controls.Add(this.txtemp_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtemp_id);
            this.groupBox1.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1014, 219);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // txttotalemployeesalary
            // 
            this.txttotalemployeesalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txttotalemployeesalary.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalemployeesalary.Location = new System.Drawing.Point(6, 166);
            this.txttotalemployeesalary.Multiline = true;
            this.txttotalemployeesalary.Name = "txttotalemployeesalary";
            this.txttotalemployeesalary.ReadOnly = true;
            this.txttotalemployeesalary.Size = new System.Drawing.Size(274, 47);
            this.txttotalemployeesalary.TabIndex = 23;
            this.txttotalemployeesalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(292, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "اجمالي رواتب الموظفين هي :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(858, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 25);
            this.label11.TabIndex = 77;
            this.label11.Text = "حاله الموظف :";
            // 
            // dtpdateofadd
            // 
            this.dtpdateofadd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateofadd.Location = new System.Drawing.Point(499, 143);
            this.dtpdateofadd.Name = "dtpdateofadd";
            this.dtpdateofadd.Size = new System.Drawing.Size(338, 32);
            this.dtpdateofadd.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(292, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "العنوان";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(6, 105);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(274, 55);
            this.txtaddress.TabIndex = 36;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(292, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "رقم البطاقه";
            // 
            // checkactivation
            // 
            this.checkactivation.AutoSize = true;
            this.checkactivation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkactivation.Location = new System.Drawing.Point(630, 181);
            this.checkactivation.Name = "checkactivation";
            this.checkactivation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkactivation.Size = new System.Drawing.Size(135, 29);
            this.checkactivation.TabIndex = 76;
            this.checkactivation.Text = "activation";
            this.checkactivation.UseVisualStyleBackColor = true;
            // 
            // txtnationalid
            // 
            this.txtnationalid.Location = new System.Drawing.Point(6, 68);
            this.txtnationalid.Name = "txtnationalid";
            this.txtnationalid.Size = new System.Drawing.Size(274, 32);
            this.txtnationalid.TabIndex = 34;
            this.txtnationalid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(292, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "التلفون";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(6, 31);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(274, 32);
            this.txtphone.TabIndex = 32;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(858, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "تاريخ بدايه العمل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(897, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم الموظف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(909, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "الراتب";
            // 
            // numericsalary
            // 
            this.numericsalary.DecimalPlaces = 2;
            this.numericsalary.Location = new System.Drawing.Point(499, 106);
            this.numericsalary.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.numericsalary.Name = "numericsalary";
            this.numericsalary.Size = new System.Drawing.Size(336, 32);
            this.numericsalary.TabIndex = 4;
            this.numericsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemp_name
            // 
            this.txtemp_name.Location = new System.Drawing.Point(499, 68);
            this.txtemp_name.Name = "txtemp_name";
            this.txtemp_name.Size = new System.Drawing.Size(338, 32);
            this.txtemp_name.TabIndex = 2;
            this.txtemp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(899, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الموظف";
            // 
            // txtemp_id
            // 
            this.txtemp_id.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtemp_id.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp_id.Location = new System.Drawing.Point(499, 31);
            this.txtemp_id.Multiline = true;
            this.txtemp_id.Name = "txtemp_id";
            this.txtemp_id.ReadOnly = true;
            this.txtemp_id.Size = new System.Drawing.Size(338, 32);
            this.txtemp_id.TabIndex = 0;
            this.txtemp_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsave
            // 
            this.btnsave.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Appearance.Options.UseFont = true;
            this.btnsave.Appearance.Options.UseForeColor = true;
            this.btnsave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnsave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsave.ImageOptions.SvgImage")));
            this.btnsave.Location = new System.Drawing.Point(1026, 121);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(122, 46);
            this.btnsave.TabIndex = 136;
            this.btnsave.Text = "تعديل";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadd.Appearance.Options.UseFont = true;
            this.btnadd.Appearance.Options.UseForeColor = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnadd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnadd.ImageOptions.SvgImage")));
            this.btnadd.Location = new System.Drawing.Point(1026, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadd.Size = new System.Drawing.Size(122, 46);
            this.btnadd.TabIndex = 134;
            this.btnadd.Text = "اضافه";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnnew.Appearance.Options.UseFont = true;
            this.btnnew.Appearance.Options.UseForeColor = true;
            this.btnnew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.ImageOptions.Image")));
            this.btnnew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnnew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(1026, 76);
            this.btnnew.Name = "btnnew";
            this.btnnew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnnew.Size = new System.Drawing.Size(122, 46);
            this.btnnew.TabIndex = 135;
            this.btnnew.Text = "جديد";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // addemployee
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1154, 496);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnnew);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "addemployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه موظف جديد";
            this.Load += new System.EventHandler(this.addemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotalemployeesalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpdateofadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkactivation;
        private System.Windows.Forms.TextBox txtnationalid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericsalary;
        private System.Windows.Forms.TextBox txtemp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemp_id;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnnew;
    }
}