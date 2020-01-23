using NelnetProgrammingExercise.Extensions;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise
{
    public class MatchManager
    {
        public static bool IsGood(PersonModel person, PetModel pet)
        {
            var isGoodMatch = person.PreferredClassification == pet.Classification || person.PreferredType == pet.Type || person.PreferredWeightCategory == pet.GetWeightCategory();

            if (isGoodMatch)
            {
                isGoodMatch = !HasOverrideException(person, pet);
            }

            return isGoodMatch;
        }

        private static bool HasOverrideException(PersonModel person, PetModel pet)
        {
            // Check for any overrides. If None, Return early.
            if (person.PreferenceOverrides == null)
            {
                return false;
            }

            // Check for Classification overrides.
            var overrideClassifications = person.PreferenceOverrides.OverrideClassifications;
            if (overrideClassifications != null && overrideClassifications.Contains(pet.Classification))
            {
                return true;
            }

            // Check for Preference overrides.
            var overrideTypes = person.PreferenceOverrides.OverrideTypes;
            if (overrideTypes != null && overrideTypes.Contains(pet.Type))
            {
                return true;
            }

            // Check for Weight overrides.
            var overridesPreferredWeightCategories = person.PreferenceOverrides.OverrideWeightCategories;
            if (overridesPreferredWeightCategories != null && overridesPreferredWeightCategories.Contains(pet.GetWeightCategory()))
            {
                return true;
            }

            // Else, there are no overrides.
            return false;
        }
    }
}