using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class Person
    {
        public int PersonalId { get; set; }
        public String FirstName { get; set; }
        public String MiddleInitial { get; set; }
        public String LastName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({PersonalId})";
            }
        }
    }
}
