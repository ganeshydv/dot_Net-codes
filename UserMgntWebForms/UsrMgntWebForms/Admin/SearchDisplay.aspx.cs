using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UserMgmtDAL;
using UserMgmtDAL.EntityLayer;
namespace UserMgmtWebForms.Admin
{
    public partial class SearchDisplay : System.Web.UI.Page
    {
        UserRepository userRepo;

        protected void Page_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();
        }
        

        protected void GridView1_Load(object sender, EventArgs e)
        {
            
        }

        protected void SaerchBtn_Click(object sender, EventArgs e)
        {
            string s=NameSearch.Text;

            List<User> users = userRepo.GetByName(s).ToList();
            GridView1.DataSource = users;
            GridView1.DataBind();
        }

        protected void delUsr_Click(object sender, EventArgs e)
        {
            string s = NameSearch.Text;
            userRepo.DeleteOneUser(s);
        }
    }
}