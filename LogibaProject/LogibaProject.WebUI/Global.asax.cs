using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace LogibaProject.WebUI
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            RouteTable.Routes.MapPageRoute(
                "Logout",
                "Logout/",
                "~/Account/Logout.aspx");

            RouteTable.Routes.MapPageRoute(
                "Login",
                "Login/",
                "~/Account/Login.aspx");

            RouteTable.Routes.MapPageRoute(
                "Admin",
                "Admin/Home",
                "~/Admin/Home.aspx");

            RouteTable.Routes.MapPageRoute(
                "Works",
                "Admin/Works",
                "~/Admin/Works.aspx");

            RouteTable.Routes.MapPageRoute(
                "AddWork",
                "Admin/AddWork",
                "~/Admin/AddWork.aspx");

            RouteTable.Routes.MapPageRoute(
                "EditWork",
                "Admin/EditWork/{id}",
                "~/Admin/EditWork.aspx");

            RouteTable.Routes.MapPageRoute(
               "Process",
               "Admin/Process/{type}/{id}",
               "~/Admin/Process.aspx");

            RouteTable.Routes.MapPageRoute(
               "AddUser",
               "Admin/AddUser",
               "~/Admin/AddUser.aspx");

            RouteTable.Routes.MapPageRoute(
               "Users",
               "Admin/Users",
               "~/Admin/Users.aspx");

            RouteTable.Routes.MapPageRoute(
               "EditUser",
               "Admin/EditUser/{id}",
               "~/Admin/EditUser.aspx");

            RouteTable.Routes.MapPageRoute(
               "UserWorks",
               "Admin/UserWorks",
               "~/Admin/UserWorks.aspx");

            RouteTable.Routes.MapPageRoute(
               "AddUserWork",
               "Admin/AddUserWork",
               "~/Admin/AddUserWork.aspx");

            RouteTable.Routes.MapPageRoute(
               "EditUserWork",
               "Admin/EditUserWork/{id}",
               "~/Admin/EditUserWork.aspx");

            RouteTable.Routes.MapPageRoute(
               "AddGroup",
               "Admin/AddGroup",
               "~/Admin/AddGroup.aspx");

            RouteTable.Routes.MapPageRoute(
               "Groups",
               "Admin/Groups",
               "~/Admin/Groups.aspx");

            RouteTable.Routes.MapPageRoute(
               "EditGroup",
               "Admin/EditGroup/{id}",
               "~/Admin/EditGroup.aspx");

            RouteTable.Routes.MapPageRoute(
               "AddGroupWork",
               "Admin/AddGroupWork",
               "~/Admin/AddGroupWork.aspx");

            RouteTable.Routes.MapPageRoute(
               "EditGroupWork",
               "Admin/EditGroupWork/{id}",
               "~/Admin/EditGroupWork.aspx");

            RouteTable.Routes.MapPageRoute(
               "GroupWorks",
               "Admin/GroupWorks",
               "~/Admin/GroupWorks.aspx");
        }
    }
}