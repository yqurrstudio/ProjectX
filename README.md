# ProjectX

A simple Windows launcher for Fortnite built with C# and WPF.

> **Disclaimer**
> ProjectX is an independent launcher and is not affiliated with, endorsed by, or sponsored by Epic Games. It does not modify Fortnite, unlock cosmetics, or bypass any game security or online services.

---

## Features

- Modern WPF user interface
- Custom title bar
- Rounded window corners
- Browse for the Fortnite executable
- Verify the installation path
- Launch Fortnite
- Dark theme interface
- Lightweight and easy to use

---

## Default Fortnite Path

ProjectX uses the following default path:

```text
C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe
```

If Fortnite is installed somewhere else, click **Browse** and select the executable manually.

---

## Requirements

- Windows 10 or Windows 11
- .NET 8 SDK (or the runtime required by your build)
- Visual Studio 2022 (recommended)

---

## Building

1. Open the solution in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the project in **Release** or **Debug** mode.
4. Run **ProjectX.exe**.

---

## Usage

1. Start ProjectX.
2. Verify that the Fortnite path is correct.
3. Click **Verify**.
4. Click **Launch** to start Fortnite.

---

## Project Structure

```text
ProjectX/
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── App.xaml
├── App.xaml.cs
├── ProjectX.csproj
└── README.md
```

---

## Known Issues

- The launcher only starts the selected Fortnite executable.
- If Fortnite is moved, you'll need to browse to the new location.
- Administrator permissions may be required depending on your installation.

---

## License

This project is provided as-is for educational purposes.

---

## Credits

Developed using:

- C#
- WPF
- .NET 8
- Github.com

Fortnite and Epic Games are trademarks of their respective owners.

---

## Support

If you encounter an issue:

- Verify the Fortnite executable path.
- Ensure Fortnite is installed correctly.
- Rebuild the project if compiling from source.

---

Enjoy using ProjectX!
