namespace meme;

public static class Games
{
    public static readonly GameEntry[] All = 
    [
        // Zelda Series
        new(
            ["zelda", "totk", "tears", "tearsofthekingdom", "tloz"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-tears-of-the-kingdom-switch/"
        ),
        new(
            ["breathofthewild", "botw", "zelda1", "wild"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-breath-of-the-wild-switch/"
        ),

        // Mario Series
        new(
            ["mariokart", "mariokart8deluxe", "mk8", "mk8d"],
            "https://www.nintendo.com/us/store/products/mario-kart-8-deluxe-switch/"
        ),
        new(
            ["mario", "supermario", "mariobros", "mariowonder", "wonder"],
            "https://www.nintendo.com/us/store/products/super-mario-bros-wonder-switch/"
        ),

        // Pokemon Series
        new(
            ["pokemonlegends", "pokemonlegendsarceus", "arceus", "pkmnlegends"],
            "https://www.nintendo.com/us/store/products/pokemon-legends-arceus-switch/"
        ),
        new(
            ["pokemonsword", "sword", "pkmnsword"],
            "https://www.nintendo.com/us/store/products/pokemon-sword-switch/"
        ),
        new(
            ["pokemonshield", "shield", "pkmnshield"],
            "https://www.nintendo.com/us/store/products/pokemon-shield-switch/"
        ),
        new(
            ["pokemonscarlet", "scarlet", "violet", "pkmnscarlet"],
            "https://www.nintendo.com/us/store/products/pokemon-scarlet-switch/"
        ),
        new(
            ["pokemonshiningpearl", "shiningpearl", "pearl", "pkmnpearl"],
            "https://www.nintendo.com/us/store/products/pokemon-shining-pearl-switch/"
        ),
        new(
            ["pokemonbrilliantdiamond", "brilliantdiamond", "diamond", "pkmndiamond"],
            "https://www.nintendo.com/us/store/products/pokemon-brilliant-diamond-switch/"
        ),
        new(
            ["pokemoneevee", "eevee", "letsgoeevee", "pkmneevee"],
            "https://www.nintendo.com/us/store/products/pokemon-lets-go-eevee-switch/"
        ),
        new(
            ["pokemonpikachu", "pikachu", "letsgopikachu", "pkmnpikachu"],
            "https://www.nintendo.com/us/store/products/pokemon-lets-go-pikachu-switch/"
        ),
        new(
            ["pokkentournamentdx", "pokken", "tournament"],
            "https://www.nintendo.com/us/store/products/pokken-tournament-dx-switch/"
        ),
        new(
            ["mysterydungeon", "pokemonmysterydungeon", "rescueteam", "rescueteamdx"],
            "https://www.nintendo.com/us/store/products/pokemon-mystery-dungeon-rescue-team-dx-switch/"
        ),
        new(
            ["pokemoncafemix", "cafemix"],
            "https://www.nintendo.com/us/store/products/pokemon-cafe-mix-switch/"
        ),
        new(
            ["newpokemonsnap", "pokemonsnap"],
            "https://www.nintendo.com/us/store/products/new-pokemon-snap-switch/"
        ),

        // Fire Emblem Series
        new(
            ["fireemblem", "fireemblemthreehouses", "threehouses", "fe3h"],
            "https://www.nintendo.com/us/store/products/fire-emblem-three-houses-switch/"
        ),

        // Splatoon
        new(
            ["splatoon3", "splat", "splat3"],
            "https://www.nintendo.com/us/store/products/splatoon-3-switch/"
        ),

        // Metroid Series
        new(
            ["metroidd", "metroiddread", "dread"],
            "https://www.nintendo.com/us/store/products/metroid-dread-switch/"
        ),
        new(
            ["metroidprime", "metroidprime4", "prime4"],
            "https://www.nintendo.com/us/store/products/metroid-prime-4-switch/"
        ),

        // Kirby
        new(
            ["kirby", "kirbyforgottenland", "forgottenland", "pinky"],
            "https://www.nintendo.com/us/store/products/kirby-and-the-forgotten-land-switch/"
        ),
        new(
            ["kirbyairride", "airride"],
            "https://www.nintendo.com/us/store/products/kirby-air-ride-switch/"
        ),

        // Animal Crossing
        new(
            ["animalcrossing", "acnh", "newhorizons", "isabelle", "nook"],
            "https://www.nintendo.com/us/store/products/animal-crossing-new-horizons-switch/"
        ),

        // Smash Bros
        new(
            ["smash", "smashbros", "ssbu", "ultimate", "smashultimate"],
            "https://www.nintendo.com/us/store/products/super-smash-bros-ultimate-switch/"
        ),

        // Luigi's Mansion
        new(
            ["luigismansion2", "mansion2", "darkmoon"],
            "https://www.nintendo.com/us/store/products/luigis-mansion-2-switch/"
        ),
        new(
            ["luigi", "luigismansion", "luigismansion3", "mansion3"],
            "https://www.nintendo.com/us/store/products/luigis-mansion-3-switch/"
        ),

        // Donkey Kong
        new(
            ["donkeykong", "dk", "donkeykongcountry", "donkeykongcountrytropicalfreeze"],
            "https://www.nintendo.com/us/store/products/donkey-kong-country-tropical-freeze-switch/"
        ),

        // Yoshi
        new(
            ["yoshiscraftedworld", "yoshi", "craftedworld"],
            "https://www.nintendo.com/us/store/products/yoshis-crafted-world-switch/"
        ),

        // Undertale and Deltarune
        new(
            ["undertale", "undertaleswitch"],
            "https://www.nintendo.com/us/store/products/undertale-switch/"
        ),
        new(
            ["deltarune", "deltaruneswitch", "deltarunexl"],
            "https://www.nintendo.com/us/store/products/deltarune-switch/"
        )
    ];
}

public record GameEntry(string[] Names, string Url);