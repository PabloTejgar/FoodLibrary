using FoodLibrary.Finder;
using NUnit.Framework;

namespace FoodLibrary.Test
{
    public class ScullionTest
    {
        [Test]

        public void WhenYouProvideHakeThenEveryProductWithHakeIsReturn()
        {
            var scullion = new Scullion();
            var result = scullion.GetRecipes("Merluza");
            Assert.That(result.Name, Is.EqualTo("Merluza con patatas fritas"));
        }

        public void WhenYouProvideAlmondThenEveryProductWithAlmondIsReturn()
        {
            var scullion = new Scullion();
            var result = scullion.GetRecipes("Almendra");
            Assert.That(result.Name, Is.EqualTo("Almendras garrapiñadas"));
        }

    }
}
