using System;
using System.Security.Cryptography;
using System.Text;

namespace HVC.Store.UI.Infra.Helpers {
    public static class StringHelpers {

        public static string Encrypt(this string password) {

            var salt = "|17DFD7AFDEB747E19C61E1B0320D90E5C722F697824A44F0B653CC0DEE8B5271";
            var arrayBytes = Encoding.UTF8.GetBytes(password + salt);
            
            byte[] hashBytes;
            using (var sha = SHA512.Create()) {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
