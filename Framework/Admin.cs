using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Admin
    {
        private int admin_id;
        private string admin_name;
        private string admin_password;
        public Admin(int admin_id, string admin_name, string admin_password)
        {
            this.admin_id = admin_id;
            this.admin_name = admin_name;
            this.admin_password = admin_password;
        }
        public Admin() { }
        public int AdminId { get { return admin_id; } set { admin_id = value; } }
        public string AdminName { get { return admin_name; } set {admin_name = value; } }
        public string AdminPassword {  get { return admin_password; } set {admin_password = value; } }
    }
}
