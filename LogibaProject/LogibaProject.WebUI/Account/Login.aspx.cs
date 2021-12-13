using LogibaProject.Businness.Abstract;
using LogibaProject.WebUI.Providers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Account
{
    public partial class Login : System.Web.UI.Page
    {
        [Inject]
        public IAdminService adminService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginClick(object sender, EventArgs e)
        {
            /* 
             * Admin Kullanıcı Girişi
             * 
             * Kullanıcı Adı : admin
             * Şifre : admin@123
             * 
             * */

            string urname = username.Text.Trim();
            string pass = password.Text.Trim();

            string encode_pass = Provider.PasswordEncode(pass);

            var admin = adminService.Get(x => x.UserName == urname && x.Password == encode_pass);

            if (admin != null)
            {
                FormsAuthentication.SetAuthCookie(admin.UserName, remember.Checked);
                Response.Redirect("/Admin/Home");
            }
            else
            {
                dvMessage.Visible = true;
                lblMessage.Text = "Kullanıcı adı ve ya şifre yanlış !";
            }
        }  
    }
}