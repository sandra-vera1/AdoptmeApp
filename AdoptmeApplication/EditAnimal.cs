using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoptmeApplication
{
    public partial class EditAnimal : Form
    {
        //private string connectionStringPaula = "Data Source = PAULAGO\SQLEXPRESS01; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;

        private bool isNewImageUploaded = false;//to track if a new image has been uploaded

        private int animalId;
        public EditAnimal(int animalId)
        {
            InitializeComponent();
            this.animalId = animalId;
            LoadAnimalDetails();
        }

        private void LoadAnimalDetails()
        {
            string query = @"SELECT Ani.Animal_Name, Ani.Animal_Age, Ani.Animal_Sex, Ani.Animal_Breed, Ani.Animal_Size, 
            Ani.Animal_Status, Ani.Animal_Img, loc.Animal_Loc_Descrip AS LocationDescription, cat.Animal_Categ_Name AS CategoryName
            FROM Animal Ani 
            INNER JOIN Animal_Location loc ON Ani.Animal_Location_id = loc.Animal_Loc_id
            INNER JOIN Animal_Category cat ON Ani.Animal_Categ_id = cat.Animal_Categ_id
            WHERE Ani.Animal_Id = @animalId";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@animalId", animalId);

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
                            cboLocality.Text = reader["LocationDescription"].ToString();
                            cboCategory.Text = reader["CategoryName"].ToString();


                            if (reader["Animal_Img"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["Animal_Img"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    picAnimal.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                picAnimal.Image = null;
                            }
                        }
                    }
                }
            }
        }
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            string AnimalName = txtName.Text;
            string AnimalAge = txtAge.Text;
            string AnimalSex = cboSex.Text;
            string AnimalBreed = txtBreed.Text;
            string AnimalSize = cboSize.Text;
            string AnimalCategory = cboCategory.Text; // Description
            string AnimalLocality = cboLocality.Text; // Description
            string AnimalStatus = cboStatus.Text;
            ErrorProvider errorProvider = new ErrorProvider();

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

            string updateInfQuery = @"UPDATE Animal SET Animal_Name = @Animal_Name, Animal_Age = @Animal_Age, Animal_Sex = @Animal_Sex, 
                               Animal_Breed = @Animal_Breed, Animal_Size = @Animal_Size, 
                               Animal_Status = @Animal_Status, Animal_Location_id = @Animal_Location_id, 
                               Animal_Categ_id = @Animal_Categ_id"
                               + (isNewImageUploaded ? ", Animal_Img = @Animal_Img" : "") +
                               " WHERE Animal_Id = @Animal_Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateInfQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Animal_Name", AnimalName);
                        command.Parameters.AddWithValue("@Animal_Age", AnimalAge);
                        command.Parameters.AddWithValue("@Animal_Sex", AnimalSex);
                        command.Parameters.AddWithValue("@Animal_Breed", AnimalBreed);
                        command.Parameters.AddWithValue("@Animal_Size", AnimalSize);
                        command.Parameters.AddWithValue("@Animal_Status", AnimalStatus);
                        command.Parameters.AddWithValue("@Animal_Location_id", locationId);
                        command.Parameters.AddWithValue("@Animal_Categ_id", categoryId);
                        command.Parameters.AddWithValue("@Animal_Id", animalId);

                        // If a new image is uploaded, add the image to the command:
                        if (isNewImageUploaded)
                        {
                            command.Parameters.AddWithValue("@Animal_Img", getImage());
                        }

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Animal Updated successfully!" : "Failed to update animal");

                        isNewImageUploaded = false; // Reset the image upload
                        // initialize fields after adding
                        //txtName.Text = "";
                        //txtAge.Text = "";
                        //cboSex.Text = "";
                        //txtBreed.Text = "";
                        //cboSize.Text = "";
                        //cboCategory.Text = "";
                        //cboLocality.Text = "";
                        //cboStatus.Text = "";
                        //picAnimal.Image = null;
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
                isNewImageUploaded = true; // Mark that a new image has been uploaded
            }
        }

        private byte[] getImage()
        {
            if (isNewImageUploaded)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    picAnimal.Image.Save(stream, picAnimal.Image.RawFormat);
                    return stream.ToArray();
                }
            }
            return Array.Empty<byte>();
        }
    }
}
