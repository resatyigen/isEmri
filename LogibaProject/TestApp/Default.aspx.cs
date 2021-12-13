using LogibaProject.Businness.Abstract;
using Ninject;
using Ninject.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApp
{
    public partial class Default : PageBase
    {
        [Inject]
        public IWorkService _workService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var result = _workService.GetList(null);
        }
    }
}