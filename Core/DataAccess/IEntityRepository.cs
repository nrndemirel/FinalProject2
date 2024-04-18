using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Burada olusturdugumuz t yi sinirliyoruz. Herkes kafasina gore type eklemesin diye. Referans tip olarak ayarladik.
    //Generic constraint
    //IEntity olabilir ya da onu implemente eden  bir class ref tip olabilir.
    // new: new'lenebilir olmali. Interfaceler new lenemez oldugundan onu ekliyoruz. Nesne olmadigi icin iEntity isimize yaramaz
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAllByCategory(int categoryId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
