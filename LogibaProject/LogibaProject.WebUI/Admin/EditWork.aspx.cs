using LogibaProject.Businness.Abstract;
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
    public partial class EditWork : System.Web.UI.Page
    {
        [Inject]
        public IWorkService workService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            var data = Page.RouteData.Values["id"];

            if (data == null)
            {
                Response.Redirect("Works");
            }

            int id = int.Parse(data as string);
            var work = workService.Get(x => x.id == id);

            txtName.Text = work.Name;
            txtNo.Text = work.No.ToString();
            txtMaterial.Text = work.Material;
            txtDescription.Text = work.Description;
            txtQuantity.Text = work.Quantity.ToString();
            txtStartDate.Text = work.StartDate.ToString("yyyy-MM-dd");
            txtStartDate.TextMode = TextBoxMode.Date;
            txtEndDate.Text = work.EndDate.ToString("yyyy-MM-dd");
            txtEndDate.TextMode = TextBoxMode.Date;
            drpStatus.SelectedValue = work.Status.ToString();
            hdId.Value = work.id.ToString();
        }

        protected void saveEditWork(object sender, EventArgs e)
        {
            int id = int.Parse(hdId.Value);

            var work = workService.Get(x => x.id == id);

            if (work == null)
            {
                Response.Redirect("Works");
            }

            string name = txtName.Text.Trim();
            int work_no = int.Parse(txtNo.Text);
            string material = txtMaterial.Text.Trim();
            string description = txtDescription.Text.Trim();
            int quantity = int.Parse(txtQuantity.Text);
            DateTime start_date = DateTime.Parse(txtStartDate.Text);
            DateTime end_date = DateTime.Parse(txtEndDate.Text);
            int status = int.Parse(drpStatus.SelectedValue);
            string file_name = work.FileName;

            if (file.HasFile)
            {
                file_name = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath("~/Documents/") + file_name);
            }

            work.Name = name;
            work.No = work_no;
            work.Material = material;
            work.Description = description;
            work.Quantity = quantity;
            work.StartDate = start_date;
            work.EndDate = end_date;
            work.FileName = file_name;
            work.Status = status;

            workService.Update(work);

            lblMessage.Text = "İş Emri Düzenleme Başarılı";
            dvMessage.Visible = true;

        }
    }
}