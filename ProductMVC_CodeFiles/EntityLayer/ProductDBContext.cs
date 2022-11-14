using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDAL.EntityLayer
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> opt):base(opt)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
