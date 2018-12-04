using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class MovieReview
    {
        public String Review { get; set; }
        public DateTime Time { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{Review} \r\n      posted on {Time.ToString()}";
            }
        }

    }
}
