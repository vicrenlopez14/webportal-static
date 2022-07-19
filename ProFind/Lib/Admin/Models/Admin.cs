using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFind.Lib.Admin.Model
{
    public class Admin
    {

        public Admin (string id, string name, string email, string tel, string password, string rank)
        {
            Id = id;
            Name = name;
            Email = email;
            Tel = tel;
            Password = password;
            Rank = rank;
        }

        public Admin(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Password { get; set; }
        public string Rank { get; set; }

    }
}
