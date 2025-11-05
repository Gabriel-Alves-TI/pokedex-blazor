using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexBlazor.Util
{
    public static class PokeUtil
    {
        public const string Pokeball = "pokeball-pixel.png";
        public const string Greatball = "greatball-pixel.png";
        public const string Ultraball = "ultraball-pixel.png";
        public const string Masterball = "masterball-pixel.png";

        public static string GetRandomBall()
        {
            var pokeballArray = new string[] { Pokeball, Greatball, Ultraball, Masterball };

            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];

            return randomBall;
        }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }
        
        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}