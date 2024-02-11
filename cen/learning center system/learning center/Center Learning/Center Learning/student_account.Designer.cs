namespace Center_Learning
{
    partial class student_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_account));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsearchwithstudentcode = new System.Windows.Forms.TextBox();
            this.radiosearchfatra = new System.Windows.Forms.RadioButton();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsandat_deleted = new DevExpress.XtraEditors.SimpleButton();
            this.btndeleteselectedsadad = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.radiostudentnameorpart = new System.Windows.Forms.RadioButton();
            this.txt_write_student = new System.Windows.Forms.TextBox();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioselectdstudent = new System.Windows.Forms.RadioButton();
            this.radioallstudentinmarhala = new System.Windows.Forms.RadioButton();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(6, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(816, 478);
            this.dgv.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "v";
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(592, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "تقارير الطلاب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsearchwithstudentcode);
            this.groupBox1.Controls.Add(this.radiosearchfatra);
            this.groupBox1.Controls.Add(this.dtpfrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnsandat_deleted);
            this.groupBox1.Controls.Add(this.btndeleteselectedsadad);
            this.groupBox1.Controls.Add(this.btnprint);
            this.groupBox1.Controls.Add(this.radiostudentnameorpart);
            this.groupBox1.Controls.Add(this.txt_write_student);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.radioselectdstudent);
            this.groupBox1.Controls.Add(this.radioallstudentinmarhala);
            this.groupBox1.Controls.Add(this.cbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 499);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث عام";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 449);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(487, 35);
            this.simpleButton1.TabIndex = 138;
            this.simpleButton1.Text = "طباعه تقرير حاله للطالب";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "v";
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(61, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 137;
            this.label4.Text = "Enter";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "v";
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(335, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 27);
            this.label2.TabIndex = 58;
            this.label2.Text = "بحث بكود الطالب :";
            // 
            // txtsearchwithstudentcode
            // 
            this.txtsearchwithstudentcode.BackColor = System.Drawing.Color.Aqua;
            this.txtsearchwithstudentcode.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchwithstudentcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtsearchwithstudentcode.Location = new System.Drawing.Point(10, 176);
            this.txtsearchwithstudentcode.Name = "txtsearchwithstudentcode";
            this.txtsearchwithstudentcode.Size = new System.Drawing.Size(292, 33);
            this.txtsearchwithstudentcode.TabIndex = 136;
            this.txtsearchwithstudentcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearchwithstudentcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearchwithstudentcode_KeyPress);
            // 
            // radiosearchfatra
            // 
            this.radiosearchfatra.AutoSize = true;
            this.radiosearchfatra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosearchfatra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiosearchfatra.Location = new System.Drawing.Point(365, 101);
            this.radiosearchfatra.Name = "radiosearchfatra";
            this.radiosearchfatra.Size = new System.Drawing.Size(132, 24);
            this.radiosearchfatra.TabIndex = 134;
            this.radiosearchfatra.TabStop = true;
            this.radiosearchfatra.Text = "بحث في فتره محدده :";
            this.radiosearchfatra.UseVisualStyleBackColor = true;
            // 
            // dtpfrom
            // 
            this.dtpfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(182, 101);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(123, 26);
            this.dtpfrom.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(327, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 132;
            this.label3.Text = "من :";
            // 
            // dtpto
            // 
            this.dtpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(10, 101);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(125, 26);
            this.dtpto.TabIndex = 131;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(141, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 130;
            this.label6.Text = "الي :";
            // 
            // btnsandat_deleted
            // 
            this.btnsandat_deleted.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsandat_deleted.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsandat_deleted.Appearance.Options.UseFont = true;
            this.btnsandat_deleted.Appearance.Options.UseForeColor = true;
            this.btnsandat_deleted.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsandat_deleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsandat_deleted.ImageOptions.SvgImage")));
            this.btnsandat_deleted.Location = new System.Drawing.Point(10, 408);
            this.btnsandat_deleted.Name = "btnsandat_deleted";
            this.btnsandat_deleted.Size = new System.Drawing.Size(487, 35);
            this.btnsandat_deleted.TabIndex = 17;
            this.btnsandat_deleted.Text = "سندات محذوفه";
            // 
            // btndeleteselectedsadad
            // 
            this.btndeleteselectedsadad.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteselectedsadad.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndeleteselectedsadad.Appearance.Options.UseFont = true;
            this.btndeleteselectedsadad.Appearance.Options.UseForeColor = true;
            this.btndeleteselectedsadad.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btndeleteselectedsadad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndeleteselectedsadad.ImageOptions.SvgImage")));
            this.btndeleteselectedsadad.Location = new System.Drawing.Point(10, 367);
            this.btndeleteselectedsadad.Name = "btndeleteselectedsadad";
            this.btndeleteselectedsadad.Size = new System.Drawing.Size(486, 35);
            this.btndeleteselectedsadad.TabIndex = 13;
            this.btndeleteselectedsadad.Text = "مسح سداد محدد";
            // 
            // btnprint
            // 
            this.btnprint.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Appearance.Options.UseFont = true;
            this.btnprint.Appearance.Options.UseForeColor = true;
            this.btnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnprint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnprint.ImageOptions.SvgImage")));
            this.btnprint.Location = new System.Drawing.Point(10, 326);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(486, 35);
            this.btnprint.TabIndex = 10;
            this.btnprint.Text = "طباعه تقرير";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // radiostudentnameorpart
            // 
            this.radiostudentnameorpart.AutoSize = true;
            this.radiostudentnameorpart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiostudentnameorpart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiostudentnameorpart.Location = new System.Drawing.Point(317, 216);
            this.radiostudentnameorpart.Name = "radiostudentnameorpart";
            this.radiostudentnameorpart.Size = new System.Drawing.Size(179, 20);
            this.radiostudentnameorpart.TabIndex = 12;
            this.radiostudentnameorpart.TabStop = true;
            this.radiostudentnameorpart.Text = "اكتب اسم الطالب او جزء من اسمه";
            this.radiostudentnameorpart.UseVisualStyleBackColor = true;
            // 
            // txt_write_student
            // 
            this.txt_write_student.BackColor = System.Drawing.Color.Aqua;
            this.txt_write_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_write_student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_write_student.Location = new System.Drawing.Point(10, 215);
            this.txt_write_student.Name = "txt_write_student";
            this.txt_write_student.Size = new System.Drawing.Size(292, 26);
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
            this.btnsearch.Location = new System.Drawing.Point(10, 283);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(486, 37);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radioselectdstudent
            // 
            this.radioselectdstudent.AutoSize = true;
            this.radioselectdstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioselectdstudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioselectdstudent.Location = new System.Drawing.Point(416, 65);
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
            this.radioallstudentinmarhala.Location = new System.Drawing.Point(331, 25);
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
            this.cbx.BackColor = System.Drawing.Color.Gray;
            this.cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(10, 133);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(487, 28);
            this.cbx.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(530, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 509);
            this.groupBox2.TabIndex = 138;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نتيجه البحث";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(676, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(487, 35);
            this.simpleButton2.TabIndex = 139;
            this.simpleButton2.Text = "طباعه تقرير حاله للطالب";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // student_account
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 556);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "student_account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الطلاب";
            this.Load += new System.EventHandler(this.student_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnsandat_deleted;
        private DevExpress.XtraEditors.SimpleButton btndeleteselectedsadad;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private System.Windows.Forms.RadioButton radiostudentnameorpart;
        private System.Windows.Forms.TextBox txt_write_student;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radioselectdstudent;
        private System.Windows.Forms.RadioButton radioallstudentinmarhala;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.RadioButton radiosearchfatra;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsearchwithstudentcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}