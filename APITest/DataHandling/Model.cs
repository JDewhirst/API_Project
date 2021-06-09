using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    public class Result
    {
        public Film[] films { get; set; }
    }

    public class Film
    {
        public int id { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string[] actors { get; set; }
        public string directors { get; set; }
        public string rating { get; set; }
        public string[] category { get; set; }
        public string Company { get; set; }
        public string releaseDate { get; set; }
        public string[] languages { get; set; }
    }

}
