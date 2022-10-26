using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3_0_dll
{
    public class Tv:Product
    {

        public override string Display()
        {
            string msg = base.Display();

            StringBuilder sb = new StringBuilder();
            sb.Append(msg);
            sb.Append("\nHDMI ports: " + this.HdmiPort + "\n");
            if (m_isSmart)
            {

                sb.Append("it is smart TV");
                
                return sb+"";
            }else return base.Display();
        }
        private bool m_isSmart;

        public bool IsSmart
        {
            set
            {
                m_isSmart = value;
            }
        }
        private int HdmiPort;
        public int HDMI
        {
            get
            {
                return HdmiPort;
            }
            set
            {
                HdmiPort = value;
            }
        }

    }
}
