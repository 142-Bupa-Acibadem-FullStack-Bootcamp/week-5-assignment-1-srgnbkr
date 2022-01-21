using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.BusinessLogicLayer.Helpers.PasswordHelper
{
    public class PasswordHelper
    {


        public static string MD5Hash(string input)
        {
            using MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x3"));
            }
            return stringBuilder.ToString();
        }

        /*public static bool VerifyPassword(string password)
        {
            using MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x3"));

                if (stringBuilder.ToString() == password)
                {
                    return true;
                }
            }
            return false;*/ //Tekrar bak mantık hatası...
            

           







        }
    }
}
