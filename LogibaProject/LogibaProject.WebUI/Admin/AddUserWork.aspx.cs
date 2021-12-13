using LogibaProject.Businness.Abstract;
using LogibaProject.Businness.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class AddUserWork : System.Web.UI.Page
    {
        [Inject]
        public IWorkService workService { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        [Inject]
        public IMapWorkService mapWorkService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            drpWorks.DataSource = workService.GetList(null);
            drpWorks.DataTextField = "Name";
            drpWorks.DataValueField = "id";
            drpWorks.DataBind();

            drpUsers.DataSource = userService.GetList(null);
            drpUsers.DataTextField = "FullName";
            drpUsers.DataValueField = "id";
            drpUsers.DataBind();
        }

        protected void addUserWork(object sender, EventArgs e)
        {
            int work_id = int.Parse(drpWorks.SelectedValue);
            int user_id = int.Parse(drpUsers.SelectedValue);

            var map_work = new LogibaProject.Entities.Concrete.MapWork()
            {
                WorkId = work_id,
                UserId = user_id
            };

            mapWorkService.Add(map_work);

            Response.Redirect("/Admin/UserWorks");
        }
    }
}