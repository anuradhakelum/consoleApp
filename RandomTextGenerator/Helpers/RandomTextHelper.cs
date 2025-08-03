using RandomTextGenerator.Models;

namespace RandomTextGenerator.Helpers
{
    public static class RandomTextHelper
    {
        public static string GenerateRandomText(Options options)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string specials = "!@#$%^&*()-_=+[]{}|;:,.<>?/";

            string chars = letters;
            if (options.Numeric)
                chars += numbers;
            if (options.SpecialCharacter)
                chars += specials;

            if (string.IsNullOrEmpty(chars))
                chars = letters; // fallback

            var random = new System.Random();
            char[] result = new char[options.Length];
            for (int i = 0; i < options.Length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }
    }
}
