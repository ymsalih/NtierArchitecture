using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Models
{
    public sealed class Product
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }  
        public int Quantity { get; set; }
        public Guid CategoryId{ get; set; } // Benim ürünüm bir kategori barındırabilir 
       // sicle hatası yememek için kaldırdık çünkü hep birbirlerini çağıracakları için kural gereği için verilmez
       // public Category Category {  get; set; }

    }
}
