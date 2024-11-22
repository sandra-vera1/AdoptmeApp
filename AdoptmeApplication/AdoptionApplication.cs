using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptmeApplication
{
    public partial class AdoptionApplication : Form
    {
        private int animalId;
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public AdoptionApplication(int animalId)
        {
            InitializeComponent();
            this.animalId = animalId;
            txtAnimalId.Text = animalId.ToString();
        }

        private void btnSendApplication_Click(object sender, EventArgs e)
        {
            
            string FullName = txtFullName.Text;
            string Address = txtAddress.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string NumAdult = cboNumAdult.Text; ///pending validate 
            string NumChildren = cboNumChildren.Text;  ///pending validate 
            string NumPets = cboNumPets.Text; ///pending validate 
            string TimeHome = cboTimeHome.Text; ///pending validate 
            string OutdoorAv = cboOutdoorAv.Text; ///pending validate
            string Status = "Pending";

            if (string.IsNullOrWhiteSpace(FullName))
            {
                errorProvider.SetError(txtFullName, "Full name of applicant must be not empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                errorProvider.SetError(txtAddress, "Address of applicant must be not empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                errorProvider.SetError(txtPhoneNumber, "Phone number of applicant must be not empty");
                return;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                errorProvider.SetError(txtEmail, "Email of applicant must be not empty");
                return;
            }

            string insertQuery = "INSERT INTO Application (App_FullName,App_Address,App_PhoneNumber,App_Email,App_NumAdults, " +
                "App_NumChildren,App_TimeHome,App_OutdoorSpace,App_PetsHome,App_Status,App_Animal_id) " +
                " VALUES(@App_FullName,@App_Address,@App_PhoneNumber,@App_Email,@App_NumAdults, " +
                "@App_NumChildren,@App_TimeHome,@App_OutdoorSpace,@App_PetsHome,@App_Status,@App_Animal_id)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@App_FullName", FullName);
                        command.Parameters.AddWithValue("@App_Address", Address);
                        command.Parameters.AddWithValue("@App_PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@App_Email", Email);
                        command.Parameters.AddWithValue("@App_NumAdults", NumAdult);
                        command.Parameters.AddWithValue("@App_NumChildren", NumChildren);
                        command.Parameters.AddWithValue("@App_TimeHome", TimeHome);
                        command.Parameters.AddWithValue("@App_OutdoorSpace", OutdoorAv);
                        command.Parameters.AddWithValue("@App_PetsHome", NumPets);
                        command.Parameters.AddWithValue("@App_Status", Status);
                        command.Parameters.AddWithValue("@App_Animal_id", animalId);

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Application added successfully. If it is approved, we will contact you for email or telephone. Thanks for want to adopted!" : "Fail to add application");

                        txtFullName.Text = "";
                        txtAddress.Text = "";
                        txtPhoneNumber.Text = "";
                        txtEmail.Text = "";
                        cboNumAdult.Text = "";
                        cboNumChildren.Text = "";      
                        cboNumPets.Text = ""; 
                        cboTimeHome.Text = "";
                        cboOutdoorAv.Text = "";

                        errorProvider.SetError(txtFullName, null);
                        errorProvider.SetError(txtAddress, null);
                        errorProvider.SetError(txtPhoneNumber, null);
                        errorProvider.SetError(txtEmail, null);

                    }
                }
                catch (Exception ex)
                {
                    
                        MessageBox.Show("Fail: " + ex.Message);
                    
                }
            }
        }
    }
}
