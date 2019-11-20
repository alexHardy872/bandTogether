using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bandTogether.Models.SocialModels
{
    public class SocialUser
    {
        [Key]
        public int SocialUserId { get; set; }
       

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int followers { get; set; }


     



    }
}