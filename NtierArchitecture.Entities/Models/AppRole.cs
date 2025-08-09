using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public sealed class AppRole :IdentityRole<Guid>
    {
        //  ekstra bi alan eklememize gerek yok çünkü IdentityRole içinde gerekli olan tüm alanlar var 
    }
}
