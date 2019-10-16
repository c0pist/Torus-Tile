using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Torus_Tile.Models
{
    public class User
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string userPw { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public int user_Type { get; set; }
        public string CreationDate { get; set; }
        
        public User() { }
        public User(int id, string userid, string userpw, string firstname, string lastname, string phone, string email, string token, int user_type, string creationDate)
        {
            this.id = id;
            this.userId = userid;
            this.userPw = userpw;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Phone = phone;
            this.Email = email;
            this.Token = token;
            this.user_Type = user_type;
            this.CreationDate = creationDate;
        }
    }
}