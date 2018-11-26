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
        List<Person> people = new List<Person>();
        public userInterface()
        {
            InitializeComponent();
            uxGenereDropDownList.SelectedIndex = 0;
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                people = db.GetPeople(uxSearchBox.Text);

                movieFoundListbox.DataSource = people;
                movieFoundListbox.DisplayMember = "FullInfo";

                /*
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "mssql.cs.ksu.edu";   // update me
                builder.UserID = "WIN2\\jayie21";              // update me
                builder.Password = "";      // update me
                builder.InitialCatalog = "master";

                // Connect to SQL
                uxSearchBox.Text = "Connecting to SQL Server ... ";
                //Console.Write("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    //Console.WriteLine("Done.");
                    uxSearchBox.Text = "Done";
                }*/
            }
            catch (SqlException ex)
            {
                uxSearchBox.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
