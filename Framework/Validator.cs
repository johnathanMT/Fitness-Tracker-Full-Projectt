using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Validator
    {
        public Validator() { }

        //check the username: only letters and numbers are allowed
        public bool checkUsername(string name)
        {
            if (name == null || name.Length == 0)
                return false;   //empty username is not allowed

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (!char.IsLetter(c) && !char.IsDigit(c))
                    return false;   //found a space or a symbol
            }
            return true;
        }

        //check the password: exactly 12 characters,
        //at least one lowercase and one uppercase letter
        public bool checkPassword(string pass)
        {
            if (pass == null || pass.Length != 12)
                return false;   //must be exactly 12 characters

            bool hasLower = false;
            bool hasUpper = false;
            for (int i = 0; i < pass.Length; i++)
            {
                char c = pass[i];
                if (char.IsLower(c))
                    hasLower = true;
                if (char.IsUpper(c))
                    hasUpper = true;
            }
            return hasLower && hasUpper;
        }
    }
}
