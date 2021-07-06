using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_design.Model
{
    public class Employee
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string _password { get; set; }
        public string phoneNum { get; set; }
        public string email { get; set; }
        public bool deleted { get; set; }
        public Role role { get; set; }

        public Employee() {}

        public Employee(string userName, string password)
        {
            this.userName = userName;
            _password = password;
        }
    }
}
