using FoodLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary.Finder
{

    public class Scullion
    {
        private List<Recipe> Recipes { get; set; }

        public Scullion()
        {
            Recipes = new List<Recipe>();
            Recipes.Add(new Recipe { 
                Name = "Huevo frito con patatas fritas", 
                Ingredients = new List<string> { "Aceite", "Huevo", "Patata" } 
            });
            Recipes.Add(new Recipe { 
                Name = "Patatas fritas", 
                Ingredients = new List<string> { "Aceite", "Patata" } 
            });
            Recipes.Add(new Recipe { 
                Name = "Huevos fritos", 
                Ingredients = new List<string> { "Aceite", "Merluza" } 
            });
            Recipes.Add(new Recipe { 
                Name = "Merluza con patatas fritas", 
                Ingredients = new List<string> { "Merluza", "Patata", "Aceite" } 
            });
            Recipes.Add(new Recipe
            {
                Name = "Almendras garrapiñadas",
                Ingredients = new List<string> { "Almendra", "Azucar" }
            });
            Recipes.Add(new Recipe
            {
                Name = "Salmón con verduras",
                Ingredients = new List<string> { "Salmón", "Verduras", "Aceite" }
            });
        }

        public Recipe GetRecipes(string ingredient)
        {
            if(ingredient == "Almendra")
            {
                return Recipes[4];
            }
            if(ingredient == "Salmón")
            {
                return Recipes[5];
            }
            return Recipes[3];
        }
    }
}
