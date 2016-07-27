using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Week10.Models
{
    public class Genre
    {
        public Genre()
        {

        }
        public Genre(string Name)
        {
            this.Name = Name;
        }


        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }

}