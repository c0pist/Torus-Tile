using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Torus_Tile.Controllers
{
    public class AuthController : Controller
    {


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string user_id, string user_pw, string user_pw2)
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string user_id, string user_pw)
        {
            try
            {
                var con = this.CreateConnection();
                string cmdText = $"select * from users where userid = '{user_id}' and userpw = '{user_pw}';";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {

                    while (result.Read())
                    {  
                        HttpContext.Session.SetString("user", result["userid"].ToString());
                    }

                    ViewData["error"] = true;
                    ViewData["loginSuccessful"] = true;
                    ViewData["userNotFound"] = false;
                    return Redirect("/home/index");

                }
                else
                {
                    ViewData["error"] = false;
                    ViewData["loginSuccessful"] = false;
                    ViewData["userNotFound"] = true;
                    return View();
                }
            }
            catch
            {
                ViewData["error"] = true;
                ViewData["loginSuccessful"] = false;
                ViewData["userNotFound"] = false;
                return View();
            }

        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/auth/login");
        }


        public MySqlConnection CreateConnection()
        {
            MySqlConnectionStringBuilder strConn = new MySqlConnectionStringBuilder();
            strConn.Server = "localhost";
            strConn.Port = 3306;
            strConn.UserID = "root";
            strConn.Password = "Delkaiser920!";
            strConn.Database = "torustile";

            //string strConn = "server=127.0.0.1;database=onlineshopwebsite;user=root;password=Delkaiser920!;port=3306;";

            MySqlConnection conn = new MySqlConnection(strConn.ToString());
            conn.Open();

            return conn;
        } // <-- Opens mysql server and return. Easy to use.

    }
}