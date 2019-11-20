using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bandTogether.Models.SocialModels
{
    public class SocialPost
    {


        [Key]
        public int PostId { get; set; }

        // posterID

        [ForeignKey("Poster")]
        public int? posterId { get; set; }
        public SocialUser Poster { get; set; }


        public string postContent { get; set; }

        public int likeCount { get; set; }

        public int shareCount { get; set; }

        public DateTime postDate;


       


    }
}