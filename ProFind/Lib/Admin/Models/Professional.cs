using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_ProFind.Lib.Admin.Model
{
    internal class Professional
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DateBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Curriculum { get; set; }
        public string Job { get; set; }

        public Professional(string name, DateTimeOffset dateBirth, string email, string password, string curriculum, string job)
        {
            Id = Nanoid.Nanoid.Generate();
            Name = name;
            DateBirth = dateBirth;
            Email = email;  
            Password = password;
            Curriculum = curriculum;
            Job = job;
        }

        public Professional()
        {
            Id = Nanoid.Nanoid.Generate();
        }
    }
}
