using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Films;

namespace WebApplication1.Models
{
    public class Recommendation
    {
        public Recommendation()
        {
            films = new List<Film>();
        }
        public string GenreName { get; set; }
        public List<Film> films { get; set; }
    }
}