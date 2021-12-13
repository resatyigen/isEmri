using LogibaProject.Businness.Abstract.StoredProcedure;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class Groups : System.Web.UI.Page
    {
        [Inject]
        public IGetGroupsService getGroupsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var groups = getGroupsService.GetGroups();
            rptGroupList.DataSource = groups;
            rptGroupList.DataBind();
        }
    }
}