using System.Drawing;
using System.Windows.Forms;
namespace VANRES
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbdays = new System.Windows.Forms.Label();
            this.startDate1 = new System.Windows.Forms.Label();
            this.endDate1 = new System.Windows.Forms.Label();
            this.startDate2 = new System.Windows.Forms.Label();
            this.endDate2 = new System.Windows.Forms.Label();
            this.startDate3 = new System.Windows.Forms.Label();
            this.endDate3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(10, 5);
            this.lbdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(23, 16);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            // 
            // startDate1
            // 
            this.startDate1.AutoSize = true;
            this.startDate1.Location = new System.Drawing.Point(3, 21);
            this.startDate1.Name = "startDate1";
            this.startDate1.Size = new System.Drawing.Size(10, 13);
            this.startDate1.TabIndex = 1;
            this.startDate1.Text = " ";
            // 
            // endDate1
            // 
            this.endDate1.AutoSize = true;
            this.endDate1.Location = new System.Drawing.Point(62, 21);
            this.endDate1.Name = "endDate1";
            this.endDate1.Size = new System.Drawing.Size(10, 13);
            this.endDate1.TabIndex = 2;
            this.endDate1.Text = " ";
            // 
            // startDate2
            // 
            this.startDate2.AutoSize = true;
            this.startDate2.Location = new System.Drawing.Point(3, 34);
            this.startDate2.Name = "startDate2";
            this.startDate2.Size = new System.Drawing.Size(10, 13);
            this.startDate2.TabIndex = 3;
            this.startDate2.Text = " ";
            // 
            // endDate2
            // 
            this.endDate2.AutoSize = true;
            this.endDate2.Location = new System.Drawing.Point(62, 34);
            this.endDate2.Name = "endDate2";
            this.endDate2.Size = new System.Drawing.Size(10, 13);
            this.endDate2.TabIndex = 4;
            this.endDate2.Text = " ";
            // 
            // startDate3
            // 
            this.startDate3.AutoSize = true;
            this.startDate3.Location = new System.Drawing.Point(3, 47);
            this.startDate3.Name = "startDate3";
            this.startDate3.Size = new System.Drawing.Size(10, 13);
            this.startDate3.TabIndex = 5;
            this.startDate3.Text = " ";
            // 
            // endDate3
            // 
            this.endDate3.AutoSize = true;
            this.endDate3.Location = new System.Drawing.Point(62, 47);
            this.endDate3.Name = "endDate3";
            this.endDate3.Size = new System.Drawing.Size(10, 13);
            this.endDate3.TabIndex = 6;
            this.endDate3.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.endDate3);
            this.Controls.Add(this.startDate3);
            this.Controls.Add(this.endDate2);
            this.Controls.Add(this.startDate2);
            this.Controls.Add(this.endDate1);
            this.Controls.Add(this.startDate1);
            this.Controls.Add(this.lbdays);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(100, 70);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserControlDays_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbdays;
        private Label startDate2;
        private Label endDate2;
        private Label startDate3;
        private Label endDate3;
        private Timer timer1;
        public Label startDate1;
        public Label endDate1;
    }
}
