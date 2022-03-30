using System.Collections.Generic;
using OrderingSystem.Domain;
using OrderingSystem.Logic.Json;

namespace OrderingSystem.Logic
{
    public class IngredientLogic : JsonLogic<Ingredient>
    {
        private const string Filename = "ingredients.json";

        private List<Ingredient> _ingredients;
        public List<Ingredient> Ingredients => _ingredients;

        public IngredientLogic()
        {
            _ingredients = Get(Filename);
        }
    }
}