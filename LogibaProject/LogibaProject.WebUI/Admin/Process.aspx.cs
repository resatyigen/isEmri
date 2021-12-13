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
    public partial class Process : System.Web.UI.Page
    {

        [Inject]
        public IWorkService workService { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        [Inject]
        public IMapWorkService mapWorkService { get; set; }

        [Inject]
        public IGroupService groupService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var get_type = Page.RouteData.Values["type"];
            var get_id = Page.RouteData.Values["id"];

            if (get_type == null || get_id==null)
            {
                Response.Redirect("/Admin/Works");
            }

            string type = get_type as string;
            int id = int.Parse(get_id as string);

            switch (type)
            {
                case "delete_work":                    
                    workService.Delete(x => x.id == id);
                    Response.Redirect("/Admin/Works");
                    break;
                case "delete_user":
                    userService.Delete(x => x.id == id);
                    var user_maps = mapWorkService.GetList(x => x.UserId == id);
                    foreach (var m in user_maps)
                    {
                        mapWorkService.Delete(x=>x.id==m.id);
                    }
                    Response.Redirect("/Admin/Users");
                    break;
                case "delete_user_work":
                    mapWorkService.Delete(x => x.id == id);
                    Response.Redirect("/Admin/UserWorks");
                    break;
                case "delete_group":
                    groupService.Delete(x => x.id == id);
                    var group_maps = mapWorkService.GetList(x => x.GroupId == id);
                    foreach (var m in group_maps)
                    {
                        mapWorkService.Delete(x=>x.id==m.id);
                    }
                    Response.Redirect("/Admin/Groups");
                    break;
                case "delete_group_work":
                    mapWorkService.Delete(x => x.id == id);
                    Response.Redirect("/Admin/GroupWorks");
                    break;
            }
        }
    }
}