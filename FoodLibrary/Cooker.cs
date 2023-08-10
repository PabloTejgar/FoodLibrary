namespace FoodLibrary
{
    public class Cooker
    {
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