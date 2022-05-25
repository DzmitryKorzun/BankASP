using System;
using System.Security.Cryptography;
using System.Text;

namespace BankSystemASP.Domain.Helpers
{
    public static class HashPasswordHelper
    {
        public static string HashPassword(string pas)
        {
            using(var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pas));
                var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hash;
            }
        }
    }
}
