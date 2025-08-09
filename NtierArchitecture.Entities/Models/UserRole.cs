using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public sealed class UserRole
    {
        // kullanıcı ve role arasında ilişki tablosu olacak 
        // ıdentity kütüphanesinin yine kendine ait  normalde userrole adlı kütüphane var ama çok kullanışlı değil diye kendim alanları ekleyecem
        // kendi tablomu oluşturacam 

        public Guid AppUserId { get; set; } 
        public AppUser AppUser {  get; set; }
        public Guid AppRoleId { get; set; }
        public AppRole AppRole { get; set; }


    }
}
