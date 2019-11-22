using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bandTogether.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }

        public string name { get; set; }


    }
}