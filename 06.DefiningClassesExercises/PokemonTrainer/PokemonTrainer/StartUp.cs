using System.Linq;

namespace PokemonTrainer;

public class StartUp
{
    static void Main(string[] args)
    {
        string tokens;

        List<Trainer> trainers = new();

        while ((tokens = Console.ReadLine()) != "Tournament")
        {
            string[] values = tokens.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Trainer trainer = trainers.SingleOrDefault(t => t.Name == values[0]);

            if (trainer == null)
            {
                trainer = new(values[0]);
                trainer.Pokemons.Add(new(values[1], values[2], int.Parse(values[3])));
                trainers.Add(trainer);
            }
            else
            {
                trainer.Pokemons.Add(new(values[1], values[2], int.Parse(values[3])));
            }
        }
        string command;
        while ((command = Console.ReadLine()) != "End")
        {

            foreach (var trainer in trainers)
            {
                trainer.CheckPokemon(command);
            }

        }

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        }
    }


}