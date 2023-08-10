using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Test
{
    public class CookerTest
    {
        private Cooker Cooker { get; set; }

        [SetUp]
        public void Setup()
        {
            Cooker = new Cooker();

        }

        [Test]
        public void ReturnARecipeWithOneIngredient()
        {
            var result = Cooker.Cook(new List<string> { "Alcachofa" });
            Assert.That(result, Is.EqualTo("Alcachofas"));
        }

        [TestCase("Patata", "Patatas fritas")]
        [TestCase("Alcachofa", "Alcachofas fritas")]
        [TestCase("Merluza", "Merluzas fritas")]

        public void ReturnARecipeWithOilAndAnotherIngredient(string ingredient, string expected)
        {

            var result = Cooker.Cook(new List<string> { ingredient, "Aceite" });
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("Patata", "Huevo", "Huevo frito con Patatas fritas")]
        public void ReturnARecipeWithOilAndAnotherTwoIngredients(string ingredient, string ingredient2, string expected)
        {
            var result = Cooker.Cook(new List<string> { ingredient, ingredient2, "Aceite" });
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
