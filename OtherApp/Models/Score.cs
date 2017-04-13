using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class Score
    {
        [Key]
        public int iScore_ID { get; set; }
        public int iScore_Value { get; set; }
    }
}