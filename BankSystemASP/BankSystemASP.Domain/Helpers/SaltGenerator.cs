using System;

namespace BankSystemASP.Domain.Helpers
{
    public class SaltGenerator
    {
        public static string GenerateSalt()
        {
            return HashPasswordHelper.HashPassword(DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds.ToString());
        }
    }
}
