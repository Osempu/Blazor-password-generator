namespace PassGen.models;

public class Password
{
    public string PasswordString { get; set; } = string.Empty;
    public int PasswordLength { get; set; } = 8;
    public bool IncludeLowercase { get; set; } = true;
    public bool IncludeUppercase { get; set; } = false;
    public bool IncludeNumbers { get; set; } = false;
    public bool IncludeSymbols { get; set; } = false;
}