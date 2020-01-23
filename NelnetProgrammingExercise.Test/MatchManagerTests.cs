using Microsoft.VisualStudio.TestTools.UnitTesting;
using NelnetProgrammingExercise;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using NelnetProgrammingExercise.Models;

namespace NelnetProgrammingExercise.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class MatchManagerTests
    {
        [TestMethod()]
        public void IsGoodTest_BadTypeAndBadClassificationMatch_FishNotDog_IsBadMatch()
        {
            // Arrange
            var person = new PersonModel
            {
                Name = "Steve",
                PreferredClassification = PetClassification.Mammal,
                PreferredType = PetType.Dog
            };

            var pet = new PetModel
            {
                Name = "Nemo",
                Classification = PetClassification.Fish,
                Type = PetType.Goldfish
            };
            
            // Act
            var matchResultIsGood = MatchManager.IsGood(person, pet);

            // Assert
            Assert.IsFalse(matchResultIsGood);
        }

        [TestMethod()]
        public void IsGoodTest_BadTypeButNotBadClassificationMatch_CatNotDogIsGoodMatch()
        {
            // Arrange
            var person = new PersonModel
            {
                Name = "Steve",
                PreferredClassification = PetClassification.Mammal,
                PreferredType = PetType.Dog
            };

            var pet = new PetModel
            {
                Name = "Fluffy",
                Classification = PetClassification.Mammal,
                Type = PetType.Cat
            };

            // Act
            var matchResultIsGood = MatchManager.IsGood(person, pet);

            // Assert
            Assert.IsTrue(matchResultIsGood);
        }
    }
}