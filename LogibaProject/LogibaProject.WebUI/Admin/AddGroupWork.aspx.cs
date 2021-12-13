using LogibaProject.Businness.Abstract;
using LogibaProject.Businness.Abstract.StoredProcedure;
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
    public partial class AddGroupWork : System.Web.UI.Page
    {
        [Inject]
        public IWorkService workService { get; set; }

        [Inject]
        public IGetGroupsService getGroupsService { get; set; }

        [Inject]
        public IMapWorkService mapWorkService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            drpWorks.DataSource = workService.GetList(null);
            drpWorks.DataTextField = "Name";
            drpWorks.DataValueField = "id";
            drpWorks.DataBind();

            drpGroups.DataSource = getGroupsService.GetGroups();
            drpGroups.DataTextField = "Name";
            drpGroups.DataValueField = "id";
            drpGroups.DataBind();
        }

        protected void addGroupWork(object sender, EventArgs e)
        {
            int work_id = int.Parse(drpWorks.SelectedValue);
            int group_id = int.Parse(drpGroups.SelectedValue);

            var map_work = new LogibaProject.Entities.Concrete.MapWork()
            {
                WorkId = work_id,
                GroupId = group_id
            };

            mapWorkService.Add(map_work);

            Response.Redirect("/Admin/GroupWorks");
        }
    }
}