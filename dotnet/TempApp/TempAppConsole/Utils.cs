using System.Security.Cryptography;
using System.Text;

public class Utils
{
    /// <summary>
    /// Computes the MD5 hash of the given input combined with an optional salt.
    /// </summary>
    /// <param name="input">The text to hash.</param>
    /// <param name="salt">Optional salt value to combine with input.</param>
    /// <returns>The MD5 hash as a hexadecimal string.</returns>
    public static string ComputeHash(string input, string? salt)
    {
        string combined = input + (salt ?? string.Empty);

        byte[] byts = Encoding.UTF8.GetBytes(combined);
        byte[] hash = MD5.HashData(byts);

        StringBuilder sb = new();
        foreach (byte b in hash)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }

    public static string ComputeHashNew(string input, string? salt)
    {
        string combined = input + (salt ?? string.Empty);

        byte[] byts = Encoding.UTF8.GetBytes(combined);
        byte[] hash = MD5.HashData(byts);

        StringBuilder sb = new();
        foreach (byte b in hash)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
}
