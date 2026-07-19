using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class User
    {
        private string user_name;
        private string user_pass;
        private double user_weight;
        private double user_height;
        public User() { }
        public User(string user_name, string user_pass, double user_weight, double user_height)
        {
            this.user_name = user_name;
            this.user_pass = user_pass;
            this.user_weight = user_weight;
            this.user_height = user_height;
        }

        public string UserName { get { return user_name; } set { user_name = value; } }

        public string UserPass { get { return user_pass; } set { user_pass = value; } }
        public double UserHeight { get { return user_height; } set { user_height = value; } }

        public double UserWeight { get { return user_weight; } set { user_weight = value; } }
    
    }
}
