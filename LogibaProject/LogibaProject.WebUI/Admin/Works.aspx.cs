using LogibaProject.Businness.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class Works : System.Web.UI.Page
    {

        [Inject]
        public IWorkService workService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //var work_List = workService.GetList(null).Select(x=>new {
            //    StartDate = x.StartDate.ToShortDateString(),
            //    EndDate = x.EndDate.ToShortDateString()
            //});



            //workList.DataSource = work_List;
            //workList.DataBind();

            rptWorkList.DataSource = workService.GetList(null);
            rptWorkList.DataBind();
        }
    }
}