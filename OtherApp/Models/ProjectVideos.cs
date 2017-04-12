using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class ProjectVideos
    {
        [Key]
        public int Key_ID { get; set; }
        public int iProject_ID { get; set; }
        public int iVideo_ID { get; set; }

        public virtual Project ProjectModel { get; set; }
        public virtual Video VideoModel { get; set; }
    }
}