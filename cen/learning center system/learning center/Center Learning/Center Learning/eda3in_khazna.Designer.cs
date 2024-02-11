namespace Center_Learning
{
    partial class eda3in_khazna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eda3in_khazna));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.txteda3reason = new System.Windows.Forms.TextBox();
            this.txtnamemode3 = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.numericaddnewbalance = new System.Windows.Forms.NumericUpDown();
            this.lbltotal_khaznanow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxkhaznaname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 62;
            this.label8.Text = "سبب الايداع:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "اسم المودع:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "تاريخ الايداع :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "اضافه رصيد جديد:";
            // 
            // btnadd
            // 
            this.btnadd.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnadd.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btnadd.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnadd.Appearance.Font = new System.Drawing.Font("Droid Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnadd.Appearance.Options.UseBackColor = true;
            this.btnadd.Appearance.Options.UseBorderColor = true;
            this.btnadd.Appearance.Options.UseFont = true;
            this.btnadd.Appearance.Options.UseForeColor = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnadd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(9, 431);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnadd.Size = new System.Drawing.Size(575, 46);
            this.btnadd.TabIndex = 58;
            this.btnadd.Text = "ايداع في الخزنه";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txteda3reason
            // 
            this.txteda3reason.Location = new System.Drawing.Point(181, 333);
            this.txteda3reason.Multiline = true;
            this.txteda3reason.Name = "txteda3reason";
            this.txteda3reason.Size = new System.Drawing.Size(403, 72);
            this.txteda3reason.TabIndex = 57;
            // 
            // txtnamemode3
            // 
            this.txtnamemode3.Location = new System.Drawing.Point(181, 285);
            this.txtnamemode3.Name = "txtnamemode3";
            this.txtnamemode3.Size = new System.Drawing.Size(403, 26);
            this.txtnamemode3.TabIndex = 56;
            this.txtnamemode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(181, 238);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(403, 26);
            this.dtpdate.TabIndex = 55;
            // 
            // numericaddnewbalance
            // 
            this.numericaddnewbalance.DecimalPlaces = 2;
            this.numericaddnewbalance.Location = new System.Drawing.Point(181, 175);
            this.numericaddnewbalance.Maximum = new decimal(new int[] {
            -159383552,
            46653770,
            5421,
            0});
            this.numericaddnewbalance.Name = "numericaddnewbalance";
            this.numericaddnewbalance.Size = new System.Drawing.Size(403, 26);
            this.numericaddnewbalance.TabIndex = 54;
            this.numericaddnewbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotal_khaznanow
            // 
            this.lbltotal_khaznanow.AutoSize = true;
            this.lbltotal_khaznanow.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_khaznanow.ForeColor = System.Drawing.Color.White;
            this.lbltotal_khaznanow.Location = new System.Drawing.Point(340, 111);
            this.lbltotal_khaznanow.Name = "lbltotal_khaznanow";
            this.lbltotal_khaznanow.Size = new System.Drawing.Size(103, 28);
            this.lbltotal_khaznanow.TabIndex = 53;
            this.lbltotal_khaznanow.Text = ".............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 34);
            this.label3.TabIndex = 52;
            this.label3.Text = "رصيد الخزنه الحالي هو:";
            // 
            // cbxkhaznaname
            // 
            this.cbxkhaznaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxkhaznaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxkhaznaname.FormattingEnabled = true;
            this.cbxkhaznaname.Location = new System.Drawing.Point(103, 56);
            this.cbxkhaznaname.Name = "cbxkhaznaname";
            this.cbxkhaznaname.Size = new System.Drawing.Size(481, 27);
            this.cbxkhaznaname.TabIndex = 51;
            this.cbxkhaznaname.SelectionChangeCommitted += new System.EventHandler(this.cbxkhaznaname_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "ايداع في الخزنه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "اسم الخزنه:";
            // 
            // eda3in_khazna
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(586, 480);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txteda3reason);
            this.Controls.Add(this.txtnamemode3);
            this.Controls.Add(this.dtpdate);
            this.Controls.Add(this.numericaddnewbalance);
            this.Controls.Add(this.lbltotal_khaznanow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxkhaznaname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "eda3in_khazna";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ايداع في الخزنه";
            this.Load += new System.EventHandler(this.eda3in_khazna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericaddnewbalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.TextBox txteda3reason;
        private System.Windows.Forms.TextBox txtnamemode3;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.NumericUpDown numericaddnewbalance;
        private System.Windows.Forms.Label lbltotal_khaznanow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxkhaznaname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}