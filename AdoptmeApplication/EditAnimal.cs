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

        
        public EditAnimal()
        {
            InitializeComponent();
        }

        private void LoadAnimalDetails(int animalId)
        {
            
        }
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            
        }
        
        
        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            picAnimal.Image.Save(stream, picAnimal.Image.RawFormat);
            return stream.GetBuffer();
        }

    }

}
