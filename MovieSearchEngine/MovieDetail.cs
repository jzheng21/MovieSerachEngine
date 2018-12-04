using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class MovieDetail
    {
        public string MovieName { get; set; }
        public DateTime Year { get; set; }
        public string MovieDescription { get; set; }
        public string GenreType { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{MovieName} ({Year.Year.ToString()})";
            }
        }
    }
}
