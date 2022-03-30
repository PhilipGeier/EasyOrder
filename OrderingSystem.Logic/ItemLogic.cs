using System;
using System.Collections.Generic;
using OrderingSystem.Domain;
using OrderingSystem.Logic.Json;


namespace OrderingSystem.Logic
{
    public class ItemLogic : JsonLogic<Item>
    {
        private const string Filename = "items.json";

        private List<Item> _items;
        public List<Item> Items => _items;

        public ItemLogic()
        {
            _items = Get(Filename);
        }

        public void CreateItem(string name, float price, string description)
        {
            _items.Add(new Item()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Price = price,
                Description = description,
                Ingredients = new List<Ingredient>()
            });
            RefreshItems();
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
            RefreshItems();
        }

        public void AddIngredients(List<Ingredient> input, Item item)
        {
            foreach (var ingredient in input)
            {
                item.Ingredients.Add(ingredient);
            }
            RefreshItems();
        }
        
        private void RefreshItems()
        {
            Put(_items, Filename);
            _items = Get(Filename);
        }
    }
}