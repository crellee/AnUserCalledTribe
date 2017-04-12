using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtherApp.Models
{
    public class Video
    {
        [Key]
        public int iVideo_ID { get; set; }
        public string sName { get; set; }
        public bool bStatus { get; set; }       // bStatus skal indikere om kommentarene til videoen er færdigskrevet
        public string Playlist_ID { get; set; } // ID på spillelisten videoen tilhører, info vi skal have fra vimeos API
        public string Tester_ID { get; set; }   // ID på personen der tester den vilkårlige, info vi skal have fra usertribes API 
        public string Employee_ID { get; set; } // ID på personen der er ansat i usertribe som laver analyse af vilkårlige video.

    }
}