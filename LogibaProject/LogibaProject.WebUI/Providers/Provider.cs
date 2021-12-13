using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LogibaProject.WebUI.Providers
{
    public static class Provider
    {
        public static string PasswordEncode(string pass)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string encryp_pass = Convert.ToBase64String(sha1.ComputeHash(Encoding.UTF8.GetBytes(Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(pass)))))).ToString();
            return encryp_pass;
        }

        public static string getStatusColor(object Value)
        {
            string status = "";
            switch (Value.ToString())
            {
                case "1": status = "info"; break;
                case "2": status = "success"; break;
                case "3": status = "danger"; break;
            }
            return status;
        }

        public static string getStatusText(object Value)
        {
            string status = "";
            switch (Value.ToString())
            {
                case "1": status = "Devam Ediyor"; break;
                case "2": status = "Bitti"; break;
                case "3": status = "Durduruldu"; break;
            }
            return status;
        }
    }
}