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
            this.uxSearchText.AutoSize = false;
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();

                people = db.GetPeople(uxSearchText.Text);

                movieFoundListbox.DataSource = people;
                movieFoundListbox.DisplayMember = "FullInfo";
            }
            catch (SqlException ex)
            {
                uxSearchText.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
