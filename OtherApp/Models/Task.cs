using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class Task
    {
        [Key]
        public int iTask_ID { get; set; }
        public string sName { get; set; }
        public int iTaskOrder { get; set; }

    }
}