using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Week10.Models
{
    public class Genre
    {
        public Genre(string Name)
        {
            this.Name = Name;
        }


        public string Name { get; set; }
    }

}