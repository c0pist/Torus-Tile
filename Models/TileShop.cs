using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Torus_Tile.Models
{
    public class TileShop
    {

        public TileShop() { }

        
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


        #region User part -- add, get, update, delete
        public List<User> getUsersFromServer()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = connServer();

            MySqlCommand cmd = new MySqlCommand("select * from users;", conn);
            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                User u = new User();
                u.id = Convert.ToInt32(r["id"]);
                u.userId = r["userid"].ToString();
                u.userPw = r[""].ToString();
                u.FirstName = r["firstname"].ToString();
                u.LastName = r["fastname"].ToString();
                u.Phone = r["phone"].ToString();
                u.Email = r["email"].ToString();
                u.Token = r["token"].ToString();
                u.user_Type = Convert.ToInt32(r["user_type"]);
                u.CreationDate = r["creationDate"].ToString();

                users.Add(u);
            }

            return users;
        } // <-- Get all users from Database.

        public void addUser(User u)
        {
            MySqlConnection conn = connServer();
            MySqlCommand cmd = new MySqlCommand($"insert into `users`(`userid`, `userpw`, `firstname`, `lastname`, `phone`, `email`, `token`, `user_type`, " +
                $"`creationDate`) value('{u.userId}', '{u.userPw}', '{u.FirstName}', '{u.LastName}', '{u.Phone}', '{u.Email}', '{u.Token}', " +
                $"'{u.user_Type.ToString()}', '{u.CreationDate}');", conn);

            try
            {
                cmd.BeginExecuteNonQuery();
            }
            catch { }
        } //-- Add single user to Database.
        public void updateUser(User u)
        {
            MySqlConnection conn = connServer();

            MySqlCommand cmd = new MySqlCommand($"update users set `userid` = '{u.userId}', `userpw` = '{u.userPw}', `firstname` = '{u.FirstName}', `lastname` = '{u.LastName}'," +
                $"`phone` = '{u.Phone}', `email` = `{u.Email}', `token` = '{u.Token}', `user_type` = '{u.user_Type}', `CreationDate` = '{u.CreationDate}' where `id` = {u.id};", conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        public void deleteUser(int id)
        {

        }

        #endregion



        public List<Tile_Product> getTileProductsList()
        {
            List<Tile_Product> products = new List<Tile_Product>();

            MySqlConnection con = connServer();
            MySqlCommand cmd = new MySqlCommand("select * from products;", con);
            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                Tile_Product p = new Tile_Product();
                p.id = Convert.ToInt32(r["id"]);
                p.Code = r["Code"].ToString();
                p.Name = r["Name"].ToString();
                p.Price = Convert.ToDouble(r["price"]);
                p.Price_Sqf = Convert.ToDouble(r["price2"]);
                p.imgUrl = r["pictureUrl"].ToString();


                products.Add(p);
            }
            return products;

        }


        public void add_TileProduct(string code, string name, double price, double price_sqf, string imgUrl)
        {

            var con = connServer();
            string cmdText = $"insert into products(Code, Name, price, price2, pictureUrl) value('{code}', '{name}', '{price.ToString()}', '{price_sqf.ToString()}', " +
                $"'{imgUrl}');";

            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
        }

        
    }
}
