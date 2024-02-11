namespace Center_Learning
{
    partial class student_degree_reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_degree_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.radiostudent_name = new System.Windows.Forms.RadioButton();
            this.radioallstudent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxmarhala = new System.Windows.Forms.ComboBox();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.radiosearchwithcode = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.Navy;
            this.dgv.Location = new System.Drawing.Point(489, 12);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(772, 468);
            this.dgv.TabIndex = 96;
            // 
            // dtpto
            // 
            this.dtpto.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(283, 46);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(200, 26);
            this.dtpto.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 94;
            this.label3.Text = "الي :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "من :";
            // 
            // dtpfrom
            // 
            this.dtpfrom.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(46, 47);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(189, 26);
            this.dtpfrom.TabIndex = 92;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(3, 434);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(482, 46);
            this.btnsearch.TabIndex = 91;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // radiostudent_name
            // 
            this.radiostudent_name.AutoSize = true;
            this.radiostudent_name.Location = new System.Drawing.Point(12, 122);
            this.radiostudent_name.Name = "radiostudent_name";
            this.radiostudent_name.Size = new System.Drawing.Size(112, 23);
            this.radiostudent_name.TabIndex = 90;
            this.radiostudent_name.TabStop = true;
            this.radiostudent_name.Text = "بحث باسم الطالب";
            this.radiostudent_name.UseVisualStyleBackColor = true;
            // 
            // radioallstudent
            // 
            this.radioallstudent.AutoSize = true;
            this.radioallstudent.Location = new System.Drawing.Point(12, 84);
            this.radioallstudent.Name = "radioallstudent";
            this.radioallstudent.Size = new System.Drawing.Size(182, 23);
            this.radioallstudent.TabIndex = 89;
            this.radioallstudent.TabStop = true;
            this.radioallstudent.Text = "كل الطلاب في المرحله المحدده ";
            this.radioallstudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "اختر المرحله الدراسيه";
            // 
            // cbxmarhala
            // 
            this.cbxmarhala.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxmarhala.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxmarhala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxmarhala.FormattingEnabled = true;
            this.cbxmarhala.Location = new System.Drawing.Point(194, 14);
            this.cbxmarhala.Name = "cbxmarhala";
            this.cbxmarhala.Size = new System.Drawing.Size(289, 27);
            this.cbxmarhala.TabIndex = 87;
            // 
            // dgvstudent
            // 
            this.dgvstudent.AllowUserToAddRows = false;
            this.dgvstudent.AllowUserToDeleteRows = false;
            this.dgvstudent.AllowUserToResizeColumns = false;
            this.dgvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvstudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvstudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvstudent.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvstudent.GridColor = System.Drawing.Color.Navy;
            this.dgvstudent.Location = new System.Drawing.Point(1, 194);
            this.dgvstudent.Name = "dgvstudent";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvstudent.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvstudent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvstudent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvstudent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudent.Size = new System.Drawing.Size(482, 234);
            this.dgvstudent.TabIndex = 99;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(97, 162);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(386, 26);
            this.txtsearch.TabIndex = 100;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // radiosearchwithcode
            // 
            this.radiosearchwithcode.AutoSize = true;
            this.radiosearchwithcode.Location = new System.Drawing.Point(218, 125);
            this.radiosearchwithcode.Name = "radiosearchwithcode";
            this.radiosearchwithcode.Size = new System.Drawing.Size(112, 23);
            this.radiosearchwithcode.TabIndex = 101;
            this.radiosearchwithcode.TabStop = true;
            this.radiosearchwithcode.Text = "بحث بكود الطالب";
            this.radiosearchwithcode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "ابحث هنا :";
            // 
            // student_degree_reports
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1263, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radiosearchwithcode);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.radiostudent_name);
            this.Controls.Add(this.radioallstudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxmarhala);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "student_degree_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير بدرجات الطلاب";
            this.Load += new System.EventHandler(this.student_degree_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.RadioButton radiostudent_name;
        private System.Windows.Forms.RadioButton radioallstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxmarhala;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton radiosearchwithcode;
        private System.Windows.Forms.Label label4;
    }
}