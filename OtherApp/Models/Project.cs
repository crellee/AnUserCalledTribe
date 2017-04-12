using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class Project
    {
        [Key]
        public int iProject_ID { get; set; }
        public string sName { get; set; }
        public bool bStatus { get; set; }   //skal indikere om projektet er færdigt eller ej
        public Nullable<DateTime> dCreatedDate { get; set; }
        public Nullable<DateTime> dEndedDate { get; set; }

    }
}