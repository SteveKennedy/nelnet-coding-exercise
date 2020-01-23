using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NelnetProgrammingExercise.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class InitializationManagerTests
    {
        [TestMethod]
        public void SetupObjectsTest_ReturnsSpecificPetValues()
        {
            // Act
            var objects = InitializationManager.SetupObjects();

            //Assert
            Assert.AreEqual(9, objects.Pets.Length);
            Assert.AreEqual("Garfield", objects.Pets[0].Name);
        }

        [TestMethod]
        public void SetupObjectsTest_ReturnsSpecificPeopleValues()
        {
            // Act
            var objects = InitializationManager.SetupObjects();

            //Assert
            Assert.AreEqual(2, objects.People.Length);
            Assert.AreEqual("Dalinar", objects.People[0].Name);
        }

        [TestMethod]
        public void SetupObjectsTest_ShouldReturnPetWeightForKaa()
        {
            // Act
            var objects = InitializationManager.SetupObjects();
            var kaaWeight = objects.Pets.Single(p => p.Name == "Kaa").Weight;

            // Assert
            Assert.AreEqual(25.0, kaaWeight);
        }

        [TestMethod]
        public void SetupObjectsTest_ShouldNotReturnWeight_ForUnknownPet()
        {
            // Act
            var objects = InitializationManager.SetupObjects();
            
            // Assert
            Assert.ThrowsException<InvalidOperationException>(() => objects.Pets.Single(p => p.Name == "fakepetname"));
        }
    }
}