using FoodLibrary.Models;

namespace FoodLibrary
{
    public class Cooker
    {
        private List<Recipe> Recipes { get; set; }

        public Cooker()
        {
            Recipes = new List<Recipe>();
            Recipes.Add(new Recipe { Name = "Huevo con patatas fritas", Ingredients = new List<string> { "Aceite", "Huevo", "Patata" } });
            Recipes.Add(new Recipe { Name = "Patatas fritas", Ingredients = new List<string> { "Aceite", "Patata" } });
            Recipes.Add(new Recipe { Name = "Huevos fritos", Ingredients = new List<string> { "Aceite", "Huevo" } });
            Recipes.Add(new Recipe { Name = "Merluza con patatas fritas", Ingredients = new List<string> { "Merluza", "Patata", "Aceite" } });
        }

        public string Cook(List<string> ingredients)
        {
            if (ingredients.Contains("Aceite"))
            {
                return Fry(ingredients);
            }

            return "Alcachofas";
       }

        private string Fry(List<string> ingredients)
        {
            ingredients.Remove("Aceite");
            if(ingredients.Count == 1)
            {
                return ingredients[0] + "s fritas";
            }
            return "Huevo frito con Patatas fritas";
        }
    }
}