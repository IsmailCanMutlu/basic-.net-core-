using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace W03.Models
{
    public partial class Series
    {

        public int Id { get; set; }
        public int Content_Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Seison { get; set; }
        public int Views { get; set; }



        public virtual Content Content { get; set; }
    }


}