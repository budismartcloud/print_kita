using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MySql.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using print_kita.Models;
using System.Collections;

namespace print_kita.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            List<RoleModel> listData = new List<RoleModel>();
            string connection = "Server=localhost;Database=print_kita;Uid=root;Pwd=;";
            MySqlConnection mysql = new MySqlConnection(connection);

            string query = "select * from roles";
            MySqlCommand command = new MySqlCommand(query);
            command.Connection = mysql;
            mysql.Open();

            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read()) {
                listData.Add(new RoleModel {
                    roleId = dataReader["role_id"].ToString(),
                    roleName = dataReader["name"].ToString()
                });
            }

            mysql.Close();
            return View(listData);
        }
    }
}