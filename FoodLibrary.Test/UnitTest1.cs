using NUnit.Framework;

namespace FoodLibrary.Test
{
    public class Tests
    {

        private Recommender Recommender { get; set; }

        [SetUp]
        public void Setup()
        {
            Recommender = new Recommender();
        }

        [Test]
        public void RecommenderReportAValidRecipe()
        {
            var result = Recommender.Suggest("Alcachofa");
            Assert.That(result.Contains("Alcachofas Fritas"));
        }


    }
}