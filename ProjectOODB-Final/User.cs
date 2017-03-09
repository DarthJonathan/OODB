using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOODB_Final
{
    class User
    {
        private String name, phone, email, address, password, userid, rolename;

        public User(String name, String phone, String email, String address, String password, String userid, String rolename)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.password = password;
            this.userid = userid;
            this.rolename = rolename;
        }



    }
}
