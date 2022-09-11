using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFind.Lib.Global.Services
{
    public partial class Client
    {
        public Client(string idC, string nameC, string emailC, string passwordC, byte[] pictureC)
        {
            IdC = idC;
            NameC = nameC;
            EmailC = emailC;
            PasswordC = passwordC;
            PictureC = pictureC;
        }

        public override string ToString() => NameC;

    }
}
