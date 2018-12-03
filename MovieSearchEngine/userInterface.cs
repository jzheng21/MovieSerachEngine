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

        StringBuilder query = new StringBuilder();

        public userInterface()
        {
            InitializeComponent();
            movieFoundListbox.DataSource = people;
            movieFoundListbox.DisplayMember = "FullInfo";
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            // Base condition for SQL query
            query.Append("SELECT DISTINCT FM.MovieName " +
                "FROM FinalProject.Movie FM ");

            String input = "";

            // Inner join clause
            // Actor name inner join condition
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId AND FPM.IsActor = True ");
                input = "";
            }

            // Director name inner join condition
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId AND FPM.IsDirector = True ");
                input = "";
            }

            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId");
                input = "";
            }

            // Where clause
            String whereClause = "WHERE";
            // Movie name where condition
            if (!String.IsNullOrEmpty(uxMovieNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append($"{whereClause} FM.MovieName = '{input}' ");
                input = "";
                whereClause = "AND";
            }

            // Actor name where condition
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM ");
                input = "";
            }

            // Director name inner join condition
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId AND FPM.IsDirector = True ");
                input = "";
            }

            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId");
                input = "";
            }

            try
            {
                DataAccess db = new DataAccess();

                people = db.GetPeople(uxMovieNameTextbox.Text);

                movieFoundListbox.DataSource = people;
                movieFoundListbox.DisplayMember = "FullInfo";
            }
            catch (SqlException ex)
            {
                uxMovieNameTextbox.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
