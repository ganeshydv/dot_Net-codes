using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserMgmtDAL;
using UserMgmtDAL.EntityLayer;

namespace UserMgmtWebForms.Admin
{
    public partial class EditUser : System.Web.UI.Page
    {
        UserRepository useresp = null;
        RoleRepository resp;
        //User usr_ = new User();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        { 
            useresp=new UserRepository();
            resp=new RoleRepository();
            updtUsrTbl.Attributes.Add("style", "display:none");
        }


        protected void nameDropDown_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 

            List<User> lst = useresp.GetAllName().ToList();
            NameDropDown.DataSource = lst;
            NameDropDown.DataTextField = "Name";
            NameDropDown.DataValueField = "id";
            NameDropDown.DataBind();

            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            updtUsrTbl.Attributes.Add("style", "display:block");
            int RoleId = Convert.ToByte(NameDropDown.SelectedItem.Value);

            User user = useresp.GetById(RoleId);
            //usr_ = user;
            TextBox1.Text = user.Name;
            TextBox2.Text = Convert.ToString(user.Id);

            TextBox3.Text = Convert.ToString(user.DOB);

            TextBox4.Text = user.Mobile;
            TextBox5.Text = user.Email;
            //----------------- for role ---------------
            
            selectRole.Text = user.RoleName;
            //usr_.Name = TextBox1.Text;
            //usr_.DOB = Convert.ToDateTime(TextBox3.Text);

            //usr_.Mobile = TextBox4.Text;
            //usr_.Email = TextBox5.Text;


            //userRepository.Add(user);
            //Server.Transfer("~/Admin/SearchDisplay.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            User usr_ = new User();
            usr_.Id = Convert.ToByte( TextBox2.Text);
            usr_.Name = TextBox1.Text;
            usr_.DOB = Convert.ToDateTime(TextBox3.Text);

            usr_.Mobile = TextBox4.Text;
            usr_.Email = TextBox5.Text;
            //usr_.RoleId = Convert.ToByte(selectRole.SelectedItem.Value);
            useresp.Update(usr_);
            
            //Server.Transfer("~/Admin/SearchDisplay.aspx");
        }

        protected void selectRole_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    List<Role> lst = resp.GetAll().ToList();
            //    selectRole.DataSource = lst;
            //    selectRole.DataTextField = "Name";
            //    selectRole.DataValueField = "id";
            //    selectRole.DataBind();
            //}

        }


    }
}