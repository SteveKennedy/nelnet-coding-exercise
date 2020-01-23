using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise.Extensions
{
    public static class PetWeightCategoryExtension
    {
        public static PetWeightCategory GetWeightCategory(this PetModel pet)
        {
            if (pet.Weight > 30.0) return PetWeightCategory.ExtraLarge;
            if (pet.Weight > 15.0) return PetWeightCategory.Large;
            if (pet.Weight > 5.0) return PetWeightCategory.Medium;
            if (pet.Weight > 1.0) return PetWeightCategory.Small;
            return PetWeightCategory.ExtraSmall;
        }
    }
}
