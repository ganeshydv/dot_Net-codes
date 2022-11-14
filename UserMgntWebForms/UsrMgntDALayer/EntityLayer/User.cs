using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMgmtDAL.EntityLayer
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte RoleId { get; set; }
        public byte Status { get; set; }

        public string RoleName { get; set; }
    }
}
