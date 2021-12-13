using LogibaProject.Businness.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class EditUser : System.Web.UI.Page
    {
        [Inject]
        public IUserService userService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var data = Page.RouteData.Values["id"];

            if (data == null)
            {
                Response.Redirect("Users");
            }

            int id = int.Parse(data as string);
            var user = userService.Get(x => x.id == id);

            txtFullName.Text = user.FullName;
            txtUserName.Text = user.UserName;
            hdId.Value = user.id.ToString();
        }

        protected void saveEditUser(object sender, EventArgs e)
        {
            int id = int.Parse(hdId.Value);
            var user = userService.Get(x => x.id == id);

            if (user == null)
            {
                Response.Redirect("Users");
            }

            string full_name = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            
            user.FullName = full_name;

            if (!String.IsNullOrEmpty(password))
            {
                user.Password = Providers.Provider.PasswordEncode(password);
            }

            userService.Update(user);

            lblMessage.Text = "Kullanıcı Düzenleme Başarılı";
            dvMessage.Visible = true;
        }
    }
}