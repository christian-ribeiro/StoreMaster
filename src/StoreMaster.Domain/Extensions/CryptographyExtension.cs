namespace StoreMaster.Domain.Extensions
{
    public static class CryptographyExtension
    {
        public static string HashPassword(this string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(this string currentPassword, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, currentPassword);
        }
    }
}