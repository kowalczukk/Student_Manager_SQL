using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager2
{
    class Password
    {
        public String Type { get; set; }
        public int Id { get; set; }
        public string Pass { get; set; }
        public string Login { get; set; }
        public Password(string type, int id, string login, string pass)
        {
            this.Id = id;
            this.Type = type;
            this.Login = login;
            this.Pass = pass;            
        }
    }
}
