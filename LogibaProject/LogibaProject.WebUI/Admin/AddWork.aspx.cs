using LogibaProject.Businness.Abstract;
using LogibaProject.Entities.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogibaProject.WebUI.Admin
{
    public partial class AddWork : System.Web.UI.Page
    {
        [Inject]
        public IWorkService workService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addWork(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int work_no = int.Parse(txtNo.Text);
            string material = txtMaterial.Text.Trim();
            string description = txtDescription.Text.Trim();
            int quantity = int.Parse(txtQuantity.Text);
            DateTime start_date = DateTime.Parse(txtStartDate.Text);
            DateTime end_date = DateTime.Parse(txtEndDate.Text);
            string file_name = "";

            if (file.HasFile)
            {
                file_name = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath("~/Documents/") + file_name);
            }

            var work = new Work() {
                Name = name,
                No = work_no,
                Material = material,
                Description = description,
                Quantity = quantity,
                StartDate = start_date,
                EndDate = end_date,
                FileName = file_name,
                Status=1
            };

            workService.Add(work);

            Response.Redirect("/Admin/Works");
        }
    }
}