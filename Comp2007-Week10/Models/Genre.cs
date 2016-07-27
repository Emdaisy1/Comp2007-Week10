using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Week10.Models
{
    public class Genre
    {
        public Genre(string Name)
        {
            this.Name = Name;
        }


        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }

}