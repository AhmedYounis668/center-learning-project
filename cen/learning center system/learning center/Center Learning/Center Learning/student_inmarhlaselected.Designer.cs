namespace Center_Learning
{
    partial class student_inmarhlaselected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_inmarhlaselected));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbxmarhalaname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxmagmou3a = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioallstudent = new System.Windows.Forms.RadioButton();
            this.radiomagmou3aonly = new System.Windows.Forms.RadioButton();
            this.radioallnotactivationinallmarahel = new System.Windows.Forms.RadioButton();
            this.radioallnotactivationin_selected_marhala = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bnprint
            // 
            this.bnprint.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprint.Appearance.Options.UseFont = true;
            this.bnprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnprint.ImageOptions.Image")));
            this.bnprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bnprint.Location = new System.Drawing.Point(1157, 47);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(110, 50);
            this.bnprint.TabIndex = 167;
            this.bnprint.Text = "طباعه";
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.ImageOptions.Image")));
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(1041, 47);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(110, 50);
            this.btnsearch.TabIndex = 166;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Teal;
            this.txttotal.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttotal.Location = new System.Drawing.Point(648, 47);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(386, 50);
            this.txttotal.TabIndex = 164;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgv.Location = new System.Drawing.Point(2, 115);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
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
            this.dgv.Size = new System.Drawing.Size(1274, 412);
            this.dgv.TabIndex = 165;
            // 
            // cbxmarhalaname
            // 
            this.cbxmarhalaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxmarhalaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxmarhalaname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbxmarhalaname.ForeColor = System.Drawing.Color.Yellow;
            this.cbxmarhalaname.FormattingEnabled = true;
            this.cbxmarhalaname.Items.AddRange(new object[] {
            "اختر "});
            this.cbxmarhalaname.Location = new System.Drawing.Point(148, 47);
            this.cbxmarhalaname.Name = "cbxmarhalaname";
            this.cbxmarhalaname.Size = new System.Drawing.Size(315, 27);
            this.cbxmarhalaname.TabIndex = 169;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 168;
            this.label7.Text = "اختر المرحله الدراسيه :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 170;
            this.label1.Text = "عدد الطلاب في هذا المرحله :";
            // 
            // cbxmagmou3a
            // 
            this.cbxmagmou3a.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxmagmou3a.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxmagmou3a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbxmagmou3a.ForeColor = System.Drawing.Color.Yellow;
            this.cbxmagmou3a.FormattingEnabled = true;
            this.cbxmagmou3a.Items.AddRange(new object[] {
            "اختر "});
            this.cbxmagmou3a.Location = new System.Drawing.Point(148, 84);
            this.cbxmagmou3a.Name = "cbxmagmou3a";
            this.cbxmagmou3a.Size = new System.Drawing.Size(315, 27);
            this.cbxmagmou3a.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 171;
            this.label2.Text = "اختر المجموعه :";
            // 
            // radioallstudent
            // 
            this.radioallstudent.AutoSize = true;
            this.radioallstudent.Location = new System.Drawing.Point(44, 12);
            this.radioallstudent.Name = "radioallstudent";
            this.radioallstudent.Size = new System.Drawing.Size(143, 23);
            this.radioallstudent.TabIndex = 173;
            this.radioallstudent.TabStop = true;
            this.radioallstudent.Text = "بحث بطلاب كل المرحله";
            this.radioallstudent.UseVisualStyleBackColor = true;
            // 
            // radiomagmou3aonly
            // 
            this.radiomagmou3aonly.AutoSize = true;
            this.radiomagmou3aonly.Location = new System.Drawing.Point(241, 11);
            this.radiomagmou3aonly.Name = "radiomagmou3aonly";
            this.radiomagmou3aonly.Size = new System.Drawing.Size(166, 23);
            this.radiomagmou3aonly.TabIndex = 174;
            this.radiomagmou3aonly.TabStop = true;
            this.radiomagmou3aonly.Text = "بحث عن مجموعه محدده فقط";
            this.radiomagmou3aonly.UseVisualStyleBackColor = true;
            // 
            // radioallnotactivationinallmarahel
            // 
            this.radioallnotactivationinallmarahel.AutoSize = true;
            this.radioallnotactivationinallmarahel.Location = new System.Drawing.Point(486, 11);
            this.radioallnotactivationinallmarahel.Name = "radioallnotactivationinallmarahel";
            this.radioallnotactivationinallmarahel.Size = new System.Drawing.Size(215, 23);
            this.radioallnotactivationinallmarahel.TabIndex = 175;
            this.radioallnotactivationinallmarahel.TabStop = true;
            this.radioallnotactivationinallmarahel.Text = "كل الطلبه الغير نشطين في كل المراحل";
            this.radioallnotactivationinallmarahel.UseVisualStyleBackColor = true;
            // 
            // radioallnotactivationin_selected_marhala
            // 
            this.radioallnotactivationin_selected_marhala.AutoSize = true;
            this.radioallnotactivationin_selected_marhala.Location = new System.Drawing.Point(756, 12);
            this.radioallnotactivationin_selected_marhala.Name = "radioallnotactivationin_selected_marhala";
            this.radioallnotactivationin_selected_marhala.Size = new System.Drawing.Size(222, 23);
            this.radioallnotactivationin_selected_marhala.TabIndex = 176;
            this.radioallnotactivationin_selected_marhala.TabStop = true;
            this.radioallnotactivationin_selected_marhala.Text = "كل الطلبه الغير نشطين في مرحله محدده";
            this.radioallnotactivationin_selected_marhala.UseVisualStyleBackColor = true;
            // 
            // student_inmarhlaselected
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1279, 529);
            this.Controls.Add(this.radioallnotactivationin_selected_marhala);
            this.Controls.Add(this.radioallnotactivationinallmarahel);
            this.Controls.Add(this.radiomagmou3aonly);
            this.Controls.Add(this.radioallstudent);
            this.Controls.Add(this.cbxmagmou3a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxmarhalaname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "student_inmarhlaselected";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعه طلاب كل مرحله";
            this.Load += new System.EventHandler(this.student_inmarhlaselected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bnprint;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.ComboBox cbxmarhalaname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbxmagmou3a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioallstudent;
        private System.Windows.Forms.RadioButton radiomagmou3aonly;
        private System.Windows.Forms.RadioButton radioallnotactivationinallmarahel;
        private System.Windows.Forms.RadioButton radioallnotactivationin_selected_marhala;
    }
}