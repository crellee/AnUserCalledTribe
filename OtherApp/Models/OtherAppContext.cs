using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class OtherAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public OtherAppContext() : base("name=OtherAppContext")
        {
        }

        public System.Data.Entity.DbSet<OtherApp.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<OtherApp.Models.Video> Videos { get; set; }

        public System.Data.Entity.DbSet<OtherApp.Models.ProjectVideos> ProjectVideos { get; set; }
        public DbSet<OtherApp.Models.Task> Tasks { get; set; }
        public DbSet<OtherApp.Models.Score> Scores { get; set; }
        public DbSet<OtherApp.Models.VideoTask> VideoTasks { get; set; }
        public DbSet<OtherApp.Models.Comment> Comment { get; set; }



    }
}
