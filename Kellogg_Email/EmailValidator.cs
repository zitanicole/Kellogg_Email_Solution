using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_Email
{
    public static class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            //username >= 1 char
            //only one @
            int indexOfAt = email.IndexOf("@");
            if (indexOfAt <= 0 || indexOfAt != email.LastIndexOf('@'))
                return false;

            //no spaces
            if (email.Contains(" "))
                return false;

            //username length
            string username = email.Substring(0, indexOfAt);
            if (username.Length < 1)
                return false; 
            
            if (username.Length >= 100)
                return false;
            
            //domain lenth
            string domain = email.Substring(indexOfAt + 1);
            if (domain.Length < 3 || domain.Length > 100)
                return false;

            //. after @
            int indexOfDot = email.IndexOf('.', indexOfAt);
            if (indexOfDot <= indexOfAt + 1 || indexOfDot == email.Length - 1)
                return false;

            //alpha
            if (!char.IsLetter(username[0]) || !char.IsLetter(username[^1]) ||
            !char.IsLetter(domain[0]) || !char.IsLetter(domain[^1]))
                return false;

            return true;
        }
    }
}
