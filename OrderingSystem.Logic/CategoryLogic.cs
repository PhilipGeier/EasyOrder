using System;
using System.Collections.Generic;
using OrderingSystem.Domain;
using OrderingSystem.Logic.Json;

namespace OrderingSystem.Logic
{
    public class CategoryLogic : JsonLogic<Category>
    {
        private const string Filename = "categories.json";
        
        private List<Category> _categories;
        public List<Category> Categories => _categories;

        public CategoryLogic()
        {
            _categories = Get(Filename);
        }

        public void CreateCategory(string name)
        {
            _categories.Add(new Category()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Items = new List<Item>()
            });
            Console.WriteLine($"Category {name} has been created!");
            RefreshCategories();
        }
        
        public void AddItems(List<Item> input, Category category)
        {
            foreach (var item in input)
            {
                category.Items.Add(item);
            }
            RefreshCategories();
        }

        private void RefreshCategories()
        {
            Put(_categories, Filename);
            _categories = Get(Filename);
        }
    }
}