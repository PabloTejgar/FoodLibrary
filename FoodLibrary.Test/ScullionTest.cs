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
            var result = scullion.GetRecipes(new List<string> { ingredient });
            Assert.That(result.First().Name, Is.EqualTo(expected));
        }

        [Test]
        public void WhenYouProvideAnIngredientThenAListOfRecipesWithThatIngredientAreReturn()
        {
            var scullion = new Scullion();

            string ingredient = "Verduras";
            List<string> expected = new List<string> { "Salmón con verduras", "Merluza y verduras con patatas fritas" };
            var recipes = scullion.GetRecipes(new List<string> { ingredient});
            var result = recipes.Select(recipe => recipe.Name);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("Merluza", "Verduras", "Merluza y verduras con patatas fritas")]
        [TestCase("Salmón", "Verduras", "Salmón con verduras")]
        // [TestCase("Almendra", "Almendras garrapiñadas")]
        public void WhenYouProvideTwoIngredientThenEveryProductWithThoseTwoIngredientIsReturn(string ingredient, string ingredient2, string expected)
        {
            var scullion = new Scullion();
            var result = scullion.GetRecipes(new List<string> { ingredient, ingredient2 });
            Assert.That(result.First().Name, Is.EqualTo(expected));
        }
    }
}
