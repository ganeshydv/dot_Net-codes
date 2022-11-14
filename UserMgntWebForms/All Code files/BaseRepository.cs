using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace UserMgmtDAL
{
    public class BaseRepository
    {
        protected string ConString;
        public BaseRepository()
        {
            ConString = System.Configuration
                    .ConfigurationManager
                        .ConnectionStrings["UMCString"].ConnectionString;
        }
    }
}
