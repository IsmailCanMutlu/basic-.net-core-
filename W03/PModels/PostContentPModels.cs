using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace W03.PModels
{
    public class PostContentPModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}