using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class Comment
    {
        [Key]
        public int iComment_ID { get; set; }
        public string sComment { get; set; }
        public string sColor { get; set; }
        public string sCategory { get; set; }
        public TimeSpan tCommentTime { get; set; }
        public int iVideo_ID { get; set; }
        public int iTask_ID { get; set; }
        public int iScore_ID { get; set; }
        public string sResponsible { get; set; }

        public virtual Video VideoModel { get; set; }
        public virtual Task TaskModel { get; set; }
        public virtual Score ScoreModel { get; set; }

    }
}