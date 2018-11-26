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
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("SampleDB")))
            {
                var data = connection.Query<Person>($"select * from Demo.Person where LastName = '{lastName}'").ToList();
                return data;
            }
        }
    }
}
