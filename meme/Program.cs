using System.Runtime.InteropServices;

namespace meme;

internal class Program
{
    static void Main(string[] args)
    {
        // Troll program - displays fake "malware" installation and opens Nintendo eShop
        // Spam some gibberish to look threatening
        string[] fakeProcesses =
        {
            "Initializing kernel modules...",
            "Downloading payload from 192.168.x.xxx...",
            "Injecting hooks into system32...",
            "Overwriting boot sector...",
            "Disabling system restore points...",
            "Bypassing firewall protocols...",
            "Establishing backdoor connection...",
            "Encrypting user data...",
            "Installing rootkit components...",
            "Modifying registry entries...",
            "Disabling antivirus signatures...",
            "You got l33t'd! hax0rs rulez.",
            "All your base are belong to us."
        };

        foreach (var process in fakeProcesses)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {process}");
            Thread.Sleep(Random.Shared.Next(10, 50)); // Random delay for effect
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n✓ Installation successful! Redirecting...\n");
        Console.ResetColor();

        // Get the executable name without extension
        var exeName = Path.GetFileNameWithoutExtension(Environment.ProcessPath ?? "meme").ToLowerInvariant();

        // Find matching URL based on executable name
        var url = Games.All.FirstOrDefault(g => g.Names.Contains(exeName, StringComparer.OrdinalIgnoreCase))?.Url
                  ?? "https://www.nintendo.com/store/";

        try
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Use xdg-open for Linux (including WSL2 if Firefox is installed in WSL)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "xdg-open",
                    Arguments = url,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Windows
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // macOS
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "open",
                    Arguments = url,
                    UseShellExecute = false
                });
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open browser: {ex.Message}");
        }

        Thread.Sleep(200); // Give time to see the final message before closing
    }
}