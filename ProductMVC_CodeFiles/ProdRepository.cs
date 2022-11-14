using ProductDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ProductDAL
{
    public class ProdRepository : IRepository<Product>
    {
        ProductDBContext DbCtxt;
        public ProdRepository(ProductDBContext _db)
        {
            this.DbCtxt = _db;

        }
        public bool Add(Product entity)
        {
            DbCtxt.products.Add(entity);
            return DbCtxt.SaveChanges()>0;
        }

        public bool DeleteById(int id)
        {
            var obj=GetById(id);
            DbCtxt.products.Remove(obj);
            return DbCtxt.SaveChanges()>0;
        }



        public IEnumerable<Product> FindByName(string name)
        {
           var obj= from Product pd in DbCtxt.products.Include("Category")
                    where pd.Name.ToLower().StartsWith(name.ToLower())
                    select pd;
            return obj;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = from Product em in
                              DbCtxt.products
                              .Include("Category")
                              select em;
            return products;
                              
        }

        public Product GetById(int id)
        {
            var prod=from Product pd in DbCtxt.products.Include("Category")
                     where pd.Id == id
                     select pd;
            return prod.SingleOrDefault();
        }

        public IEnumerable<Product> GetByDate(DateTime dt)
        {
            var prod = from Product pd in DbCtxt.products.Include("Category")
                       where pd.MfgDate == dt
                       select pd;
            return prod;
        }

        public bool Update(Product entity)
        {
            var obj = GetById(entity.Id);
            obj.Name=entity.Name;
            obj.Price = entity.Price;
            obj.Stock = entity.Stock;
            int noofrowsaff = DbCtxt.SaveChanges();
            return noofrowsaff > 0;
        }
    }
}
