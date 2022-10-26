using Product3_0_dll;
using Product3_0_dll.ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Prod_lst refProd = new Prod_lst())
            {
                Product3_0_dll.ApplicationLaye.AppLayer appLayer = Product3_0_dll.ApplicationLaye.AppLayer.GetInstance();
                appLayer.ApplicationL(refProd);
                Console.ReadLine();
            }
        }

    }
}
