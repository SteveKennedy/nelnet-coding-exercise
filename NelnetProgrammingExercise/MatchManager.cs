using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise
{
    public class MatchManager
    {
        public static bool IsGood(PersonModel person, PetModel pet)
        {
            return person.PreferredClassification == pet.Classification || person.PreferredType == pet.Type;
        }
    }
}