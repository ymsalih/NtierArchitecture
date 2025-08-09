namespace NtierArchitecture.Entities.Repository
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    // bu metot, veritabanı değişikliklerini güvenli, hızlı ve kullanıcı deneyimine uygun şekilde kaydetmek için oluşturulur.
}
