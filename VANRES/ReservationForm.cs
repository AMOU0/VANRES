using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VANRES
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            LoadComboBox();

        }
        private void LoadComboBox()
        {
            // Clear existing items (if any)
            cbtype.Items.Clear();

            // Add Toyota van models to the ComboBox
            cbtype.Items.Add("Toyota Sienna");
            cbtype.Items.Add("Toyota HiAce");
            cbtype.Items.Add("Toyota Previa");
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = "Data Source=AMOU-MAIN-PC;Initial Catalog=ReservationVan;Integrated Security=True;";

            // Get data from the form
            string type = cbtype.SelectedItem.ToString();
            string Name = fname.Text + mname.Text + lname.Text;
            string address = this.address.Text;
            string carPlateNumber = plate.Text;
            string contactNumber = cp.Text;
            DateTime startDate = sdate.Value;
            DateTime endDate = edate.Value;

            // Save data to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to insert data into the database
                    string query = "INSERT INTO Reservation (Type, Name, Address, Car_Plate_Number, Contact_Number, Start_Date, End_Date) VALUES (@type, @Name, @address, @carPlateNumber, @contactNumber, @startDate, @endDate)";

                    // Create a command object
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@name", Name); 
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@carPlateNumber", carPlateNumber);
                    command.Parameters.AddWithValue("@contactNumber", contactNumber);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    // Execute the command
                    command.ExecuteNonQuery();

                    MessageBox.Show("Reservation saved successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
