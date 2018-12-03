using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class MovieTitle
    {
        public string MovieName { get; set; }
        public DateTime Year { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{MovieName} ({Year.Year.ToString()})";
            }
        }
    }
}
