using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexBlazor.Util
{
    public static class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "bug" => "#26de81",
                "dragon" => "#ffeaa7",
                "electric" => "#fed330",
                "fairy" => "#FF0069",
                "fighting" => "#fc7b03ff",
                "fire" => "#f83200ff",
                "flying" => "#81ecec",
                "grass" => "#00b894",
                "ground" => "#db9e2dff",
                "ghost" => "#a55eea",
                "ice" => "#26dedeff",
                "normal" => "#95afc0",
                "poison" => "#6c5ce7",
                "psychic" => "#bd08ceff",
                "rock" => "#552b04ff",
                "water" => "#0190FF",
                _ => "0190FF"
            };
            return color;
        }

        public static string GetStatColor(string stat)
        {
            string color = stat switch
            {
                "hp" => "#FE0000",
                "attack" => "#EE7F30",
                "defense" => "F7D02C",
                "special-attack" => "#F85687",
                "special-defense" => "#77C755",
                "speed" => "#678FEE",
                _ => "#0190FF"
            };
            return color;
        }
    }
}