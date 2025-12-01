using System.Runtime.InteropServices;

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

// Define games with multiple aliases
var games = new[]
{
    new
    {
        Names = new[] { "zelda", "totk", "tears", "tearsofthekingdom", "tloz" },
        Url = "https://www.nintendo.com/us/store/products/the-legend-of-zelda-tears-of-the-kingdom-switch/"
    },
    new
    { Names = new[] { "breathofthewild", "botw", "zelda1", "zelda", "wild" },
        Url = "https://www.nintendo.com/us/store/products/the-legend-of-zelda-breath-of-the-wild-switch/"
    },
    new
    {
        Names = new[] { "mario", "supermario", "mariobros", "mariowonder", "wonder" },
        Url = "https://www.nintendo.com/us/store/products/super-mario-bros-wonder-switch/"
    },
    new
    {
        Names = new[] { "MarioKart", "mariokart8deluxe", "mk8", "mk8d", "mariokart" },
        Url = "https://www.nintendo.com/us/store/products/mario-kart-8-deluxe-switch/"
    },
    new
    {
        Names = new[] { "pokemonlegends", "pokemonlegendsarceus", "arceus", "pkmnlegends" },
        Url = "https://www.nintendo.com/us/store/products/pokemon-legends-arceus-switch/"
    },
    new
    {
        Names = new[] { "pokemonshiningpearl", "shiningpearl", "pearl", "pkmnpearl" },
        Url = "https://www.nintendo.com/us/store/products/pokemon-shining-pearl-switch/"
    },
    new
    {
        Names = new[] { "pokemon", "pokémon", "scarlet", "violet", "pkmn" },
        Url = "https://www.nintendo.com/us/store/products/pokemon-scarlet-switch/"
    },
    new
    {
        Names = new[] { "splatoon", "splatoon3", "splat", "splat3" },
        Url = "https://www.nintendo.com/us/store/products/splatoon-3-switch/"
    },
    new
    {
        Names = new[] { "metroid", "metroiddread", "dread", "samus" },
        Url = "https://www.nintendo.com/us/store/products/metroid-dread-switch/"
    },
    new
    {
        Names = new[] { "kirby", "kirbyforgottenland", "forgottenland", "pinky" },
        Url = "https://www.nintendo.com/us/store/products/kirby-and-the-forgotten-land-switch/"
    },
    new
    {
        Names = new[] { "animalcrossing", "acnh", "newhorizons", "isabelle", "nook" },
        Url = "https://www.nintendo.com/us/store/products/animal-crossing-new-horizons-switch/"
    },
    new
    {
        Names = new[] { "smash", "smashbros", "ssbu", "ultimate", "smashultimate" },
        Url = "https://www.nintendo.com/us/store/products/super-smash-bros-ultimate-switch/"
    }
};

// Find matching URL based on executable name
var url = games.FirstOrDefault(g => g.Names.Contains(exeName, StringComparer.OrdinalIgnoreCase))?.Url
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