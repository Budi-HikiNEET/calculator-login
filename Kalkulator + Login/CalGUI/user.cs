using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalGUI
{
    class user
    {
       private String username;
        public String setuser(String username){
            this.username = username;
            return username;
        }
        public String getuser() {
            return username;
        }
    }
}
