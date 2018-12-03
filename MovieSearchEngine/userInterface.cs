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

        List<MovieTitle> movieTitles = new List<MovieTitle>();

        StringBuilder query = new StringBuilder();

        public userInterface()
        {
            InitializeComponent();
            uxGenreComboBox.SelectedIndex = 0;
            movieFoundListbox.DataSource = people;
            movieFoundListbox.DisplayMember = "FullInfo";
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            // Base condition for SQL query
            query.Append("SELECT DISTINCT FM.MovieName, FM.ReleaseTime AS [Year] " +
                "FROM FinalProject.Movie FM ");

            // inner join
            innerJoin(query);

            // Where clause
            whereClause(query);

            try
            {
                DataAccess db = new DataAccess();

                movieTitles = db.GetDbData(query.ToString());

                movieFoundListbox.DataSource = movieTitles;
                movieFoundListbox.DisplayMember = "FullInfo";

                query.Clear();
            }
            catch (SqlException ex)
            {
                uxMovieNameTextbox.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }

        private void innerJoin(StringBuilder query)
        {
            String input = "";
            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text.Trim();
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId" +
                    "INNER JOIN FinalProject.People FP" +
                    "ON FP.PeopleId = FPM.PeopleId");
                input = "";
            }// Actor name inner join condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxActorNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId AND FPM.IsActor = True " +
                    "INNER JOIN FinalProject.People FP" +
                    "ON FP.PeopleId = FPM.PeopleId");
                input = "";
            }// Director name inner join condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxDirectorNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId AND FPM.IsDirector = True " +
                    "INNER JOIN FinalProject.People FP" +
                    "ON FP.PeopleId = FPM.PeopleId");
                input = "";
            }

            // Genre
            if (!String.IsNullOrEmpty(uxGenreComboBox.Text))
            {
                input = uxGenreComboBox.Text.Trim();
                if (uxGenreComboBox.SelectedIndex != 0)
                {
                    query.Append("INNER JOIN FinalProject.MovieGenre FMG " +
                        "ON FMG.MovieId = FM.MovieId " +
                        "INNER JOIN FinalProject.Genre FG " +
                        "ON FG.GenreId = FMG.GenreId " +
                        $"and FG.GenreType = '{input} '");
                    input = "";
                }
            }
        }

        private void whereClause(StringBuilder query)
        {
            String input = "";
            String whereClause = "WHERE";
            // Movie name where condition
            if (!String.IsNullOrEmpty(uxMovieNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text;
                query.Append($"{whereClause} FM.MovieName LIKE '%{input}%' ");
                input = "";
                whereClause = "AND";
            }

            if (!String.IsNullOrEmpty(uxYearTextbox.Text))
            {
                input = uxYearTextbox.Text;
                query.Append($"{whereClause} YEAR(FM.ReleaseTime) = {input} ");
                input = "";
                whereClause = "AND";
            }
            
            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                String actorNM = uxActorNameTextbox.Text;
                String directorNM = uxDirectorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{actorNM}%'" +
                    $"OR FP.PeopleName LIKE '{directorNM}'");
                input = "";
                whereClause = "AND";
            }// Actor name where condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxActorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{input}%'");
                input = "";
                whereClause = "AND";
            }// Director name where condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxDirectorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{input}%'");
                input = "";
                whereClause = "AND";
            }            
        }
    }
}
