C#'ta Guid (Global Unique Identifier), dünyada eşi benzeri olmayan 128-bit’lik (16 byte) bir kimlik numarası oluşturmak için kullanılır. Genellikle:

Veritabanı kayıtlarında benzersiz ID oluşturmak,

Dağıtık sistemlerde çakışma riskini sıfıra indirmek,

Bir nesneyi sistem genelinde eşsiz biçimde tanımlamak

için kullanılır.

📌 Özellikleri:
32 karakterden oluşur (hex formatında).

Rastgele oluşturulur, çakışma ihtimali çok düşüktür.

Guid türü System namespace'inde yer alır.

🔧 Örnek Kullanım:
csharp
Kodu kopyala
using System;

class Program
{
    static void Main()
    {
        Guid yeniGuid = Guid.NewGuid();  // Yeni benzersiz bir GUID oluşturur
        Console.WriteLine(yeniGuid);
    }
}
Örnek çıktı:

Kodu kopyala
f6d2a876-5c33-46d9-9735-5f947a6fd830
📍 Nerelerde Kullanılır?
Veritabanı tablolarında Id kolonları (örneğin UserId, OrderId),

Lisans anahtarları oluşturmakta,

Oturum, token üretimi gibi güvenliğin önemli olduğu yerlerde,

Uygulama içinde nesne/oturum/bağlantı takibi gibi işlerde.


Task Kullanımı	Anlamı
Task	Sonuç döndürmeyen asenkron işlem
Task<TResult> (ör. Task<int>)	Sonuç döndüren asenkron işlem
await ile Task beklenir	İşlem bitene kadar bekler ama program donmaz