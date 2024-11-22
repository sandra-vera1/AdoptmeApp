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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdoptmeApplication
{
    public partial class CreateCategory : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
        public CreateCategory()
        {
            InitializeComponent();
        }

        private void btnSaveAnimalCategory_Click(object sender, EventArgs e)
        {
            string category = textCategoryName.Text;

            if (string.IsNullOrWhiteSpace(category))
            {
                errorProvider.SetError(textCategoryName, "Category must be not empty");
                return;
            }

            string insertQuery = "INSERT INTO Animal_Category (Animal_Categ_Name) VALUES(@Animal_Category)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Animal_Category", category);
                        
                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(rowsAffected > 0 ? "Category added successfully!" : "Fail to add category");

                        textCategoryName.Text = "";
                        errorProvider.SetError(textCategoryName, null);
                    }
                }
                catch (Exception ex)
                {
                   if(ex.Message.Contains("UNIQUE KEY"))
                    {
                        //Applied in the databaase: ALTER TABLE Animal_Category ADD CONSTRAINT UK_AnimalCat_Name UNIQUE(Animal_Categ_Name)
                        errorProvider.SetError(textCategoryName, "Category name must be unique");
                    }
                    else
                    {
                        MessageBox.Show("Fail: " + ex.Message);
                    }
                }
            }
        }
    }
}
