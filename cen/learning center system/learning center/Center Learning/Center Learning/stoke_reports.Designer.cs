namespace Center_Learning
{
    partial class stoke_reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stoke_reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxkhaznaname = new System.Windows.Forms.ComboBox();
            this.radioeda3aat = new System.Windows.Forms.RadioButton();
            this.radiowithdrowal = new System.Windows.Forms.RadioButton();
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.radiotasfeeronly = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "اختر خزنه :";
            // 
            // cbxkhaznaname
            // 
            this.cbxkhaznaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxkhaznaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxkhaznaname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxkhaznaname.FormattingEnabled = true;
            this.cbxkhaznaname.Location = new System.Drawing.Point(129, 18);
            this.cbxkhaznaname.Name = "cbxkhaznaname";
            this.cbxkhaznaname.Size = new System.Drawing.Size(233, 27);
            this.cbxkhaznaname.TabIndex = 74;
            // 
            // radioeda3aat
            // 
            this.radioeda3aat.AutoSize = true;
            this.radioeda3aat.Location = new System.Drawing.Point(368, 22);
            this.radioeda3aat.Name = "radioeda3aat";
            this.radioeda3aat.Size = new System.Drawing.Size(127, 23);
            this.radioeda3aat.TabIndex = 76;
            this.radioeda3aat.TabStop = true;
            this.radioeda3aat.Text = "الايداعات في الخزنه";
            this.radioeda3aat.UseVisualStyleBackColor = true;
            // 
            // radiowithdrowal
            // 
            this.radiowithdrowal.AutoSize = true;
            this.radiowithdrowal.Location = new System.Drawing.Point(564, 22);
            this.radiowithdrowal.Name = "radiowithdrowal";
            this.radiowithdrowal.Size = new System.Drawing.Size(135, 23);
            this.radiowithdrowal.TabIndex = 77;
            this.radiowithdrowal.TabStop = true;
            this.radiowithdrowal.Text = "المسحوبات من الخزنه";
            this.radiowithdrowal.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Appearance.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Appearance.Options.UseFont = true;
            this.btnsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsearch.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnsearch.ImageOptions.SvgImage")));
            this.btnsearch.Location = new System.Drawing.Point(21, 59);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(433, 26);
            this.btnsearch.TabIndex = 78;
            this.btnsearch.Text = "بحث";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dtpfrom
            // 
            this.dtpfrom.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(769, 12);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(189, 26);
            this.dtpfrom.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "من :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(964, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "الي :";
            // 
            // dtpto
            // 
            this.dtpto.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(1006, 11);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(171, 26);
            this.dtpto.TabIndex = 83;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.GridColor = System.Drawing.Color.Navy;
            this.dgv.Location = new System.Drawing.Point(21, 93);
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
            this.dgv.Size = new System.Drawing.Size(1157, 418);
            this.dgv.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 85;
            this.label4.Text = "الاجمالي :";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(800, 51);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(382, 36);
            this.txttotal.TabIndex = 86;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radiotasfeeronly
            // 
            this.radiotasfeeronly.AutoSize = true;
            this.radiotasfeeronly.Location = new System.Drawing.Point(474, 62);
            this.radiotasfeeronly.Name = "radiotasfeeronly";
            this.radiotasfeeronly.Size = new System.Drawing.Size(201, 23);
            this.radiotasfeeronly.TabIndex = 87;
            this.radiotasfeeronly.TabStop = true;
            this.radiotasfeeronly.Text = "بحث عن عمليات تصفير الخزنه فقط";
            this.radiotasfeeronly.UseVisualStyleBackColor = true;
            // 
            // stoke_reports
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1190, 523);
            this.Controls.Add(this.radiotasfeeronly);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.radiowithdrowal);
            this.Controls.Add(this.radioeda3aat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxkhaznaname);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "stoke_reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الخزنه";
            this.Load += new System.EventHandler(this.stoke_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxkhaznaname;
        private System.Windows.Forms.RadioButton radioeda3aat;
        private System.Windows.Forms.RadioButton radiowithdrowal;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.RadioButton radiotasfeeronly;
    }
}