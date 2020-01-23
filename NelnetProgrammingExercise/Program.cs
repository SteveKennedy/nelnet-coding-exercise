using NelnetProgrammingExercise.Models;
using System;
using System.Linq;
using NelnetProgrammingExercise.Extensions;

namespace NelnetProgrammingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = InitializationManager.SetupObjects();
            var pets = objects.Pets;
            var people = objects.People;

            foreach (PersonModel person in people) {
                Console.WriteLine($"Pets for {person.Name}:");

                foreach(PetModel pet in pets.OrderByPreferenceForPerson(person))
                {

                    Console.WriteLine($"{pet.Name} would be a {(MatchManager.IsGood(person, pet) ? "good" : "bad")} pet.");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
