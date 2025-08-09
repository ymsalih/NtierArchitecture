namespace NtierArchitecture.Entities.Models
{
    public sealed class Category
    {
        public Guid Id { get; set; }
        public string Name {  set; get; }
        public ICollection<Product> Products { get; set; } // bir ürünüm ise birden çok kategori barındırabilir 

        // bu şekilde birden çoğa bir ilişki kurabiliriz 

    }
}
