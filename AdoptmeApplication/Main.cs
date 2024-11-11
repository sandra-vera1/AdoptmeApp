using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AdoptmeApplication
{
    public partial class Main : Form
    {
        //private string connectionStringSandra = "Data Source = SMVG\\SQLEXPRESS; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public Main()
        {
            InitializeComponent();
            LoadAllAnimals();
            LoadAllLocations();
            LoadAllTypeAnimals();

            // Load image from Visual Studio's Properties.Resources to handle images as embedded resources.
            pictureBox3.Image = Properties.Resources.Canary;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            // this.BackgroundImage = imageList1.Images[0];



        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void LoadAllAnimals()
        {
            string query = "SELECT Animal_id, Animal_Name, Animal_Age, Animal_Sex, Animal_Img FROM Animal"; //I added Animal_Img to validate the image
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

                        //I added these three line of code to adjust the size of the column to see the image:
                        DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Animal_Img"];
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        dataGridView1.RowTemplate.Height = 150;
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Fail: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }



        }

        private void createAnimalToolStripMenuItem_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            CreateAnimal CreateAnimalForm = new CreateAnimal();
            CreateAnimalForm.ShowDialog();
            this.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            CreateCategory CreateCategoryForm = new CreateCategory();
            CreateCategoryForm.ShowDialog();
            this.Enabled = true;

        }

        private void viewApplicationsToolStripMenuItem_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            ApplicationList ApplicationListForm = new ApplicationList();
            ApplicationListForm.ShowDialog();
            this.Enabled = true;
        }


        /// <summary>
        /// ComboBox about Locations
        /// </summary>
        private void LoadAllLocations()
        {
            string query = "SELECT Animal_Loc_id, Animal_Loc_Descrip FROM Animal_Location";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        cboLocality.Items.Clear();

                        while (reader.Read())
                        {
                            // Add name to ComboBox, but store Id as the value
                            cboLocality.Items.Add(new ComboBoxItem
                            {
                                Text = reader["Animal_Loc_Descrip"].ToString(),
                                Value = reader["Animal_Loc_id"]
                            });
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Fail: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }



        }


        // Event handler to get the selected Id when an item is selected
        private void cboLocality_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item (ComboBoxItem) and cast it
            ComboBoxItem selectedItem = (ComboBoxItem)cboLocality.SelectedItem;

            // Retrieve the Id from the Value property
            int Id = (int)selectedItem.Value;
            MessageBox.Show("Selected Id: " + Id);
        }

        // Define a class to hold the ComboBox item (text and value)
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            // Override ToString to display text in ComboBox
            public override string ToString()
            {
                return Text;
            }
        }

        /// <summary>
        /// End ComboBox about Locations
        /// </summary>
        /// 

        /// <summary>
        /// ComboBox about Type of animals
        /// </summary>
        private void LoadAllTypeAnimals()
        {
            string query = "SELECT Animal_Categ_id, Animal_Categ_Name FROM Animal_Category";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        cboTypeAnimal.Items.Clear();

                        while (reader.Read())
                        {
                            // Add category name to ComboBox, but store Id as the value
                            cboTypeAnimal.Items.Add(new ComboBoxItemA
                            {
                                Animal_Loc_DescripText = reader["Animal_Categ_Name"].ToString(),
                                Animal_Loc_idValue = reader["Animal_Categ_id"]
                            });
                        }

                        reader.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Fail: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }



        }


        // Event handler to get the selected Id when an item is selected
        private void cboTypeAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item (ComboBoxItem) and cast it
            ComboBoxItemA selectedItem = (ComboBoxItemA)cboTypeAnimal.SelectedItem;

            // Retrieve the Id from the Value property
            int Id = (int)selectedItem.Animal_Loc_idValue;
            MessageBox.Show("Selected Id: " + Id);
        }

        // Define a class to hold the ComboBox item (text and value)
        public class ComboBoxItemA
        {
            public string Animal_Loc_DescripText { get; set; }
            public object Animal_Loc_idValue { get; set; }

            // Override ToString to display text in ComboBox
            public override string ToString()
            {
                return Animal_Loc_DescripText;
            }
        }

        /// <summary>
        /// End ComboBox about Type of animals
        /// </summary>


    }
}
