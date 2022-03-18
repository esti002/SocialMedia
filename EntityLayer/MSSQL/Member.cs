using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.MSSQL
{
    public class Member
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public bool VerifyMail { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
        public int SocialityPoint { get; set; }
        public int FollowerCount { get; set; }
        public int FollowigCount { get; set; }
    }
}
