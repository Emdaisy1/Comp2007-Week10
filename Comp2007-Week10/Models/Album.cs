using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Week10.Models
{
    public class Album
    {
        /// <summary>
        /// Constructor Method
        /// </summary>
        /// <param name="Title"></param>

        public Album(string Title)
        {
            this.Title = Title;
        }
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }

}