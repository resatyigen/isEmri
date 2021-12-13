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
    public partial class Users : System.Web.UI.Page
    {
        [Inject]
        public IUserService userService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            rptUserList.DataSource = userService.GetList(null);
            rptUserList.DataBind();
        }
    }
}