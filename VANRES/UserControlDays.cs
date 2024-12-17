using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Management.Instrumentation;

namespace VANRES
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
            displayevent();
        }


        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
            startDate1.Text = " ";
            startDate2.Text = " ";
            startDate3.Text = " ";
            endDate1.Text = " ";
            endDate2.Text = " ";
            endDate3.Text = " ";

        }
        private void displayevent() 
        {
            string connectionString = "Data Source=AMOU-MAIN-PC;Initial Catalog=ReservationVan;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First, retrieve the minimum and maximum dates from the Reservation table
                DateTime minDate;
                DateTime maxDate;

                string minMaxSql = "SELECT MIN(Start_Date) AS MinStartDate, MAX(End_Date) AS MaxEndDate FROM Reservation";

                using (SqlCommand minMaxCmd = new SqlCommand(minMaxSql, conn))
                {
                    using (SqlDataReader minMaxReader = minMaxCmd.ExecuteReader())
                    {
                        if (minMaxReader.Read())
                        {
                            // Get the minimum and maximum dates
                            minDate = minMaxReader["MinStartDate"] != DBNull.Value ? (DateTime)minMaxReader["MinStartDate"] : DateTime.MinValue;
                            maxDate = minMaxReader["MaxEndDate"] != DBNull.Value ? (DateTime)minMaxReader["MaxEndDate"] : DateTime.MaxValue;
                        }
                        else
                        {
                            MessageBox.Show("No reservations found in the database.");
                            return; // Exit if no data is found
                        }
                    }
                }

                // Now use the retrieved dates in your original query
                string sql = "SELECT Start_Date, End_Date FROM Reservation WHERE Start_Date >= @StartDate AND End_Date <= @EndDate";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Set the parameters for the date range
                    cmd.Parameters.AddWithValue("@StartDate", minDate);
                    cmd.Parameters.AddWithValue("@EndDate", maxDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            startDate1.Text = reader["Start_Date"].ToString() + " reserved";
                            endDate1.Text = reader["End_Date"].ToString() + " reserved";
                        }
                        else
                        {
                            MessageBox.Show("No reservations found within the specified date range.");
                        }
                    }
                }
            }
            /*  string connectionString = "Data Source=AMOU-MAIN-PC;Initial Catalog=ReservationVan;Integrated Security=True;";

              using (SqlConnection conn = new SqlConnection(connectionString))
              {
                  conn.Open();

                  // SQL query to select Start_Date and End_Date within the specified range
                  string sql = "SELECT Start_Date, End_Date FROM Reservation WHERE Start_Date >= @StartDate AND End_Date <= @EndDate";

                  using (SqlCommand cmd = new SqlCommand(sql, conn))
                  {
                      // Set the parameters for the date range
                      cmd.Parameters.AddWithValue("@StartDate", new DateTime(1970, 1, 1));
                      cmd.Parameters.AddWithValue("@EndDate", new DateTime(9999, 12, 31));

                      using (SqlDataReader reader = cmd.ExecuteReader())
                      {
                          if (reader.Read())
                          {
                              startDate1.Text = reader["Start_Date"].ToString() + "reserved";
                              endDate1.Text = reader["End_Date"].ToString() + "reserved";
                          }
                          else
                          {
                              MessageBox.Show("No reservations found within the specified date range.");
                          }
                      }
                  }
              }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayevent();
        }

        private void UserControlDays_MouseClick(object sender, MouseEventArgs e)
        {
            //static_day = lbdays.Text;
            timer1.Start();
            ReservationForm eventform = new ReservationForm();
            eventform.Show();
        }
    }
}
