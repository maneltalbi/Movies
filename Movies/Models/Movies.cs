using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movies
    {
        [Key]
        public int IdMovies { get; set; }
        public string title { get; set; }
        public string voteAverage { get; set; }
        public string Overview { get; set; }
    }
}
