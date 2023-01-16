using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace W03.PModels
{
    public class PostSeriesPModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Content_Id { get; set; }
        public string Genre { get; set; }
        public int Season { get; set; }
        public int Views { get; set; }
    }
}