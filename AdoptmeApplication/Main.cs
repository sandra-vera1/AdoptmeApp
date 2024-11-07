using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
        }

        private void LoadAllAnimals()
        {
            string query = "SELECT Animal_id, Animal_Name, Animal_Age, Animal_Sex FROM Animal";
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

    }
}
