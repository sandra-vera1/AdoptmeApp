using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptmeApplication
{
    public partial class AnimalDetails : Form
    {

        //private string connectionStringPaula = "Data Source = PAULAGO\SQLEXPRESS01; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

        private int animalId;
        public AnimalDetails(int animalId)
        {
            InitializeComponent();
            this.animalId = animalId;
            LoadAnimalDetails();
        }

        private void AnimalDetails_Load(object sender, EventArgs e)
        {
            LoadAnimalDetails();
        }

        private void LoadAnimalDetails()
        {
            string query = "SELECT Animal_Name, Animal_Age, Animal_Sex, Animal_Breed, Animal_Size, Animal_Status, Animal_Location_id, Animal_Categ_id " +
                           "FROM Animal WHERE Animal_Id = @AnimalId";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AnimalId", animalId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Animal_Name"].ToString();
                            txtAge.Text = reader["Animal_Age"].ToString();
                            cboSex.Text = reader["Animal_Sex"].ToString();
                            txtBreed.Text = reader["Animal_Breed"].ToString();
                            cboSize.Text = reader["Animal_Size"].ToString();
                            cboStatus.Text = reader["Animal_Status"].ToString();

                            int locationId = Convert.ToInt32(reader["Animal_Location_id"]);
                            int categoryId = Convert.ToInt32(reader["Animal_Categ_id"]);

                            cboLocality.Text = GetLocationId(locationId);
                            cboCategory.Text = GetCategoryId(categoryId);
                        }
                    }
                }
            }
        }
        private string GetLocationId(int locationId)
        {
            string query = "SELECT Animal_Loc_Descrip FROM Animal_Location WHERE Animal_Loc_id = @LocationId";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocationId", locationId);
                    return command.ExecuteScalar()?.ToString() ?? string.Empty;
                }
            }
        }

        private string GetCategoryId(int categoryId)
        {
            string query = "SELECT Animal_Categ_Name FROM Animal_Category WHERE Animal_Categ_id = @CategoryId";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryId", categoryId);
                    return command.ExecuteScalar()?.ToString() ?? string.Empty;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditAnimal UpdateAnimalform = new EditAnimal();
            UpdateAnimalform.Show();
        }

        private void btnAdoptMe_Click(object sender, EventArgs e)
        {
            AdoptionApplication AdoptionApplicationform = new AdoptionApplication();
            AdoptionApplicationform.Show();
        }
    }
}
