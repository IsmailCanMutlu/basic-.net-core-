using System;
using W03.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace W03.Dtos
{
    public class SeriesDtos
    {
        public int Id { get; set; }
        public int Content_Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Views { get; set; }
        public int Season { get; set; }
        public virtual Content Content { get; set; }
    }
}