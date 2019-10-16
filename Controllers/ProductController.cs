using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Torus_Tile.Models;

namespace Torus_Tile.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult FloorTiles()
        {
            TileShop ts = new TileShop();
            ViewData["tile products"] = ts.getTileProductsList();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Add(string code, string name, double price, double price_sqf, IFormFile pd_Image)
        {
            string pictureUrl = null;

            if(pd_Image.Length > 0)
            {

                // -- Get the image and save it to the server.
                var fileName = Path.GetFileName(pd_Image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", fileName);
                var stream = new FileStream(filePath, FileMode.Create);
                pd_Image.CopyTo(stream);
                pictureUrl = "/images/" + fileName;
            }


            TileShop ts = new TileShop();


            ts.add_TileProduct(code, name, price, price_sqf, pictureUrl);
            ViewData["tile products"] = ts.getTileProductsList();
            
            return Redirect("/Product/FloorTiles");
        }


        public MySqlConnection connServer()
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


        public string Encrypt_imgDirectory()
        {
            return "";
        }

        public string Encrypt_imgName()
        {
            return "";
        }

    }
}