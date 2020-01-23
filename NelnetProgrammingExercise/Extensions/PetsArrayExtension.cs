using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise.Extensions
{
    public static class PetsArrayExtension
    {
        /// <summary>
        /// Reorder list in ascending order of pet preference. This will be useful when it's output to the console.
        /// </summary>
        /// <param name="pets"></param>
        /// <param name="person"></param>
        /// <returns></returns>
        public static PetModel[] OrderByPreferenceForPerson(this PetModel[] pets, PersonModel person)
        {
            // Copy The Pets Array, As To Not Mess With Original Values
            var originalPets = new List<PetModel>();
            originalPets.AddRange(pets);

            // This is the Ordered List to Return. Start adding to it.
            var orderedPets = new List<PetModel>();

            // First, Add Those Matched on Type
            var typeMatches = originalPets.Where(p => p.Type == person.PreferredType).ToList();
            orderedPets.AddRange(typeMatches);
            originalPets = originalPets.Except(typeMatches).ToList();

            // Next, Add Those Matched on Classification
            var classificationMatches = originalPets.Where(p => p.Classification == person.PreferredClassification).ToList();
            orderedPets.AddRange(classificationMatches);
            originalPets = originalPets.Except(classificationMatches).ToList();

            // Next, Add Those Matched on Weight
            var weightMatches = originalPets.Where(p => p.GetWeightCategory() == person.PreferredWeightCategory).ToList();
            orderedPets.AddRange(weightMatches);
            originalPets = originalPets.Except(weightMatches).ToList();

            // Add the rest from the Default Order
            orderedPets.AddRange(originalPets);

            return orderedPets.ToArray();
        }
    }
}
