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
    public partial class NewUser : System.Web.UI.Page
    {
        RoleRepository resp;
        UserRepository userRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            resp = new RoleRepository();
           userRepository = new UserRepository();
        }

        

        protected void DropDownList1_Load1(object sender, EventArgs e)
        {
            List<Role> lst = resp.GetAll().ToList();
            role.DataSource = lst;
            role.DataTextField = "Name";
            role.DataValueField = "id";
            role.DataBind();
        }

       
        protected void AddUSerBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name=Name_TextBox.Text;
            try { user.DOB = Convert.ToDateTime(Dob_textBox.Text); }
            catch(Exception e1)
            {
                Server.Transfer("~/Admin/.aspx");
            }
            
            if (gender1.Checked)
            {
                user.Gender = "m";
            }
            else
            {
                user.Gender = "f";
            }
            user.Mobile=Mob.Text;
            user.Email=mail.Text;
            user.Password=Password.Text;
            user.RoleId = Convert.ToByte(role.SelectedItem.Value);
            userRepository.Add(user);
            Server.Transfer("~/Admin/SearchDisplay.aspx");
        }
    }
}