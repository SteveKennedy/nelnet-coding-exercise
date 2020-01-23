﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NelnetProgrammingExercise.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public virtual PetClassification PreferredClassification { get; set; }
        public virtual PetType PreferredType { get; set; }
        public virtual PetWeightCategory PreferredWeightCategory { get; set; }
        public PreferenceOverride PreferenceOverrides { get; set; }
    }
}
