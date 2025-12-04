using System.Runtime.InteropServices;
using System.Diagnostics;

namespace meme;

internal class Program
{
    static void Main(string[] args)
    {
        // Check if running on Linux without a terminal attached
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && !args.Contains("--terminal-launched"))
        {
            if (!IsRunningInTerminal())
            {
                // Relaunch in a terminal emulator
                LaunchInTerminal();
                return;
            }
        }

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
            "Never going to give you up...",
            "Establishing backdoor connection...",
            "Encrypting user data...",
            "Installing rootkit components...",
            "Modifying registry entries...",
            "Disabling antivirus signatures...",
            "You got l33t'd! hax0rs rulez.",
            "We're no strangers to love...",
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

        // Check if the file name ends with -rr to trigger Rick Roll
        string url;
        if (exeName.EndsWith("-rr", StringComparison.OrdinalIgnoreCase))
        {
            url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        }
        else
        {
            // Find matching URL based on executable name
            url = Games.All.FirstOrDefault(g => g.Names.Contains(exeName, StringComparer.OrdinalIgnoreCase))?.Url
                      ?? "https://www.nintendo.com/store/";
        }

        try
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                OpenUrlOnLinux(url);
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

        Thread.Sleep(500); // Give time to see the final message before closing
    }

    private static bool IsRunningInTerminal()
    {
        try
        {
            // Check if stdin is redirected (not connected to a terminal)
            return !Console.IsInputRedirected && Console.WindowHeight > 0;
        }
        catch
        {
            return false;
        }
    }

    private static void LaunchInTerminal()
    {
        var executablePath = Environment.ProcessPath ?? System.Reflection.Assembly.GetExecutingAssembly().Location;
        
        // List of common Linux terminal emulators to try
        string[] terminals =
        {
            "gnome-terminal", // GNOME
            "konsole",        // KDE
            "xfce4-terminal", // XFCE
            "xterm",          // X11 default
            "mate-terminal",  // MATE
            "lxterminal",     // LXDE
            "terminator",     // Popular alternative
            "alacritty",      // Modern GPU-accelerated
            "kitty",          // Another modern option
            "tilix"           // Tiling terminal
        };

        foreach (var terminal in terminals)
        {
            try
            {
                ProcessStartInfo psi;
                
                if (terminal == "gnome-terminal")
                {
                    // gnome-terminal uses -- to separate its args from the command
                    psi = new ProcessStartInfo
                    {
                        FileName = terminal,
                        Arguments = $"-- {executablePath} --terminal-launched",
                        UseShellExecute = false
                    };
                }
                else if (terminal == "konsole")
                {
                    psi = new ProcessStartInfo
                    {
                        FileName = terminal,
                        Arguments = $"-e {executablePath} --terminal-launched",
                        UseShellExecute = false
                    };
                }
                else
                {
                    // Most terminals use -e for execute
                    psi = new ProcessStartInfo
                    {
                        FileName = terminal,
                        Arguments = $"-e {executablePath} --terminal-launched",
                        UseShellExecute = false
                    };
                }

                var process = System.Diagnostics.Process.Start(psi);
                if (process != null)
                {
                    // Successfully launched in terminal
                    return;
                }
            }
            catch
            {
                // This terminal emulator isn't available, try the next one
                continue;
            }
        }

        // If we couldn't launch any terminal, fall back to showing a message via zenity or notify-send
        try
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "zenity",
                Arguments = "--info --text=\"Could not find a terminal emulator. Please run this program from a terminal.\" --title=\"Terminal Required\"",
                UseShellExecute = false
            });
        }
        catch
        {
            // Last resort: try notify-send
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "notify-send",
                    Arguments = "\"Terminal Required\" \"Could not find a terminal emulator. Please run this program from a terminal.\"",
                    UseShellExecute = false
                });
            }
            catch
            {
                // Give up silently
            }
        }
    }

    private static void OpenUrlOnLinux(string url)
    {
        // List of common browsers on Linux, in order of preference
        string[] browsers =
        {
            "firefox",
            "google-chrome",
            "chrome",
            "chromium",
            "chromium-browser",
            "microsoft-edge",
            "brave-browser",
            "opera",
            "vivaldi",
            "epiphany",      // GNOME Web
            "konqueror",     // KDE browser
            "falkon",        // KDE lightweight browser
            "midori",
            "qutebrowser",
            "palemoon",
            "seamonkey",
            "waterfox"
        };

        // Try to find an installed browser using 'which'
        foreach (var browser in browsers)
        {
            try
            {
                var whichProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "which",
                        Arguments = browser,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                whichProcess.Start();
                var browserPath = whichProcess.StandardOutput.ReadToEnd().Trim();
                whichProcess.WaitForExit();

                // If 'which' found the browser (exit code 0 and non-empty output)
                if (whichProcess.ExitCode == 0 && !string.IsNullOrWhiteSpace(browserPath))
                {
                    // Launch the browser with proper detachment using nohup and setsid
                    // This ensures the browser survives even if the parent process exits
                    var browserProcess = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "/bin/sh",
                            Arguments = $"-c \"nohup '{browserPath}' '{url}' > /dev/null 2>&1 &\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            CreateNoWindow = true
                        }
                    };
                    
                    browserProcess.Start();
                    
                    // Give the browser a moment to start
                    Thread.Sleep(500);
                    return;
                }
            }
            catch
            {
                // Continue to next browser
                continue;
            }
        }

        // Last resort: try xdg-open
        try
        {
            var xdgProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/sh",
                    Arguments = $"-c \"nohup xdg-open '{url}' > /dev/null 2>&1 &\"",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            xdgProcess.Start();
            Thread.Sleep(500);
        }
        catch
        {
            throw new Exception("No suitable browser found on the system");
        }
    }
}