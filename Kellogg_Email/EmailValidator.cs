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

            int indexOfAt = email.IndexOf("@");
            if (indexOfAt <= 0 || indexOfAt != email.LastIndexOf('@'))
                return false;

                return true;
        }
    }
}
