using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

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
    }
}