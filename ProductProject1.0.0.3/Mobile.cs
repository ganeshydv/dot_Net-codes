using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_dll
{
    public class Mobile:Product
    {

        public override string Display()
        {
            string msg = base.Display();

            StringBuilder sb = new StringBuilder();
            sb.Append(msg);
            if (Is5G)
            {
                return sb.Append("it is 5G mobile.\n") + "";
            }else return base.Display();
            
        }
        private bool m_is5G;
        public bool Is5G
        {
            get { return m_is5G; }
            set
            {
                m_is5G = value;
            }
        }
        private string m_OS;
        private string OS
        {
            get { 
                return m_OS; 
            }
            set
            {
                m_OS=value;
            }
        }

    }
}
