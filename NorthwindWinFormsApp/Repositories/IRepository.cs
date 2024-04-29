using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWinFormsApp.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Edit(T entity);
        void Delete(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByValue(string id);
    }
}
