# Password Generator - Blazor WebAssembly

A modern, secure password generator built with Blazor WebAssembly that creates strong, customizable passwords with real-time strength indicators.

![Password Generator](https://img.shields.io/badge/Blazor-WebAssembly-512bd4?style=for-the-badge&logo=blazor)
![.NET 8](https://img.shields.io/badge/.NET-8.0-512bd4?style=for-the-badge&logo=dotnet)

## ✨ Features

- **🔐 Secure Password Generation**: Uses cryptographically secure random number generation
- **🎛️ Customizable Options**: Control password length and character types
- **📊 Password Strength Indicator**: Visual feedback on password security level
- **📋 One-Click Copy**: Copy generated passwords to clipboard instantly
- **🎨 Modern UI**: Clean, responsive design with intuitive controls
- **⚡ Fast Performance**: Client-side generation with Blazor WebAssembly

## 🚀 Quick Start

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A modern web browser with WebAssembly support

### Installation & Running

1. **Clone the repository**

   ```bash
   git clone https://github.com/Osempu/Blazor-password-generator.git
   cd Blazor-password-generator
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Run the application**

   ```bash
   dotnet run
   ```

4. **Open your browser**
   Navigate to `https://localhost:5155` (or the URL shown in the terminal)

### Alternative: Development with Hot Reload

```bash
dotnet watch run
```

## 🎮 Usage

1. **Set Password Length**: Use the number input to specify desired password length (minimum 1 character)

2. **Choose Character Types**:
   - ✅ **Lowercase Letters** (a-z) - Default enabled
   - ✅ **Uppercase Letters** (A-Z)
   - ✅ **Numbers** (0-9)
   - ✅ **Symbols** (!@#$%^&*()_+-=[]{}|;:,.<>?)

3. **Generate Password**: Click the "Generate" button to create a new password

4. **Copy to Clipboard**: Click the copy icon next to the generated password

5. **Check Strength**: View the visual strength indicator to assess password security

## 🏗️ Project Structure

```text
PassGen/
├── Pages/
│   ├── Home.razor              # Main password generator page
│   └── Home.razor.css          # Page-specific styles
├── Layout/
│   ├── MainLayout.razor        # Application layout
│   └── MainLayout.razor.css    # Layout styles
├── models/
│   └── Password.cs             # Password configuration model
├── utils/
│   └── PasswordBuilder.cs      # Password generation logic
├── wwwroot/
│   ├── index.html              # Entry point HTML
│   ├── css/                    # Global styles
│   └── favicon.png             # Application icon
├── App.razor                   # Root component
├── Program.cs                  # Application entry point
└── PassGen.csproj              # Project configuration
```

## 🔧 Configuration Options

The password generator supports the following customization options:

| Option | Type | Default | Description |
|--------|------|---------|-------------|
| Password Length | `int` | 8 | Number of characters (1-100) |
| Include Lowercase | `bool` | `true` | Include a-z characters |
| Include Uppercase | `bool` | `false` | Include A-Z characters |
| Include Numbers | `bool` | `false` | Include 0-9 characters |
| Include Symbols | `bool` | `false` | Include special symbols |

## 🛡️ Security Features

- **Cryptographically Secure**: Uses `System.Security.Cryptography.RandomNumberGenerator` for entropy
- **Client-Side Generation**: Passwords are generated entirely in the browser
- **No Server Storage**: Generated passwords are never transmitted or stored
- **Strength Validation**: Real-time password strength assessment

## 🔨 Development

### Building for Production

```bash
dotnet publish -c Release
```

The compiled application will be available in `bin/Release/net8.0/publish/wwwroot/`.

### Running Tests

```bash
dotnet test
```

### Code Style

This project follows standard C# and Blazor conventions:

- PascalCase for public members
- camelCase for private fields
- Meaningful variable names
- Comprehensive XML documentation

## 📦 Dependencies

- **Microsoft.AspNetCore.Components.WebAssembly** (8.0.11) - Blazor WebAssembly runtime
- **Microsoft.AspNetCore.Components.WebAssembly.DevServer** (8.0.11) - Development server

## 🌐 Browser Compatibility

- Chrome 57+
- Firefox 52+
- Safari 11+
- Edge 16+
- Opera 44+

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- Built with [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- Icons from [Hugeicons](https://hugeicons.com/)
- Styled with modern CSS Grid and Flexbox

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Issues](https://github.com/Osempu/Blazor-password-generator/issues) page
2. Create a new issue with detailed information
3. Include steps to reproduce any bugs

---

Made with ❤️ using Blazor WebAssembly
