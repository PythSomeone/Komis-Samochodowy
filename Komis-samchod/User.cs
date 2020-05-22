using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komis_samchod
{
    public class User
    {
        public String name;
        public Boolean mod;
        public int id;
        public User(String name, Boolean mod, int id)
        {
            this.name = name;
            this.mod = mod;
            this.id = id;
        }
    }
}
