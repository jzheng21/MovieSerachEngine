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
        public List<MovieTitle> GetMovieTitles(string query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("SampleDB")))
            {
                var data = connection.Query<MovieTitle>(query).ToList();
                return data;
            }
        }
    }
}
