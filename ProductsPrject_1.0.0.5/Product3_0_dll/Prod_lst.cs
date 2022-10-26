using System;
using System.Collections.Generic;

namespace Product3_0_dll
{
    public class Prod_lst:IDisposable
    {
        private List<Product> products_lst;

        public Prod_lst()
        {
            products_lst = new List<Product>();
        }
        public void Add(Product ref_prod)
        {
            products_lst.Add(ref_prod);
        }

        public IEnumerable<Product> getAll()
        {
            return products_lst;
        }
        public void Remove_(int id)
        {
            bool b=false;
            Product p = null;
            foreach(Product ref_prod_ in products_lst)
            {
                if (ref_prod_!=null &&ref_prod_.Id==id)
                {
                    p= ref_prod_;   
                  b =true;
                    break;
                }
            }
            products_lst.Remove(p);

            if (!b)
            {
                Console.WriteLine($"product with id :{id} not found");
            }
            
        }
        public Product Find(int id)
        {
            foreach(Product ref_p in products_lst)
            {
                if (ref_p.Id == id)
                {
                    return ref_p;
                }
            }
            return null;
        }
        public void Dispose()
        {
            products_lst=null;
        }

    }

}
