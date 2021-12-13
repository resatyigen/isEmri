using LogibaProject.Businness.Abstract;
using LogibaProject.Entities.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class AddGroup : System.Web.UI.Page
    {
        [Inject]
        public IUserService userService { get; set; }

        [Inject]
        public IGroupService groupService { get; set; }

        [Inject]
        public IMapGroupUserService mapGroupUserService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var users = userService.GetList(null);
            chkUsers.DataSource = users;
            chkUsers.DataTextField = "FullName";
            chkUsers.DataValueField = "id";
            chkUsers.DataBind();
        }

        protected void addGroup(object sender, EventArgs e)
        {
            string group_name = txtGroupName.Text.Trim();

            var group = new Group()
            {
                Name = group_name
            };

            groupService.Add(group);

            foreach (ListItem user in chkUsers.Items)
            {
                if (user.Selected)
                {
                    var map_group = new MapGroupUser()
                    {
                        GroupId = group.id,
                        UserId = int.Parse(user.Value)
                    };

                    mapGroupUserService.Add(map_group);
                }
            }

            Response.Redirect("/Admin/Groups");
        }
    }
}