using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hospital_Database
{
    class EncryptCode
    {
        public string PasswordEncrypt(string pass)
        {
            SHA1 sha = SHA1.Create();
            byte[] EncPass = sha.ComputeHash(Encoding.Default.GetBytes(pass));
            StringBuilder RetValue = new StringBuilder();

            for (int i = 0; i < EncPass.Length; i++)
                RetValue.Append(EncPass[i].ToString());

            return RetValue.ToString();
        }
    }
}
