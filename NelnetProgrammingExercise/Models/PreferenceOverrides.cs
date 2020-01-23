using System.Collections.Generic;

namespace NelnetProgrammingExercise.Models
{
    public class PreferenceOverride
    {
        public List<PetClassification> OverrideClassifications { get; set; }
        public List<PetType> OverrideTypes { get; set; }
        public List<PetWeightCategory> OverrideWeightCategories { get; set; }
    }
}