using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MovieSearchEngine
{
    public class DataAccess
    {
        public List<MovieDetail> GetMovieDetail(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("SampleDB")))
            {
                var data = connection.Query<MovieDetail>(query)?.ToList();
                return data;
            }
        }

        public List<PeopleDetail> GetPeopleDetail(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("SampleDB")))
            {
                var data = connection.Query<PeopleDetail>(query).ToList();
                return data;
            }
        }

        public List<MovieReview> GetMovieReviews(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("SampleDB")))
            {
                var data = connection.Query<MovieReview>(query).ToList();
                return data;
            }
        }
    }
}
