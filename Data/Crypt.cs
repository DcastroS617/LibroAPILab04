using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LibroAPILab04.Data
{
    public class Crypt
    {
        public static string Encrypt(string normalText)
        {
            return Convert.ToBase64String(new UnicodeEncoding().GetBytes(normalText));
        }
        public static string Decrypt(string cypherText)
        {
            return new UnicodeEncoding().GetString(Convert.FromBase64String(cypherText));
        }
    }
}