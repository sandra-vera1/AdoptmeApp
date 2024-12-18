﻿using System;
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
using static AdoptmeApplication.Main;

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

        bool Adopted = false;
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
                                    pictureBox1.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pictureBox1.Image = null;
                            }
                            Adopted = reader["Animal_Status"].ToString() == "Adopted";                            
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            EditAnimal UpdateAnimalform = new EditAnimal(animalId);
            UpdateAnimalform.Show();
            AdoptionApplication AdoptionApplicationform = (AdoptionApplication)Application.OpenForms["AdoptionApplication"];  // Get the open instance of Form by name
            if (AdoptionApplicationform != null)
            {
                AdoptionApplicationform.Close();  // Close Form
            }
            this.Enabled = true;
        }

        private void btnAdoptMe_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AdoptionApplication AdoptionApplicationform = new AdoptionApplication(animalId);
            AdoptionApplicationform.Show();
            EditAnimal UpdateAnimalform = (EditAnimal)Application.OpenForms["EditAnimal"];  // Get the open instance of Form by name
            if (UpdateAnimalform != null)
            {
                UpdateAnimalform.Close();  // Close Form
            }
            this.Enabled = true;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
            if (SessionAdministrator.IsLoggedIn)
            {
                btnUpdate.Visible = true;
                btnAdoptMe.Visible = false;
            }
            else
            {
                btnUpdate.Visible = false;
                btnAdoptMe.Visible = !Adopted;
            }
        }
    }
}
