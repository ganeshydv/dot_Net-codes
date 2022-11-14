using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDAL
{
    public interface IRepository<T>
    {
        public T GetById(int id);
        public IEnumerable<T> GetByDate(DateTime dt);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> FindByName(string name);

        public bool DeleteById(int id);

        public bool Update(T entity);

        public bool Add(T entity);
    }
}
