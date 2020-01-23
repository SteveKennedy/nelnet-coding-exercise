using System;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise
{
    public class InitializationManager
    {
        public static (PersonModel[] People, PetModel[] Pets) SetupObjects()
        {
            var people = new[]
            {
                new PersonModel()
                {
                    Name = "Dalinar",
                    PreferredClassification = PetClassification.Mammal,
                    PreferredType = PetType.Snake
                },
                new PersonModel()
                {
                    Name = "Kaladin",
                    PreferredClassification = PetClassification.Bird,
                    PreferredType = PetType.Goldfish
                }
            };

            var pets = new[]
            {
                new PetModel()
                {
                    Name = "Garfield",
                    Classification = PetClassification.Mammal,
                    Type = PetType.Cat, 
                    Weight = 20.0
                },
                new PetModel()
                {
                    Name = "Odie",
                    Classification = PetClassification.Mammal,
                    Type = PetType.Dog,
                    Weight = 15.0
                },
                new PetModel()
                {
                    Name = "Peter Parker",
                    Classification = PetClassification.Arachnid,
                    Type = PetType.Spider,
                    Weight = 0.5
                },
                new PetModel()
                {
                    Name = "Kaa",
                    Classification = PetClassification.Reptile,
                    Type = PetType.Snake,
                    Weight = 25.0
                },
                new PetModel()
                {
                    Name = "Nemo",
                    Classification = PetClassification.Fish,
                    Type = PetType.Goldfish,
                    Weight = 0.5
                },
                new PetModel()
                {
                    Name = "Alpha",
                    Classification = PetClassification.Fish,
                    Type = PetType.Betta,
                    Weight = 0.1
                },
                new PetModel()
                {
                    Name = "Splinter",
                    Classification = PetClassification.Mammal,
                    Type = PetType.Rat,
                    Weight = 0.5
                },
                new PetModel()
                {
                    Name = "Coco",
                    Classification = PetClassification.Bird,
                    Type = PetType.Parrot,
                    Weight = 6.0
                },
                new PetModel()
                {
                    Name = "Tweety",
                    Classification = PetClassification.Bird,
                    Type = PetType.Canary,
                    Weight = 0.05
                }
            };

            return (people, pets);
        }
    }
}