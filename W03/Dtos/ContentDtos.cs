using System;
using W03.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace W03.Dtos
{
    public partial class ContentDtos
    {
        public ContentDtos()
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