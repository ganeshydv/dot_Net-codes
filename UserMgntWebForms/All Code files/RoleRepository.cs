using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserMgmtDAL.EntityLayer;

namespace UserMgmtDAL
{
    public class RoleRepository : BaseRepository, IRepository<Role>
    {
        public bool Add(Role item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConString;
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "GetRoles";

                List<EntityLayer.Role> roles = new List<Role>();

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    Role rol1 = new Role();
                    rol1.Id = (byte)dr[0];
                    rol1.Name = dr.GetString(1);
                    

                    roles.Add(rol1);
                }

                con.Close();
                con.Dispose();
                return roles;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Role GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Role item)
        {
            throw new NotImplementedException();
        }
    }
}
