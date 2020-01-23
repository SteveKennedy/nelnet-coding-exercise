using Microsoft.VisualStudio.TestTools.UnitTesting;
using NelnetProgrammingExercise.Extensions;

namespace NelnetProgrammingExercise.Test.Extensions
{
    [TestClass()]
    public class PetsArrayExtensionTests
    {
        [TestMethod()]
        public void OrderByPreferenceForPersonTest_ArrayLengthStaysConsistent()
        {
            // Arrange
            var objects = InitializationManager.SetupObjects();
            var pets = objects.Pets;
            var person = objects.People[0];

            // Act
            var orderedPets = pets.OrderByPreferenceForPerson(person);

            // Assert
            Assert.AreEqual(pets.Length, orderedPets.Length);
        }

        [TestMethod()]
        public void OrderByPreferenceForPersonTest()
        {
            // Arrange
            var objects = InitializationManager.SetupObjects();
            var pets = objects.Pets;
            var person = objects.People[0];

            // Act
            var orderedPets = pets.OrderByPreferenceForPerson(person);

            // Assert
            Assert.AreEqual(pets.Length, orderedPets.Length);
            Assert.AreEqual("Kaa", orderedPets[0].Name);
            Assert.AreEqual(person.PreferredType, orderedPets[0].Type);
        }
    }
}