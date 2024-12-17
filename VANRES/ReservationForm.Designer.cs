namespace VANRES
{
    partial class ReservationForm
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
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.plate = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(113, 12);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(133, 21);
            this.cbtype.TabIndex = 0;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(113, 39);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(133, 20);
            this.fname.TabIndex = 1;
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(113, 65);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(133, 20);
            this.mname.TabIndex = 2;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(113, 91);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(133, 20);
            this.lname.TabIndex = 3;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(113, 117);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(133, 20);
            this.address.TabIndex = 4;
            // 
            // plate
            // 
            this.plate.Location = new System.Drawing.Point(113, 143);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(133, 20);
            this.plate.TabIndex = 5;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(113, 169);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(133, 20);
            this.cp.TabIndex = 6;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(97, 257);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 7;
            this.btnReserve.Text = "RESERVE";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TYPE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Car Plate Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contact Number:";
            // 
            // sdate
            // 
            this.sdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sdate.Location = new System.Drawing.Point(113, 195);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(133, 20);
            this.sdate.TabIndex = 15;
            this.sdate.Value = new System.DateTime(2024, 12, 17, 0, 23, 23, 0);
            // 
            // edate
            // 
            this.edate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edate.Location = new System.Drawing.Point(113, 221);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(133, 20);
            this.edate.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "End Date: ";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 291);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.plate);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.cbtype);
            this.Name = "ReservationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rervation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox plate;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker sdate;
        private System.Windows.Forms.DateTimePicker edate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}