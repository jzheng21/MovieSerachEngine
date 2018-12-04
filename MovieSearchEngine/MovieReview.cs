using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchEngine
{
    public class MovieReview
    {
        public String Comment { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{Comment} \r\n      posted on {CreatedTime.DateTime.ToString()}";
            }
        }

    }
}
