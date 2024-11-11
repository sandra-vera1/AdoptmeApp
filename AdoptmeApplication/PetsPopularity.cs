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
    public partial class PetsPopularity : Form
    {
        //private string connectionStringPaula = "Data Source = PAULAGO\SQLEXPRESS01; Initial Catalog = AdoptmeApp; Integrated Security = True";
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public PetsPopularity()
        {
            InitializeComponent();
            LoadPeatPopularity();
        }

        private void LoadPeatPopularity()
        {
            string query = @"SELECT 
                            A.App_Animal_id AS AnimalID,
                            AN.Animal_Name AS AnimalName,
                            COUNT(*) AS ApplicationCount
                            FROM Application A
                            INNER JOIN Animal AN ON A.App_Animal_id = AN.Animal_id
                            GROUP BY A.App_Animal_id, AN.Animal_Name
                            ORDER BY ApplicationCount DESC";

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

                        dataGridView1.Columns["AnimalID"].HeaderText = "Animal ID";
                        dataGridView1.Columns["AnimalName"].HeaderText = "Animal Name";
                        dataGridView1.Columns["ApplicationCount"].HeaderText = "Number of Applications";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading pet popularity: " + ex.Message);
                }
            }
        }
    }
}
