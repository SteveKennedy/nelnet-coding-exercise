using Microsoft.VisualStudio.TestTools.UnitTesting;
using NelnetProgrammingExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NelnetProgrammingExercise.Extensions;

namespace NelnetProgrammingExercise.Models.Tests
{
    [TestClass]
    public class PetWeightCategoryExtensionTests
    {
        [TestMethod]
        public void GetWeightCategoryTest_25Weight_ShouldBeLarge()
        {
            // Arrange
            var pet = new PetModel
            {
                Weight = 25.0
            };

            // Act
            var weightCategory = pet.GetWeightCategory();

            // Assert
            Assert.AreEqual(PetWeightCategory.Large, weightCategory);
        }

        [TestMethod]
        public void GetWeightCategoryTest_15Weight_ShouldBeMedium()
        {
            // Arrange
            var pet = new PetModel
            {
                Weight = 15.0
            };

            // Act
            var weightCategory = pet.GetWeightCategory();

            // Assert
            Assert.AreEqual(PetWeightCategory.Medium, weightCategory);
        }

        [TestMethod]
        public void GetWeightCategoryTest_HalfWeight_ShouldBeExtraSmall()
        {
            // Arrange
            var pet = new PetModel
            {
                Weight = 0.5
            };

            // Act
            var weightCategory = pet.GetWeightCategory();

            // Assert
            Assert.AreEqual(PetWeightCategory.ExtraSmall, weightCategory);
        }
    }
}