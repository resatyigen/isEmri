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
    public partial class EditUserWork : System.Web.UI.Page
    {
        [Inject]
        public IMapWorkService mapWorkService { get; set; }

        [Inject]
        public IWorkService workService { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var data = Page.RouteData.Values["id"];

            if (data == null)
            {
                Response.Redirect("UserWorks");
            }

            int id = int.Parse(data.ToString());
            var map_work = mapWorkService.Get(x => x.id == id);

            var works = workService.GetList(null);
            var users = userService.GetList(null);

            drpWorks.DataSource = works;
            drpWorks.DataTextField = "Name";
            drpWorks.DataValueField = "id";
            drpWorks.SelectedValue = map_work.WorkId.ToString();
            drpWorks.DataBind();

            drpUsers.DataSource = users;
            drpUsers.DataTextField = "FullName";
            drpUsers.DataValueField = "id";
            drpUsers.SelectedValue = map_work.UserId.ToString();
            drpUsers.DataBind();

            hdId.Value = map_work.id.ToString();
        }

        protected void saveEditUserWork(object sender, EventArgs e)
        {
            int id = int.Parse(hdId.Value);
            int work_id = int.Parse(drpWorks.SelectedValue);
            int user_id = int.Parse(drpUsers.SelectedValue);

            var map_work = mapWorkService.Get(x => x.id == id);

            if (map_work == null)
            {
                Response.Redirect("UserWorks");
            }

            map_work.WorkId = work_id;
            map_work.UserId = user_id;

            mapWorkService.Update(map_work);

            lblMessage.Text = "Kullanıcı Bazlı İş Emri Düzenlendi";
            dvMessage.Visible = true;
        }
    }
}