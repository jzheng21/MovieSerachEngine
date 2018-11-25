using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSearchEngine
{
    public partial class userInterface : Form
    {
        public userInterface()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "your_password";      // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                uxSearchBox.Text = "Connecting to SQL Server ... ";
                //Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    //Console.WriteLine("Done.");
                    uxSearchBox.Text = "Done";
                }
            }
            catch (SqlException ex)
            {
                uxSearchBox.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
