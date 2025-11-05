using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PokedexBlazor.Models;

namespace PokedexBlazor.Util
{
    public class PokeClient
    {
        public HttpClient Client { get; set;}
        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<Pokemon> GetPokemon(string id)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content.Substring(0, 100)); // imprime os 100 primeiros caracteres

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<Pokemon>(content, options);
        }

        public async Task<Pokemon> GetPokemonByName(string name)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            var content = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<Pokemon>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<PokemonList> GetAllPokemons(int limit, int offset)
        {
            var response = await this.Client.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}&offset={offset}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<PokemonList>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}