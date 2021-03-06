﻿using System;
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
        private DataAccess dataAccess = new DataAccess();
        private string username;
        private int userid;
        public userInterface(string User, int userid)
        {
            InitializeComponent();
            uxGenreComboBox.SelectedIndex = 0;
            uxMovieFoundListbox.DataSource = movieInfo;
            uxMovieFoundListbox.DisplayMember = "FullInfo";
            uxReviewSubmitButton.Enabled = false;
            username = User;
            this.userid = userid;
            uxWelcomeLabel.Text = $"Welcome, {username}!";
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            uxMovieDetailTextbox.Clear();
            movieInfo = new List<MovieDetail>();
            // Base condition for SQL query
            query.Append("SELECT DISTINCT FM.MovieName, FM.ReleaseTime AS [Year], FM.MovieDescription, FG.GenreType " +
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
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
            }
        }
        private void uxRandomPickButton_Click(object sender, EventArgs e)
        {
            uxMovieDetailTextbox.Clear();
            Random rnd = new Random();
            int Mid = rnd.Next(16);
            query.Append("SELECT DISTINCT FM.MovieName, FM.ReleaseTime AS [Year]," +
                " FM.MovieDescription, FG.GenreType FROM FinalProject.Movie FM " +
                "INNER JOIN FinalProject.MovieGenre FMG ON FMG.MovieId = FM.MovieId " +
                "INNER JOIN FinalProject.Genre FG ON FG.GenreId = FMG.GenreId " +
                $"WHERE FM.MovieId = {Mid}");
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
                MessageBox.Show(ex.ToString());
                //Console.WriteLine(ex.ToString());
            }
        }

        private void uxMovieFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            peopleInfo = new List<PeopleDetail>();
            movieReviews = new List<MovieReview>();
            uxReviewSubmitButton.Enabled = true;
            int index = uxMovieFoundListbox.SelectedIndex;
            ShowDetail(index);
            ShowReview(index);
        }

        private void uxPushRevButton_Click(object sender, EventArgs e)
        {
            string newReview = uxNewReviewTextbox.Text;
            string moviewNM = movieInfo[uxMovieFoundListbox.SelectedIndex].MovieName;
            query.Clear();
            query.Append($"INSERT FinalProject.Review(MovieId, UsersId, Comment) " +
                $"SELECT m.MovieId, r.UserId, r.Comment " +
                $"FROM " +
                $"(" +
                $"VALUES " +
                $"(N'{moviewNM}',N'{userid}', N'{newReview}') " +
                $") r (MovieName, UserId, Comment) " +
                $"INNER JOIN FinalProject.Movie m ON m.MovieName = r.MovieName;");
            dataAccess.pushReview(query.ToString());
            uxNewReviewTextbox.Clear();
            MessageBox.Show("Review submitted!");
            ShowReview(uxMovieFoundListbox.SelectedIndex);
        }
        /// <summary>
        /// delete button handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReviewDeleteButton_Click(object sender, EventArgs e)
        {
            if(uxReviewList.SelectedIndex != -1)
            {
                MovieReview mr = movieReviews[uxReviewList.SelectedIndex];
                if (mr.UserId == userid)
                {                    
                    int Rid = mr.ReviewId;
                    query.Clear();
                    query.Append($"DELETE FROM FinalProject.Review " +
                        $"WHERE ReviewId = {Rid} ");
                    dataAccess.pushReview(query.ToString());
                    uxNewReviewTextbox.Clear();
                    MessageBox.Show("Review Delete!");
                    ShowReview(uxMovieFoundListbox.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("You can only delete your own reviews!");
                }

            }
            else
            {
                MessageBox.Show("No Review Selected!");
            }

        }

        private void innerJoin(StringBuilder query)
        {
            String input = "";
            // Both actor name inputed by user
            if (!String.IsNullOrEmpty(uxActorNameTextbox.Text) && !String.IsNullOrEmpty(uxDirectorNameTextbox.Text))
            {

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

            query.Append("INNER JOIN FinalProject.MovieGenre FMG " +
                "ON FMG.MovieId = FM.MovieId " +
                "INNER JOIN FinalProject.Genre FG " +
                "ON FG.GenreId = FMG.GenreId ");
            // Genre
            if (!String.IsNullOrEmpty(uxGenreComboBox.Text))
            {
                input = uxGenreComboBox.Text.Trim();
                if (uxGenreComboBox.SelectedIndex != 0)
                {
                    query.Append($"AND FG.GenreType = '{input}' ");
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
                query.Clear();
                query.Append($"SELECT DISTINCT TB.MovieName, TB.[Year]" +
                    $"FROM(" +
                        $"SELECT DISTINCT FM.MovieName, FM.ReleaseTime AS[Year], FPM.MovieId " +
                        $"FROM FinalProject.Movie FM " +
                        $"INNER JOIN FinalProject.PeopleMovie FPM ON FPM.MovieId = FM.MovieId " +
                        $"INNER JOIN FinalProject.People FP ON FP.PeopleId = FPM.PeopleId " +
                        $"WHERE FP.PeopleName LIKE '%{actorNM}%') TB " +
                        $"INNER JOIN FinalProject.PeopleMovie FPM ON FPM.MovieId = TB.MovieId " +
                        $"INNER JOIN FinalProject.People FP ON FP.PeopleId = FPM.PeopleId " +
                        $"WHERE FP.PeopleName LIKE '%{directorNM}%'");
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
            try
            {
                DataAccess db = new DataAccess();
                var data = query.ToString();
                peopleInfo = db.GetPeopleDetail(query.ToString());
                StringBuilder info = new StringBuilder();
                info.Append($"Movie Name: {mn}\r\n" +
                    $"\r\nReleased by {movieInfo[i].Year}\r\n" +
                    $"\r\nMovie Genre: {movieInfo[i].GenreType}\r\n" +
                    $"\r\nDescription: {movieInfo[i].MovieDescription}\r\n");
                string dname ="UNKNOWN";
                foreach(PeopleDetail p in peopleInfo)
                {
                    if(p.IsDirector == 1)
                    {
                        dname = p.PeopleName;
                        break;
                    }
                }
                info.Append($"\r\nDirector: {dname} \r\n");
                info.Append("\r\nActor(s): ");
                foreach (PeopleDetail p in peopleInfo)
                {
                    if (p.IsActor == 1)
                    {
                        info.Append($"{p.PeopleName} \r\n                ");
                    }
                }
                uxMovieDetailTextbox.Text = info.ToString();
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
            string moviewNM = movieInfo[uxMovieFoundListbox.SelectedIndex].MovieName;
            DataAccess db = new DataAccess();
            query.Clear();
            query.Append($"SELECT R.UsersId, U.UserName, R.ReviewId, R.Comment, R.CreatedTime " +
                $"FROM FinalProject.Movie M " +
                $"INNER JOIN FinalProject.Review R ON R.MovieId = M.MovieId " +
                $"INNER JOIN FinalProject.Users U ON U.UserId = R.UsersId " +
                $"WHERE M.MovieName = '{moviewNM}'");
            movieReviews = db.GetMovieReviews(query.ToString());
            StringBuilder info = new StringBuilder();
            foreach(MovieReview mr in movieReviews)
            {
                info.Append(mr.FullInfo);
            }
            uxReviewList.DataSource = movieReviews;
            uxReviewList.DisplayMember = "FullInfo";
        }
    }
}
