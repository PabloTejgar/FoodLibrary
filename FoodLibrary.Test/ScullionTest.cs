using FoodLibrary.Finder;
using NUnit.Framework;

namespace FoodLibrary.Test
{
    public class ScullionTest
    {
        [TestCase("Merluza", "Merluza con patatas fritas")]
        [TestCase("Salmón", "Salmón con verduras")]
        [TestCase("Almendra", "Almendras garrapiñadas")]
        public void WhenYouProvideIngredientThenEveryProductWithThatIngredientIsReturn(string ingredient, string expected)
        {
            var scullion = new Scullion();
            var result = scullion.GetRecipes(new List<string>{ ingredient});
            Assert.That(result.Name, Is.EqualTo(expected));
        }

        [TestCase("Merluza", "Verduras", "Merluza y verduras con patatas fritas")]
        [TestCase("Salmón", "Verduras", "Salmón con verduras")]
        // [TestCase("Almendra", "Almendras garrapiñadas")]
        public void WhenYouProvideTwoIngredientThenEveryProductWithThoseTwoIngredientIsReturn(string ingredient, string ingredient2, string expected)
        {
            var scullion = new Scullion();
            var result = scullion.GetRecipes(new List<string> { ingredient, ingredient2 });
            Assert.That(result.Name, Is.EqualTo(expected));
        }
    }
}
