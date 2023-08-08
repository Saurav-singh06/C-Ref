using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sample
{
    internal class Movie
    {
        public String title;
        public String director;
        private String rating;

        public Movie(string title, String director, String rating)
        {
            this.title = title;
            this.director = director;
           // this.rating = rating;   
            // For more Secure
             Rating = rating;
    }

        public string Rating
        {
            get { return rating; }
            set { 
            if(value == "G" || value == "PG" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }

}
