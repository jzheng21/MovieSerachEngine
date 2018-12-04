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
        List<MovieDetail> movieInfo = new List<MovieDetail>();
        List<PeopleDetail> peopleInfo = new List<PeopleDetail>();
        List<MovieReview> movieReviews = new List<MovieReview>();
        StringBuilder query = new StringBuilder();

        public userInterface()
        {
            InitializeComponent();
            uxGenreComboBox.SelectedIndex = 0;
            uxMovieFoundListbox.DataSource = people;
            uxMovieFoundListbox.DisplayMember = "FullInfo";
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
                var data = query.ToString();
                movieInfo = db.GetMovieDetail(query.ToString());

                uxMovieFoundListbox.DataSource = movieInfo;
                uxMovieFoundListbox.DisplayMember = "FullInfo";

                query.Clear();
            }
            catch (SqlException ex)
            {
                uxMovieNameTextbox.Text = ex.ToString();
                //Console.WriteLine(ex.ToString());
            }
        }

        private void uxMovieFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uxMovieFoundListbox.SelectedIndex;
            ShowDetail(index);
            ShowReview(index);
        }

        private void uxPushRevButton_Click(object sender, EventArgs e)
        {
            string newReview = uxNewReviewTextbox.Text;
        }

        private void innerJoin(StringBuilder query)
        {
            String input = "";
            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxDirectorNameTextbox.Text))
            {
                input = uxMovieNameTextbox.Text.Trim();
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId " +
                    "INNER JOIN FinalProject.People FP " +
                    "ON FP.PeopleId = FPM.PeopleId ");
                input = "";
            }// Actor name inner join condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxActorNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId " +
                    "INNER JOIN FinalProject.People FP " +
                    "ON FP.PeopleId = FPM.PeopleId ");
                input = "";
            }// Director name inner join condition
            else if (!String.IsNullOrEmpty(uxDirectorNameTextbox.Text))
            {
                input = uxDirectorNameTextbox.Text;
                query.Append("INNER JOIN FinalProject.PeopleMovie FPM " +
                    "ON FPM.MovieId = FM.MovieId " +
                    "INNER JOIN FinalProject.People FP " +
                    "ON FP.PeopleId = FPM.PeopleId ");
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
                        $"AND FG.GenreType = '{input}' ");
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
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxDirectorNameTextbox.Text))
            {
                String actorNM = uxActorNameTextbox.Text;
                String directorNM = uxDirectorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{actorNM}%'" +
                    $"AND FP.PeopleName LIKE '%{directorNM}%'");
                input = "";
                whereClause = "AND";
            }// Actor name where condition
            else if (!String.IsNullOrEmpty(uxActorNameTextbox.Text))
            {
                input = uxActorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{input}%' AND FPM.isActor = 'True'");
                input = "";
                whereClause = "AND";
            }// Director name where condition
            else if (!String.IsNullOrEmpty(uxDirectorNameTextbox.Text))
            {
                input = uxDirectorNameTextbox.Text;
                query.Append($"{whereClause} FP.PeopleName LIKE '%{input}%' AND FPM.isDirector = 'True'");
                input = "";
                whereClause = "AND";
            }            
        }

        private void ShowDetail(int i)
        {
            string mn = movieInfo[i].MovieName;
            query = new StringBuilder();
            query.Append($"SELECT DISTINCT FP.PeopleName, FP.BornCountry, FPM.IsActor, FPM.IsDirector " +
                "FROM FinalProject.Movie FM " +
                "INNER JOIN FinalProject.PeopleMovie FPM ON FPM.MovieId = FM.MovieId " +
                    "INNER JOIN FinalProject.People FP " +
                    "ON FP.PeopleId = FPM.PeopleId " +
                    $"WHERE FM.MovieName = N'{mn}' ");
            mn = "";
            try
            {
                DataAccess pdb = new DataAccess();
                peopleInfo = pdb.GetPeopleDetail(query.ToString());
                
                query.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
            }
        }
        private void ShowReview(int i)
        {

        }
    }
}
