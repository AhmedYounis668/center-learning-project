namespace Center_Learning
{
    partial class student_salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_salary));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radionotpays = new System.Windows.Forms.RadioButton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbxmonth = new System.Windows.Forms.ComboBox();
            this.radiopays = new System.Windows.Forms.RadioButton();
            this.radiosearchwithcode = new System.Windows.Forms.RadioButton();
            this.radiostudentnameorpart = new System.Windows.Forms.RadioButton();
            this.txt_write_student = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioselectdstudent = new System.Windows.Forms.RadioButton();
            this.radioallstudentinmarhala = new System.Windows.Forms.RadioButton();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(3, 196);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1330, 361);
            this.dgv.TabIndex = 60;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "v";
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(511, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 59;
            this.label1.Text = "تقارير المصاريف الشهر للطلاب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radionotpays);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.cbxmonth);
            this.groupBox1.Controls.Add(this.radiopays);
            this.groupBox1.Controls.Add(this.radiosearchwithcode);
            this.groupBox1.Controls.Add(this.radiostudentnameorpart);
            this.groupBox1.Controls.Add(this.txt_write_student);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radioselectdstudent);
            this.groupBox1.Controls.Add(this.radioallstudentinmarhala);
            this.groupBox1.Controls.Add(this.cbx);
            this.groupBox1.Location = new System.Drawing.Point(7, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 159);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث عام";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(6, 29);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(284, 122);
            this.simpleButton2.TabIndex = 173;
            this.simpleButton2.Text = "شاشه دفع المصاريف الشهريه والمذكرات";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(296, 95);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(317, 60);
            this.simpleButton1.TabIndex = 172;
            this.simpleButton1.Text = "تنفيذ استرداد مصاريف";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(919, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 171;
            this.label5.Text = "اختر الشهر الحالي :";
            // 
            // radionotpays
            // 
            this.radionotpays.AutoSize = true;
            this.radionotpays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionotpays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radionotpays.Location = new System.Drawing.Point(1053, 129);
            this.radionotpays.Name = "radionotpays";
            this.radionotpays.Size = new System.Drawing.Size(98, 24);
            this.radionotpays.TabIndex = 19;
            this.radionotpays.TabStop = true;
            this.radionotpays.Text = "لم يقومو بالدفع";
            this.radionotpays.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Aqua;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(619, 88);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(420, 26);
            this.txtsearch.TabIndex = 17;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cbxmonth
            // 
            this.cbxmonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxmonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxmonth.BackColor = System.Drawing.Color.White;
            this.cbxmonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxmonth.FormattingEnabled = true;
            this.cbxmonth.Items.AddRange(new object[] {
            "اختر ",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxmonth.Location = new System.Drawing.Point(651, 128);
            this.cbxmonth.Name = "cbxmonth";
            this.cbxmonth.Size = new System.Drawing.Size(260, 27);
            this.cbxmonth.TabIndex = 170;
            // 
            // radiopays
            // 
            this.radiopays.AutoSize = true;
            this.radiopays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiopays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiopays.Location = new System.Drawing.Point(1167, 127);
            this.radiopays.Name = "radiopays";
            this.radiopays.Size = new System.Drawing.Size(78, 24);
            this.radiopays.TabIndex = 18;
            this.radiopays.TabStop = true;
            this.radiopays.Text = "قامو بالدفع";
            this.radiopays.UseVisualStyleBackColor = true;
            // 
            // radiosearchwithcode
            // 
            this.radiosearchwithcode.AutoSize = true;
            this.radiosearchwithcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosearchwithcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiosearchwithcode.Location = new System.Drawing.Point(1119, 88);
            this.radiosearchwithcode.Name = "radiosearchwithcode";
            this.radiosearchwithcode.Size = new System.Drawing.Size(126, 24);
            this.radiosearchwithcode.TabIndex = 16;
            this.radiosearchwithcode.TabStop = true;
            this.radiosearchwithcode.Text = "ابحث بكود الطالب :";
            this.radiosearchwithcode.UseVisualStyleBackColor = true;
            // 
            // radiostudentnameorpart
            // 
            this.radiostudentnameorpart.AutoSize = true;
            this.radiostudentnameorpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiostudentnameorpart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiostudentnameorpart.Location = new System.Drawing.Point(1045, 52);
            this.radiostudentnameorpart.Name = "radiostudentnameorpart";
            this.radiostudentnameorpart.Size = new System.Drawing.Size(200, 24);
            this.radiostudentnameorpart.TabIndex = 12;
            this.radiostudentnameorpart.TabStop = true;
            this.radiostudentnameorpart.Text = "اكتب اسم الطالب او جزء من اسمه";
            this.radiostudentnameorpart.UseVisualStyleBackColor = true;
            // 
            // txt_write_student
            // 
            this.txt_write_student.BackColor = System.Drawing.Color.Aqua;
            this.txt_write_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_write_student.Location = new System.Drawing.Point(619, 51);
            this.txt_write_student.Name = "txt_write_student";
            this.txt_write_student.Size = new System.Drawing.Size(420, 26);
            this.txt_write_student.TabIndex = 11;
            this.txt_write_student.TextChanged += new System.EventHandler(this.txt_write_student_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(296, 29);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(317, 60);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radioselectdstudent
            // 
            this.radioselectdstudent.AutoSize = true;
            this.radioselectdstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioselectdstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioselectdstudent.Location = new System.Drawing.Point(989, 19);
            this.radioselectdstudent.Name = "radioselectdstudent";
            this.radioselectdstudent.Size = new System.Drawing.Size(81, 24);
            this.radioselectdstudent.TabIndex = 3;
            this.radioselectdstudent.TabStop = true;
            this.radioselectdstudent.Text = "طالب محدد";
            this.radioselectdstudent.UseVisualStyleBackColor = true;
            this.radioselectdstudent.CheckedChanged += new System.EventHandler(this.radioselectdstudent_CheckedChanged);
            // 
            // radioallstudentinmarhala
            // 
            this.radioallstudentinmarhala.AutoSize = true;
            this.radioallstudentinmarhala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioallstudentinmarhala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioallstudentinmarhala.Location = new System.Drawing.Point(1150, 24);
            this.radioallstudentinmarhala.Name = "radioallstudentinmarhala";
            this.radioallstudentinmarhala.Size = new System.Drawing.Size(166, 24);
            this.radioallstudentinmarhala.TabIndex = 2;
            this.radioallstudentinmarhala.TabStop = true;
            this.radioallstudentinmarhala.Text = "كل الطلاب في مرحله محدده";
            this.radioallstudentinmarhala.UseVisualStyleBackColor = true;
            this.radioallstudentinmarhala.CheckedChanged += new System.EventHandler(this.radioallstudentinmarhala_CheckedChanged);
            // 
            // cbx
            // 
            this.cbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx.BackColor = System.Drawing.Color.White;
            this.cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(619, 18);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(340, 28);
            this.cbx.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(983, 7);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(35, 26);
            this.dtp.TabIndex = 157;
            this.dtp.Visible = false;
            // 
            // student_salary
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1353, 559);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "student_salary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعلام عن المصاريف الشهريه للطلاب";
            this.Load += new System.EventHandler(this.student_salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiostudentnameorpart;
        private System.Windows.Forms.TextBox txt_write_student;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radioselectdstudent;
        private System.Windows.Forms.RadioButton radioallstudentinmarhala;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton radiosearchwithcode;
        private System.Windows.Forms.RadioButton radionotpays;
        private System.Windows.Forms.RadioButton radiopays;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxmonth;
        private System.Windows.Forms.DateTimePicker dtp;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}