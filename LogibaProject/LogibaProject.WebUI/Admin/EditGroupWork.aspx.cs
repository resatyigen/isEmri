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
    public partial class EditGroupWork : System.Web.UI.Page
    {
        [Inject]
        public IMapWorkService mapWorkService { get; set; }

        [Inject]
        public IWorkService workService { get; set; }

        [Inject]
        public IGroupService groupService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var data = Page.RouteData.Values["id"];

            if (data == null)
            {
                Response.Redirect("GroupWorks");
            }

            int id = int.Parse(data.ToString());
            var map_work = mapWorkService.Get(x => x.id == id);

            var works = workService.GetList(null);
            var groups = groupService.GetList(null);

            drpWorks.DataSource = works;
            drpWorks.DataTextField = "Name";
            drpWorks.DataValueField = "id";
            drpWorks.SelectedValue = map_work.WorkId.ToString();
            drpWorks.DataBind();

            drpGroups.DataSource = groups;
            drpGroups.DataTextField = "Name";
            drpGroups.DataValueField = "id";
            drpGroups.SelectedValue = map_work.GroupId.ToString();
            drpGroups.DataBind();

            hdId.Value = id.ToString();
        }

        protected void saveEditGroupWork(object sender, EventArgs e)
        {
            int id = int.Parse(hdId.Value);
            int work_id = int.Parse(drpWorks.SelectedValue);
            int group_id = int.Parse(drpGroups.SelectedValue);

            var map_work = mapWorkService.Get(x => x.id == id);

            if (map_work == null)
            {
                Response.Redirect("GroupWorks");
            }

            map_work.WorkId = work_id;
            map_work.GroupId = group_id;

            mapWorkService.Update(map_work);

            lblMessage.Text = "Grup Bazlı İş Emri Düzenlendi";
            dvMessage.Visible = true;
        }
    }
}