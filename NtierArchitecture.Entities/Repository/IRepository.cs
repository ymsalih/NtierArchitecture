using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NtierArchitecture.Entities.Repository
{
    public interface IRepository<T> // genel tanımlama olacak burada yazdığımız methodları tüm kullanıcılar roller gibi işlemlerde kullanılabilir 
    {
        Task AddAsync(T entity, CancellationToken cancellationToken); // bir nesneyi asenkron eklemek için method 
        void Update(T entity); // nesneyi güncellemek için metho 
        void Remove(T entity); // nesneyi silmek için metod 
        Task<T> GetByIDasync(Expression<Func< T,bool>> expression, CancellationToken cancellationToken); // bir nesneyi asenkron olarak şarta göre getirmek için method 
        // user => user.Id == 5; bu şekilde 
        IQueryable<T> GetAll(); // tüm nesneler sorgulanabilir olarak döner
        IQueryable<T> GwtWhere(Expression<Func<T, bool>> expression); // üzerinde sorgu yapılabilen koleksiyon
        
        // belirli şartlara uyan nesneleri sorgular 
        // asenkron programlama demek bir iş yaparken o iş yapılana kadar başka bir iş yapabilmen için gereklidir ve o iş tamamlanınca bildirim şeklinde tamamlanır demir 
        // asenkron işlemler de task sayesinde olur 
     
    }
}
