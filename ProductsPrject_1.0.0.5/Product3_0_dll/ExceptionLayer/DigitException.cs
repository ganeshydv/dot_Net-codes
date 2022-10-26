using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_dll.ExceptionLayer
{
    public class DigitException:ApplicationException
    {
        public  DigitException(String s):base(s)
        {
            
        }
    }
}
