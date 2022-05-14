using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.MSSQL
{
    public class AppUser : IdentityUser<int>
    {
        //bu sinifi tamamlayip veritabanina yansit
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
        [MaxLength(250)]
        public int Gender { get; set; } // Numaraya gore cinsiyet verilecek. ornegin 0 => gizli ///// 1=>erkek///// 2=>kadin
        public float SocialPoint { get; set; } // Sayfamiza ozel olan ve kesfet algoritmasindaki siralamaya etki edecek olan sosyallik puani
        [MaxLength(250)]
        public int FollowerCount { get; set; } // kisinin takip ettigi kisi sayisi
        public int FollowingCount { get; set; } // kisiyi takip eden kisi sayisi
        public DateTime RegisterDate { get; set; }
    }
}
