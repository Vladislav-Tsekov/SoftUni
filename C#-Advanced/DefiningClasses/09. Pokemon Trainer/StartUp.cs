
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args) 
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                List<Pokemon> pokemonList = new()
                {
                    currentPokemon
                };

                Trainer currentTrainer = new(trainerName);
                Trainer getTrainer = trainers.FirstOrDefault(t => t.Name == currentTrainer.Name);
                if (trainers.Contains(getTrainer))
                {  
                    getTrainer.PokemonsCollection.Add(currentPokemon);
                }
                else if (!trainers.Contains(currentTrainer))
                {
                    Trainer newTrainer = new Trainer(trainerName, pokemonList);
                    trainers.Add(newTrainer);
                }
            }

            string element = string.Empty;
            while ((element = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (trainers[i].PokemonsCollection.Any(p => p.Element == element))
                    {
                        trainers[i].Badges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainers[i].PokemonsCollection)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                }

                foreach (var pokemons in trainers)
                {
                    pokemons.PokemonsCollection.RemoveAll(p => p.Health <= 0);
                }

            }

            trainers = trainers.OrderByDescending(t => t.Badges).ToList();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.PokemonsCollection.Count}");
            }
        }

    }
}
