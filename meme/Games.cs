using static System.Net.WebRequestMethods;

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
        new(
            ["echos", "zeldaechoes", "zeldaechoesofwisdom", "eow"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-echoes-of-wisdom-switch/"
        ),
        new(
            ["linkawakening", "zeldalinkawakening", "linkawake"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-links-awakening-switch/"
        ),
        new(
            ["skyward", "zeldaskyward", "skywardsword", "skywardswordhd"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-skyward-sword-hd-switch/"
        ),
        new(
            ["hyrulewarriors", "hyrulewarriorsageofcalamity", "hwac"],
            "https://www.nintendo.com/us/store/products/hyrule-warriors-age-of-calamity-switch/"
        ),
        new(
            ["hyrulewarriorsdefinitiveedition", "hyrulewarriorsde"],
            "https://www.nintendo.com/us/store/products/hyrule-warriors-definitive-edition-switch/"
        ),
        new(
            ["ageofimprisonment", "zeldaageofimprisonment", "aoi"],
            "https://www.nintendo.com/us/store/products/the-legend-of-zelda-age-of-imprisonment-switch-2/"
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
        new(
            ["SMBrosU", "supermariobrosu", "mariobrosu"],
            "https://www.nintendo.com/us/store/products/super-mario-bros-u-deluxe-switch/"
        ),
        new(
            ["marioparty", "mariopartyuperstars", "mpus"],
            "https://www.nintendo.com/us/store/products/mario-party-superstars-switch/"
        ),
        new(
            ["galaxymario", "supermariogalaxy", "mariogalaxy", "galaxy", "galaxy1"],
            "https://www.nintendo.com/us/store/products/super-mario-galaxy-switch/"
        ),
        new(
            ["galaxy2mario", "supermariogalaxy2", "mariogalaxy2", "galaxy2"],
            "https://www.nintendo.com/us/store/products/super-mario-galaxy-2-switch/"
        ),

        // Pokemon Series
        new(
            ["pokemonlegends", "pokemonlegendsarceus", "arceus", "pkmnlegends"],
            "https://www.nintendo.com/us/store/products/pokemon-legends-arceus-switch/"
        ),
        new(
            ["pokemonlegendsza", "legendsza", "pkmnza", "za"],
            "https://www.nintendo.com/us/store/products/pokemon-legends-z-a-switch/"
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
        new(
            ["fireemblemwarriors", "fe warriors", "fireemblemwarriorsthreehopes", "threehopes"],
            "https://www.nintendo.com/us/store/products/fire-emblem-warriors-three-hopes-switch/"
        ),
        new(
            ["fireemblemengage", "feengage", "engage"],
            "https://www.nintendo.com/us/store/products/fire-emblem-engage-switch/"
        ),

        // Splatoon
        new(
            ["splatoon2", "splat2", "splatoon2"],
            "https://www.nintendo.com/us/store/products/splatoon-2-switch/"
        ),
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
            "https://www.nintendo.com/us/store/products/metroid-prime-4-beyond-switch/"
        ),
        new(
            ["metroidprimeremastered", "metroidprime1", "prime1"],
            "https://www.nintendo.com/us/store/products/metroid-prime-remastered-switch/"
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
        new(
            ["dkbananza", "dk-banana-blast"],
            "https://www.nintendo.com/us/store/products/donkey-kong-banana-blast-switch/"
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
        ),

        // Final Fantasy
        new(
            ["finalfantasy", "ff", "ffi", "finalfantasy1"],
            "https://www.nintendo.com/us/store/products/final-fantasy-switch/"
        ),
        new(
            ["finalfantasyii", "ffii", "finalfantasy2"],
            "https://www.nintendo.com/us/store/products/final-fantasy-ii-switch/"
        ),
        new(
            ["finalfantasyiii", "ffiii", "finalfantasy3"],
            "https://www.nintendo.com/us/store/products/final-fantasy-iii-switch/"
        ),
        new(
            ["finalfantasyiv", "ffiv", "finalfantasy4"],
            "https://www.nintendo.com/us/store/products/final-fantasy-iv-switch/"
        ),
        new(
            ["finalfantasyv", "ffv", "finalfantasy5"],
            "https://www.nintendo.com/us/store/products/final-fantasy-v-switch/"
        ),
        new(
            ["finalfantasyvi", "ffvi", "finalfantasy6"],
            "https://www.nintendo.com/us/store/products/final-fantasy-vi-switch/"
        ),
        new(
            ["finalfantasyvii", "ffvii", "finalfantasy7"],
            "https://www.nintendo.com/us/store/products/final-fantasy-vii-switch/"
        ),
        new(
            ["limited-early-purchase-edition", "finalfantasyvii", "remake", "intergrade"],
            "https://www.nintendo.com/us/store/products/limited-early-purchase-editionfinal-fantasy-vii-remake-intergrade-switch-2/"
        ),
        new(
            ["finalfantasyviii", "ffviii", "finalfantasy8"],
            "https://www.nintendo.com/us/store/products/final-fantasy-viii-remastered-switch/"
        ),
        new(
            ["finalfantasyix", "ffix", "finalfantasy9"],
            "https://www.nintendo.com/us/store/products/final-fantasy-ix-switch/"
        ),
        new(
            ["ffx", "ffx-switch", "finalfantasyx"],
            "https://www.nintendo.com/us/store/products/final-fantasy-x-x-2-hd-switch/"
        ),
        new(
            ["finalfantasyxii", "ffxii", "ffxii-the-zodiac-age"],
            "https://www.nintendo.com/us/store/products/final-fantasy-xii-the-zodiac-age-switch/"
        ),
        
        // Spyro
        new(
            ["spyro", "spyrothedragon", "spyrotrilogy"],
            "https://www.nintendo.com/us/store/products/spyro-reignited-trilogy-switch/"
        ),

        // RickRoll youtube
        new(
            ["rickroll", "nevergonnagiveyouup", "rickastley", "rick"],
            "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
        )
    ];
}

public record GameEntry(string[] Names, string Url);
