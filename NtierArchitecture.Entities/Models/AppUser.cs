using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    // sealed bu sınıfın başka bir sınıfa inhert edilmesini engelliyor 
    public sealed class AppUser : IdentityUser<Guid> // default alanları tanımlamama gerek yok artık çünkü hepsi ıdentity içinde tanımlı
    {
        // kullanılmayan bir alan ise isim soyisim alanı onları de kendimiz ekledik kütüphenede yoktu 
        public string Name { get; set; }
        public string Lastname {  get; set; }

        // sınıf ismini AppUser yaptık direk user diye .netin kullandığı sınıf var o yüzden çakışabiliyor 

    }
}
