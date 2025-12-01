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

// Open Nintendo eShop in default browser
var url = "https://www.nintendo.com/store/";
try
{
    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
    {
        FileName = url,
        UseShellExecute = true
    });
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to open browser: {ex.Message}");
}

Thread.Sleep(200); // Give time to see the final message before closing
