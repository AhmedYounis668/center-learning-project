namespace Center_Learning
{
    partial class hdourandensraf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hdourandensraf));
            this.radioattend = new System.Windows.Forms.RadioButton();
            this.radioensraf = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxemployee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // radioattend
            // 
            this.radioattend.AutoSize = true;
            this.radioattend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioattend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioattend.Location = new System.Drawing.Point(28, 42);
            this.radioattend.Name = "radioattend";
            this.radioattend.Size = new System.Drawing.Size(64, 24);
            this.radioattend.TabIndex = 164;
            this.radioattend.TabStop = true;
            this.radioattend.Text = "حضور";
            this.radioattend.UseVisualStyleBackColor = true;
            // 
            // radioensraf
            // 
            this.radioensraf.AutoSize = true;
            this.radioensraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioensraf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioensraf.Location = new System.Drawing.Point(245, 42);
            this.radioensraf.Name = "radioensraf";
            this.radioensraf.Size = new System.Drawing.Size(74, 24);
            this.radioensraf.TabIndex = 163;
            this.radioensraf.TabStop = true;
            this.radioensraf.Text = "انصراف";
            this.radioensraf.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(11, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 162;
            this.label5.Text = "ملاحظات :";
            // 
            // txtnotes
            // 
            this.txtnotes.BackColor = System.Drawing.Color.White;
            this.txtnotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtnotes.Location = new System.Drawing.Point(102, 157);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.PasswordChar = '*';
            this.txtnotes.Size = new System.Drawing.Size(392, 49);
            this.txtnotes.TabIndex = 161;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.White;
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtsearch.Location = new System.Drawing.Point(230, 278);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(264, 26);
            this.txtsearch.TabIndex = 160;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(13, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 22);
            this.label4.TabIndex = 159;
            this.label4.Text = "بحث باسم الموظف او بحرف من اسمه :";
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
            this.dgv.Location = new System.Drawing.Point(5, 307);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(489, 191);
            this.dgv.TabIndex = 158;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.Appearance.Options.UseForeColor = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(5, 212);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(489, 47);
            this.btnsearch.TabIndex = 157;
            this.btnsearch.Text = "تنفيذ";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 156;
            this.label3.Text = "اختر الموظف :";
            // 
            // dtptime
            // 
            this.dtptime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptime.Location = new System.Drawing.Point(325, 76);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(132, 26);
            this.dtptime.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(271, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 154;
            this.label1.Text = "الوقت :";
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(101, 75);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(132, 26);
            this.dtpdate.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(26, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 22);
            this.label6.TabIndex = 152;
            this.label6.Text = "التاريخ:";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "v";
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(142, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 27);
            this.label2.TabIndex = 151;
            this.label2.Text = "حضور وانصراف الموظفين";
            // 
            // cbxemployee
            // 
            this.cbxemployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxemployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxemployee.BackColor = System.Drawing.Color.White;
            this.cbxemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxemployee.ForeColor = System.Drawing.Color.Blue;
            this.cbxemployee.FormattingEnabled = true;
            this.cbxemployee.Location = new System.Drawing.Point(102, 123);
            this.cbxemployee.Name = "cbxemployee";
            this.cbxemployee.Size = new System.Drawing.Size(391, 28);
            this.cbxemployee.TabIndex = 150;
            // 
            // hdourandensraf
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 501);
            this.Controls.Add(this.radioattend);
            this.Controls.Add(this.radioensraf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxemployee);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "hdourandensraf";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حضور وانصراف";
            this.Load += new System.EventHandler(this.hdourandensraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioattend;
        private System.Windows.Forms.RadioButton radioensraf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxemployee;
    }
}