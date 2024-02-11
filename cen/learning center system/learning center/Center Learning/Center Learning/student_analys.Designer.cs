namespace Center_Learning
{
    partial class student_analys
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_analys));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radiosearchwithcode = new System.Windows.Forms.RadioButton();
            this.radiosearchwithstudent_name = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtpersonnamesearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblattend = new System.Windows.Forms.Label();
            this.lblexamdegree = new System.Windows.Forms.Label();
            this.lbltasme3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 158);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(802, 339);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(10, 502);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(403, 39);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Loading";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // radiosearchwithcode
            // 
            this.radiosearchwithcode.AutoSize = true;
            this.radiosearchwithcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosearchwithcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiosearchwithcode.Location = new System.Drawing.Point(32, 42);
            this.radiosearchwithcode.Name = "radiosearchwithcode";
            this.radiosearchwithcode.Size = new System.Drawing.Size(126, 24);
            this.radiosearchwithcode.TabIndex = 18;
            this.radiosearchwithcode.TabStop = true;
            this.radiosearchwithcode.Text = "ابحث بكود الطالب :";
            this.radiosearchwithcode.UseVisualStyleBackColor = true;
            // 
            // radiosearchwithstudent_name
            // 
            this.radiosearchwithstudent_name.AutoSize = true;
            this.radiosearchwithstudent_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiosearchwithstudent_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radiosearchwithstudent_name.Location = new System.Drawing.Point(32, 12);
            this.radiosearchwithstudent_name.Name = "radiosearchwithstudent_name";
            this.radiosearchwithstudent_name.Size = new System.Drawing.Size(200, 24);
            this.radiosearchwithstudent_name.TabIndex = 17;
            this.radiosearchwithstudent_name.TabStop = true;
            this.radiosearchwithstudent_name.Text = "اكتب اسم الطالب او جزء من اسمه";
            this.radiosearchwithstudent_name.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(12, 72);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(791, 80);
            this.dgv.TabIndex = 159;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtpersonnamesearch
            // 
            this.txtpersonnamesearch.BackColor = System.Drawing.Color.Aqua;
            this.txtpersonnamesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpersonnamesearch.Location = new System.Drawing.Point(269, 12);
            this.txtpersonnamesearch.Name = "txtpersonnamesearch";
            this.txtpersonnamesearch.Size = new System.Drawing.Size(403, 26);
            this.txtpersonnamesearch.TabIndex = 160;
            this.txtpersonnamesearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "v";
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 163;
            this.label3.Text = "الحضور";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "v";
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 165;
            this.label1.Text = "الامتحانات";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom.Location = new System.Drawing.Point(314, 45);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(144, 21);
            this.dtpfrom.TabIndex = 166;
            // 
            // dtpto
            // 
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto.Location = new System.Drawing.Point(504, 45);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(128, 21);
            this.dtpto.TabIndex = 167;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(274, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 25);
            this.label10.TabIndex = 168;
            this.label10.Text = "من :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Droid Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(462, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 25);
            this.label11.TabIndex = 169;
            this.label11.Text = "الي :";
            // 
            // lblname
            // 
            this.lblname.AccessibleDescription = "v";
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblname.Location = new System.Drawing.Point(388, 158);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 27);
            this.lblname.TabIndex = 171;
            this.lblname.Text = "....";
            // 
            // lblattend
            // 
            this.lblattend.AccessibleDescription = "v";
            this.lblattend.AutoSize = true;
            this.lblattend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblattend.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblattend.ForeColor = System.Drawing.Color.White;
            this.lblattend.Location = new System.Drawing.Point(119, 549);
            this.lblattend.Name = "lblattend";
            this.lblattend.Size = new System.Drawing.Size(31, 21);
            this.lblattend.TabIndex = 172;
            this.lblattend.Text = "....";
            // 
            // lblexamdegree
            // 
            this.lblexamdegree.AccessibleDescription = "v";
            this.lblexamdegree.AutoSize = true;
            this.lblexamdegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblexamdegree.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexamdegree.ForeColor = System.Drawing.Color.White;
            this.lblexamdegree.Location = new System.Drawing.Point(119, 584);
            this.lblexamdegree.Name = "lblexamdegree";
            this.lblexamdegree.Size = new System.Drawing.Size(31, 21);
            this.lblexamdegree.TabIndex = 173;
            this.lblexamdegree.Text = "....";
            // 
            // lbltasme3
            // 
            this.lbltasme3.AccessibleDescription = "v";
            this.lbltasme3.AutoSize = true;
            this.lbltasme3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltasme3.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltasme3.ForeColor = System.Drawing.Color.White;
            this.lbltasme3.Location = new System.Drawing.Point(119, 616);
            this.lbltasme3.Name = "lbltasme3";
            this.lbltasme3.Size = new System.Drawing.Size(31, 21);
            this.lbltasme3.TabIndex = 175;
            this.lbltasme3.Text = "....";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "v";
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 174;
            this.label4.Text = "التسميعات";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(419, 503);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(393, 39);
            this.simpleButton2.TabIndex = 176;
            this.simpleButton2.Text = "تعيدل النسب";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // student_analys
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 647);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lbltasme3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblexamdegree);
            this.Controls.Add(this.lblattend);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpersonnamesearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.radiosearchwithcode);
            this.Controls.Add(this.radiosearchwithstudent_name);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "student_analys";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحليل الطالب";
            this.Load += new System.EventHandler(this.student_analys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RadioButton radiosearchwithcode;
        private System.Windows.Forms.RadioButton radiosearchwithstudent_name;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtpersonnamesearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblattend;
        private System.Windows.Forms.Label lblexamdegree;
        private System.Windows.Forms.Label lbltasme3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}