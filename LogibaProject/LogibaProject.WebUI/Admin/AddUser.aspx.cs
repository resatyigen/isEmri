using LogibaProject.Businness.Abstract;
using LogibaProject.Entities.Concrete;
using LogibaProject.WebUI.Providers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class AddUser : System.Web.UI.Page
    {
        [Inject]
        public IUserService userService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addUser(object sender, EventArgs e)
        {
            string full_name = txtFullName.Text.Trim();
            string user_name = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            var check_user = userService.Get(x => x.UserName == user_name);

            if (check_user != null)
            {
                lblMessage.Text = "Bu kullanıcı adı kullanılıyor !";
                dvMessage.Visible = true;
                return;
            }

            var user = new User()
            {
                FullName = full_name,
                UserName = user_name,
                Password = Provider.PasswordEncode(password)
            };

            userService.Add(user);

            Response.Redirect("/Admin/Users");
        }
    }
}