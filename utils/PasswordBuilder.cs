using System.Security.Cryptography;
using PassGen.models;

public class PasswordBuilder
{
    private Password _password;
    private static readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();

    public PasswordBuilder(Password? existingPassword = null)
    {
        _password = existingPassword ?? new Password();
    }

    public PasswordBuilder SetPasswordLength(int length)
    {
        _password.PasswordLength = length;
        return this;
    }

    public PasswordBuilder IncludeUppercase(bool include)
    {
        _password.IncludeUppercase = include;
        return this;
    }

    public PasswordBuilder IncludeLowercase(bool include)
    {
        _password.IncludeLowercase = include;
        return this;
    }

    public PasswordBuilder IncludeNumbers(bool include)
    {
        _password.IncludeNumbers = include;
        return this;
    }

    public PasswordBuilder IncludeSymbols(bool include)
    {
        _password.IncludeSymbols = include;
        return this;
    }

    public Password Build()
    {
        _password.PasswordString = GeneratePassword();
        return _password;
    }

    private string GeneratePassword()
    {
        // Validaciones
        if (_password.PasswordLength <= 0)
            throw new InvalidOperationException("Password length must be greater than zero.");

        // Conjuntos de caracteres
        const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        const string numberChars = "0123456789";
        const string symbolChars = "!@#$%^&*()-_=+[]{}<>?/|";

        // Construcción del pool de caracteres
        var characterPool = new List<char>();
        var requiredChars = new List<char>();

        if (_password.IncludeUppercase)
        {
            characterPool.AddRange(uppercaseChars);
            requiredChars.Add(GetSecureRandomChar([.. uppercaseChars]));
        }

        if (_password.IncludeLowercase)
        {
            characterPool.AddRange(lowercaseChars);
            requiredChars.Add(GetSecureRandomChar([.. lowercaseChars]));
        }

        if (_password.IncludeNumbers)
        {
            characterPool.AddRange(numberChars);
            requiredChars.Add(GetSecureRandomChar([.. numberChars]));
        }

        if (_password.IncludeSymbols)
        {
            characterPool.AddRange(symbolChars);
            requiredChars.Add(GetSecureRandomChar([.. symbolChars]));
        }

        // Generar caracteres restantes
        var remainingChars = Enumerable.Range(0, _password.PasswordLength - requiredChars.Count)
            .Select(_ => GetSecureRandomChar(characterPool.ToArray()))
            .ToList();

        // Combinar y mezclar caracteres
        var allChars = requiredChars.Concat(remainingChars).ToList();
        return ShuffleSecurely(allChars);
    }

    private char GetSecureRandomChar(char[] characterSet)
    {
        var randomIndex = GetSecureRandomIndex(characterSet.Length);
        return characterSet[randomIndex];
    }

    private int GetSecureRandomIndex(int maxValue)
    {
        var randomBytes = new byte[4];
        _rng.GetBytes(randomBytes);
        return Math.Abs(BitConverter.ToInt32(randomBytes, 0) % maxValue);
    }

    private string ShuffleSecurely(List<char> chars)
    {
        var n = chars.Count;
        while (n > 1)
        {
            n--;
            var k = GetSecureRandomIndex(n + 1);
            var value = chars[k];
            chars[k] = chars[n];
            chars[n] = value;
        }
        return new string(chars.ToArray());
    }
}