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
    public partial class CreateAnimal : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        //private string connectionStringPaula = "Data Source = PAULAGO\SQLEXPRESS01; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public CreateAnimal()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string AnimalName = txtName.Text;
            string AnimalAge = txtAge.Text;
            string AnimalSex = cboSex.Text;
            string AnimalBreed = txtBreed.Text;
            string AnimalSize = cboSize.Text;
            string AnimalCategory = cboCategory.Text; 
            string AnimalLocality = cboLocality.Text; 
            string AnimalStatus = cboStatus.Text;
            


            if (string.IsNullOrWhiteSpace(AnimalName))
            {
                errorProvider.SetError(txtName, "Please enter the animal's name");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalAge))
            {
                errorProvider.SetError(txtAge, "Please enter the animal's age");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalSex))
            {
                errorProvider.SetError(cboSex, "Please select the animal's sex");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalBreed))
            {
                errorProvider.SetError(txtBreed, "Please enter the animal's breed");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalSize))
            {
                errorProvider.SetError(cboSize, "Please select the animal's size");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalCategory))
            {
                errorProvider.SetError(cboCategory, "Please select the animal's category");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalLocality))
            {
                errorProvider.SetError(cboLocality, "Please select the animal's locality");
                return;
            }

            if (string.IsNullOrWhiteSpace(AnimalStatus))
            {
                errorProvider.SetError(cboStatus, "Please select the animal's status");
                return;
            }

            if (picAnimal.Image == null)
            {
                errorProvider.SetError(picAnimal, "Please Upload the animal's image.");
                return;
            }

            int locationId = GetLocationId(AnimalLocality);
            int categoryId = GetCategoryId(AnimalCategory);

            if (locationId == -1 || categoryId == -1)
            {
                MessageBox.Show("Invalid category or locality.");
                return;
            }

            string insertQuery = "INSERT INTO Animal VALUES(@Animal_Name, @Animal_Age, @Animal_Sex, @Animal_Breed, @Animal_Size, @Animal_Img, @Animal_Status, @Animal_Location_id, @Animal_Categ_id)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Animal_Name", AnimalName);
                        command.Parameters.AddWithValue("@Animal_Age", AnimalAge);
                        command.Parameters.AddWithValue("@Animal_Sex", AnimalSex);
                        command.Parameters.AddWithValue("@Animal_Breed", AnimalBreed);
                        command.Parameters.AddWithValue("@Animal_Size", AnimalSize);
                        command.Parameters.AddWithValue("@Animal_Img", getImage());
                        command.Parameters.AddWithValue("@Animal_Status", AnimalStatus);
                        command.Parameters.AddWithValue("@Animal_Location_id", locationId);
                        command.Parameters.AddWithValue("@Animal_Categ_id", categoryId);

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Animal added successfully!" : "Failed to add animal");

                        // initialize fields after adding
                        txtName.Text = "";
                        txtAge.Text = "";
                        cboSex.Text = "";
                        txtBreed.Text = "";
                        cboSize.Text = "";
                        cboCategory.Text = "";
                        cboLocality.Text = "";
                        cboStatus.Text = "";
                        picAnimal.Image = null;

                        errorProvider.SetError(txtName, null);
                        errorProvider.SetError(txtAge, null);
                        errorProvider.SetError(cboSex, null);
                        errorProvider.SetError(txtBreed, null);
                        errorProvider.SetError(cboSize, null);
                        errorProvider.SetError(cboCategory, null);
                        errorProvider.SetError(cboLocality, null);
                        errorProvider.SetError(cboStatus, null);
                        errorProvider.SetError(picAnimal, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fail: {ex.Message}");
                }
            }
        }

        private int GetLocationId(string localityDescription)
        {
            string query = "SELECT Animal_Loc_id FROM Animal_Location WHERE Animal_Loc_Descrip = @LocalityDescription";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalityDescription", localityDescription);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Return -1 if the ID is not found
                }
            }
        }

        private int GetCategoryId(string categoryName)
        {
            string query = "SELECT Animal_Categ_id FROM Animal_Category WHERE Animal_Categ_Name = @CategoryName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Return -1 if the ID is not found
                }
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                picAnimal.Image = new Bitmap(open.FileName);
            }
        }

        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            picAnimal.Image.Save(stream, picAnimal.Image.RawFormat);
            return stream.GetBuffer();
        }
    }

}
