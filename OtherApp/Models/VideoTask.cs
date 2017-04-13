using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class VideoTask
    {
        [Key]
        public int Key_ID { get; set; }
        public int iVideo_ID { get; set; }
        public int iTask_ID { get; set; }

        public virtual Video VideoModel { get; set; }
        public virtual Task TaskModel { get; set; }
    }
}