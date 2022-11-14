using ProductDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDAL
{
    public class CatRepo : IRepository<EntityLayer.Category>
    {
        ProductDBContext dbContext;
        public CatRepo(ProductDBContext dbctx)
        {
            dbContext = dbctx;

        }
        public bool Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            var dept = from Category ct in
                         dbContext.categories
                       select ct;
            return dept;
        }

        public IEnumerable<Category> GetByDate(DateTime dt)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
