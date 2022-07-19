using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProFind.Lib.Admin.Model;

namespace ProFind.Lib.Admin.Model
{
    static class GlobalList
    {
        public static List<Professional> gvProffesional = new List<Professional>()
        {
            new Professional("Fernando",DateTimeOffset.Parse("2006/03/30"),"fernandomelen20@gmail.com","hola1234","1","2"),
            new Professional("Victor",DateTimeOffset.Parse("2005/06/20"),"vicrenlopez@gmail.com","jijijija","3","4")
        };
    }
}
