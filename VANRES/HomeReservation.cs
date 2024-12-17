using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace VANRES
{
    public partial class HomeReservation : Form
    {
        int month, year;

        public static int static_month, static_year;

        public HomeReservation()
        {
            InitializeComponent();
            displaDays();
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
            UpdateLBDATE(monthCalendar1.SelectionStart);
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateLBDATE(e.Start);
        }

        private void UpdateLBDATE(DateTime date)
        {
            LBDATE.Text = date.ToString("MMMM yyyy");
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ReservationForm secondForm = new ReservationForm();
            secondForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReservationForm secondForm = new ReservationForm();
            secondForm.ShowDialog();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            // Decrement month and adjust year if needed
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 2;

            // First lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // now lets create usercontrol for days 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            // Increment month and adjust year if needed
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 2;

            // First lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // now lets create usercontrol for days 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 12);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 2;

            // First lets create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            // now lets create usercontrol for days 
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
