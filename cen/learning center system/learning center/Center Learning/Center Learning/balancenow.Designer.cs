namespace Center_Learning
{
    partial class balancenow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal_khaznanow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxkhaznaname = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "اختر خزنه :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(208, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "رصيد الخزنه الان";
            // 
            // lbltotal_khaznanow
            // 
            this.lbltotal_khaznanow.AutoSize = true;
            this.lbltotal_khaznanow.Font = new System.Drawing.Font("Droid Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal_khaznanow.ForeColor = System.Drawing.Color.White;
            this.lbltotal_khaznanow.Location = new System.Drawing.Point(345, 109);
            this.lbltotal_khaznanow.Name = "lbltotal_khaznanow";
            this.lbltotal_khaznanow.Size = new System.Drawing.Size(103, 28);
            this.lbltotal_khaznanow.TabIndex = 69;
            this.lbltotal_khaznanow.Text = ".............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(50, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 34);
            this.label3.TabIndex = 68;
            this.label3.Text = "رصيد الخزنه المحدده :";
            // 
            // cbxkhaznaname
            // 
            this.cbxkhaznaname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxkhaznaname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxkhaznaname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbxkhaznaname.FormattingEnabled = true;
            this.cbxkhaznaname.Location = new System.Drawing.Point(113, 57);
            this.cbxkhaznaname.Name = "cbxkhaznaname";
            this.cbxkhaznaname.Size = new System.Drawing.Size(437, 27);
            this.cbxkhaznaname.TabIndex = 67;
            this.cbxkhaznaname.SelectionChangeCommitted += new System.EventHandler(this.cbxkhaznaname_SelectionChangeCommitted);
            // 
            // balancenow
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(562, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltotal_khaznanow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxkhaznaname);
            this.Font = new System.Drawing.Font("Droid Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "balancenow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رصيد الخزنه الان";
            this.Load += new System.EventHandler(this.balancenow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal_khaznanow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxkhaznaname;
    }
}