using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace AdoptmeApplication
{
    public partial class ApplicationList : Form
    {
        //private string connectionStringPaula = "Data Source = PAULAGO\SQLEXPRESS01; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public ApplicationList()
        {
            InitializeComponent();
            LoadAllApplications();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadAllApplications()
        {
            string query = "SELECT App_Id, App_FullName, App_Address, App_PhoneNumber, App_Email, " +
                           "App_NumAdults, App_NumChildren, App_TimeHome, App_OutdoorSpace, " +
                           "App_PetsHome, App_Animal_id, App_Status FROM Application";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;

                        // Set custom column headers
                        dataGridView1.Columns["App_Id"].HeaderText = "App Id";
                        dataGridView1.Columns["App_FullName"].HeaderText = "Adopter Name";
                        dataGridView1.Columns["App_Address"].HeaderText = "Address";
                        dataGridView1.Columns["App_PhoneNumber"].HeaderText = "Phone Number";
                        dataGridView1.Columns["App_Email"].HeaderText = "Email";
                        dataGridView1.Columns["App_NumAdults"].HeaderText = "Adults Number";
                        dataGridView1.Columns["App_NumChildren"].HeaderText = "Children Number";
                        dataGridView1.Columns["App_TimeHome"].HeaderText = "Time at Home";
                        dataGridView1.Columns["App_OutdoorSpace"].HeaderText = "Outdoor Space";
                        dataGridView1.Columns["App_PetsHome"].HeaderText = "Pets at Home";
                        dataGridView1.Columns["App_Animal_id"].HeaderText = "Animal ID";
                        dataGridView1.Columns["App_Status"].HeaderText = "Result";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading applications: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string currentStatus = selectedRow.Cells["App_Status"].Value.ToString();

                switch (currentStatus)
                {
                    case "Pending":
                        rboPending.Checked = true;
                        break;
                    case "Approved":
                        rboApproved.Checked = true;
                        break;
                    case "Denied":
                        rboDenied.Checked = true;
                        break;
                    default:
                        rboPending.Checked = false;
                        rboApproved.Checked = false;
                        rboDenied.Checked = false;
                        break;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int applicationId = Convert.ToInt32(selectedRow.Cells["App_Id"].Value);
                int animalId = Convert.ToInt32(selectedRow.Cells["App_Animal_id"].Value);

                string newStatus = "";

                if (rboPending.Checked)
                {
                    newStatus = "Pending";
                }
                else if (rboApproved.Checked)
                {
                    newStatus = "Approved";
                }
                else if (rboDenied.Checked)
                {
                    newStatus = "Denied";
                }
                else
                {
                    MessageBox.Show("Please select a status.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        if (newStatus == "Approved")
                        {
                            string checkExistingApprovedQuery = @"SELECT COUNT(*) FROM Application 
                                                          WHERE App_Animal_id = @AnimalId AND App_Status = 'Approved'";
                            using (SqlCommand checkCommand = new SqlCommand(checkExistingApprovedQuery, connection))
                            {
                                checkCommand.Parameters.AddWithValue("@AnimalId", animalId);
                                int existingApprovedCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                                if (existingApprovedCount > 0)
                                {
                                    MessageBox.Show($"The animal with Id:{animalId} already has an approved application.");
                                    return;
                                }
                            }
                        }

                        string updateQuery = @"UPDATE Application SET App_Status = @Status WHERE App_Id = @ApplicationId";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Status", newStatus);
                            command.Parameters.AddWithValue("@ApplicationId", applicationId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Application status updated successfully.");
                                UpdateAnimalStatus(animalId, connection);
                                LoadAllApplications();
                            }
                            else
                            {
                                MessageBox.Show("Could not update the application status.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating the application status: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.");
            }
        }

        private void UpdateAnimalStatus(int animalId, SqlConnection connection)
        {
            try
            {
                string checkApprovedQuery = @"SELECT COUNT(*) FROM Application 
                                            WHERE App_Animal_id = @AnimalId AND App_Status = 'Approved'";

                using (SqlCommand checkCommand = new SqlCommand(checkApprovedQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@AnimalId", animalId);
                    int approvedCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    string newAnimalStatus = (approvedCount > 0) ? "Adopted" : "Available";

                    string updateAnimalStatusQuery = @"UPDATE Animal SET Animal_Status = @NewStatus 
                                               WHERE Animal_id = @AnimalId";

                    using (SqlCommand updateCommand = new SqlCommand(updateAnimalStatusQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewStatus", newAnimalStatus);
                        updateCommand.Parameters.AddWithValue("@AnimalId", animalId);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating the animal status: " + ex.Message);
            }
        }

        private void btnPetPopularity_Click(object sender, EventArgs e)
        {
            PetsPopularity PetsPopularityForm = new PetsPopularity();
            PetsPopularityForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                LoadAllApplications();
                return;
            }

            string query;
            SqlParameter searchOption;

            if (int.TryParse(searchValue, out int appId))
            {
                query = "SELECT App_Id, App_FullName, App_Address, App_PhoneNumber, App_Email, " +
                        "App_NumAdults, App_NumChildren, App_TimeHome, App_OutdoorSpace, " +
                        "App_PetsHome, App_Animal_id, App_Status " +
                        "FROM Application WHERE App_Id = @SearchValue";

                searchOption = new SqlParameter("@SearchValue", appId);
            }
            else
            {
                query = "SELECT App_Id, App_FullName, App_Address, App_PhoneNumber, App_Email, " +
                        "App_NumAdults, App_NumChildren, App_TimeHome, App_OutdoorSpace, " +
                        "App_PetsHome, App_Animal_id, App_Status " +
                        "FROM Application WHERE App_FullName LIKE @SearchValue";

                searchOption = new SqlParameter("@SearchValue", "%" + searchValue + "%");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(searchOption);

                        SqlDataReader reader = command.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found for the given Application ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching applications: " + ex.Message);
                }
            }
        }
    }   

}
