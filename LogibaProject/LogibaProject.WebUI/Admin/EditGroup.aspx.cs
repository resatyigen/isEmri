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
    public partial class EditGroup : System.Web.UI.Page
    {
        [Inject]
        public IGroupService groupService { get; set; }

        [Inject]
        public IMapGroupUserService mapGroupUserService { get; set; }

        [Inject]
        public IUserService userService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var data = Page.RouteData.Values["id"];

            if (data == null)
            {
                Response.Redirect("Groups");
            }

            int id = int.Parse(data.ToString());

            var group = groupService.Get(x => x.id == id);
            var map = mapGroupUserService.GetList(x => x.GroupId == id);
            var users = userService.GetList(null);

            hdId.Value = group.id.ToString();
            txtGroupName.Text = group.Name;
            chkUsers.DataSource = users;
            chkUsers.DataTextField = "FullName";
            chkUsers.DataValueField = "id";
            chkUsers.DataBind();
            foreach (var m in map)
            {
                chkUsers.Items.FindByValue(m.UserId.ToString()).Selected = true;
            }
        }

        protected void saveEditGroup(object sender, EventArgs e)
        {
            int id = int.Parse(hdId.Value);
            string group_name = txtGroupName.Text.Trim();

            var group = groupService.Get(x => x.id == id);

            if (group == null)
            {
                Response.Redirect("Groups");
            }

            group.Name = group_name;
            groupService.Update(group);

            var map = mapGroupUserService.GetList(x => x.GroupId == id);

            foreach (var m in map)
            {
                mapGroupUserService.Delete(m);
            }

            foreach (ListItem user in chkUsers.Items)
            {
                int user_id = int.Parse(user.Value);
                if (user.Selected)
                {
                    var map_group = new MapGroupUser()
                    {
                        GroupId = group.id,
                        UserId = user_id
                    };

                    mapGroupUserService.Add(map_group);
                }
            }

            lblMessage.Text = "Grup Düzenlendi";
            dvMessage.Visible = true;
        }
    }
}