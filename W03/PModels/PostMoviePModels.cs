using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace W03.PModels
{
    public class PostMoviePModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Content_Id { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public int Views { get; set; }
    }
}