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
    public partial class GroupWorks : System.Web.UI.Page
    {
        [Inject]
        public IGetWorksService getWorksService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var works = getWorksService.GetWorks("group");
            rptGroupWorkList.DataSource = works;
            rptGroupWorkList.DataBind();
        }
    }
}