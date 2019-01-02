using MySql.Data.MySqlClient;
using print_kita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace print_kita.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["activeUser"] != null)
                Response.Redirect("/Home", true);
            return View();
        }

        [HttpPost]
        public ActionResult Check()
        {
            var email = Request["email"];
            var password = Request["password"];

            string connection = "Server=localhost;Database=print_kita;Uid=root;Pwd=;";
            MySqlConnection mysql = new MySqlConnection(connection);

            string query = "select * from users where email = '" + email + "' AND password = '" + password + "'";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = mysql;
            mysql.Open();

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Session["activeUser"] = 1;
                Session["activeUserName"] = dataReader["name"];
                Session["activeUserRoleId"] = dataReader["role_id"];
                Session["activeUserEmail"] = dataReader["email"];

                if (dataReader["role_id"].Equals(1))
                {
                    Session["activeUserRoleName"] = "Admin";
                }
                else
                {
                    Session["activeUserRoleName"] = "Pelanggan";
                }
            }

            mysql.Close();

            if (Session["activeUser"] == null)
            {
                return Json("0");
            }
            else
            {
                return Json("1");
            }
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session["activeUser"] = null;
            Session["activeUserName"] = null;
            Session["activeUserRoleId"] = null;
            Session["activeUserEmail"] = null;
            Session["activeUserRoleName"] = null;

            return Json("1");
        }
    }
}