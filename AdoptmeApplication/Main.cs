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
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the URL in the default web browser
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        DataTable dataTableAnimals;
        private void LoadAllAnimals()
        {
            string query = "SELECT Ani.Animal_id, Ani.Animal_Name, Ani.Animal_Age, Ani.Animal_Sex, Ani.Animal_Img, " +
                "Ani.Animal_Location_id, Ani.Animal_Categ_id, Cat.Animal_Categ_Name, Loc.Animal_Loc_Descrip, Ani.Animal_Status  " +
                "FROM Animal AS Ani " +
                "INNER JOIN Animal_Category AS Cat ON Ani.Animal_Categ_id = Cat.Animal_Categ_id " +
                "INNER JOIN Animal_Location AS Loc ON Ani.Animal_Location_id = Loc.Animal_Loc_id";
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
                        dataTableAnimals = dataTable;
                        FillDataGrid(dataTable);
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

        private void FillDataGrid(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
            dataGridView1.ClearSelection();
            //I added these three line of code to adjust the size of the column to see the image:
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["Animal_Img"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.RowTemplate.Height = 150;
            dataGridView1.Columns["Animal_id"].Visible = false;
            dataGridView1.Columns["Animal_Location_id"].Visible = false;
            dataGridView1.Columns["Animal_Categ_id"].Visible = false;
        }

        private void createAnimalToolStripMenuItem_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            CreateAnimal CreateAnimalForm = new CreateAnimal();
            CreateAnimalForm.ShowDialog();
            this.Enabled = true;
            LoadAllAnimals();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            CreateCategory CreateCategoryForm = new CreateCategory();
            CreateCategoryForm.ShowDialog();
            this.Enabled = true;
            LoadAllTypeAnimals();
        }

        private void viewApplicationsToolStripMenuItem_Click(object sender, EventArgs e) // Menu
        {
            this.Enabled = false;
            ApplicationList ApplicationListForm = new ApplicationList();
            ApplicationListForm.ShowDialog();
            this.Enabled = true;
            LoadAllAnimals();
        }

        private void SelectAnimalDetails_Click(object sender, EventArgs e) // Menu
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int animalId = Convert.ToInt32(selectedRow.Cells["Animal_id"].Value.ToString());
                this.Enabled = false;
                AnimalDetails animalDetails = new AnimalDetails(animalId);
                animalDetails.ShowDialog();
                this.Enabled = true;
                LoadAllAnimals();
            }
            else
            {
                MessageBox.Show("Please, select at least one animal");
            }
        }

        // Event handler to get the selected Id when an item is selected
        private void SearchAnimal_Click(object sender, EventArgs e)
        {
            string Filter = LocalityId != -1 ? $" Animal_Location_id = {LocalityId} " : "";
            Filter += LocalityId != -1 && TypeAnimalIdSelected != -1 ? " AND " : "";
            Filter += TypeAnimalIdSelected != -1 ? $" Animal_Categ_id = {TypeAnimalIdSelected} " : "";
            DataRow[] dr = dataTableAnimals.Select(Filter);
            DataTable animals = dataTableAnimals.Clone();
            foreach (DataRow row in dr)
            {
                animals.ImportRow(row);
            }
            dataGridView1.DataSource = animals;
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
                        cboLocality.Items.Add(new ComboBoxItem
                        {
                            Text = "All",
                            Value = -1
                        });
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
                        cboLocality.SelectedIndex = 0;
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

        int LocalityId = -1;
        // Event handler to get the selected Id when an item is selected
        private void cboLocality_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item (ComboBoxItem) and cast it
            ComboBoxItem selectedItem = (ComboBoxItem)cboLocality.SelectedItem;

            // Retrieve the Id from the Value property
            LocalityId = (int)selectedItem.Value;
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

                        cboTypeAnimal.Items.Add(new ComboBoxItemA
                        {
                            Animal_Loc_DescripText = "All",
                            Animal_Loc_idValue = -1
                        });
                        while (reader.Read())
                        {
                            // Add category name to ComboBox, but store Id as the value
                            cboTypeAnimal.Items.Add(new ComboBoxItemA
                            {
                                Animal_Loc_DescripText = reader["Animal_Categ_Name"].ToString(),
                                Animal_Loc_idValue = reader["Animal_Categ_id"]
                            });
                        }
                        cboTypeAnimal.SelectedIndex = 0;
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

        int TypeAnimalIdSelected = -1;
        // Event handler to get the selected Id when an item is selected
        private void cboTypeAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item (ComboBoxItem) and cast it
            ComboBoxItemA selectedItem = (ComboBoxItemA)cboTypeAnimal.SelectedItem;

            // Retrieve the Id from the Value property
            TypeAnimalIdSelected = (int)selectedItem.Animal_Loc_idValue;
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
