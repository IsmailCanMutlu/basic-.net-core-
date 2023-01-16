using System;
using System.Collections.Generic;

#nullable disable


namespace W03.Models
{
    public partial class Content
    {


        public Content()
        {
            Movies = new HashSet<Movie>();
            Seriess = new HashSet<Series>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Series> Seriess { get; set; }
    }
}