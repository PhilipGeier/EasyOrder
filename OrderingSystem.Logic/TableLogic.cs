using System;
using System.Collections.Generic;
using System.Linq;
using OrderingSystem.Domain;
using OrderingSystem.Logic.Json;

namespace OrderingSystem.Logic
{
    public class TableLogic : JsonLogic<Table>
    {
        private const string Filename = "tables.json";
        
        private List<Table> _tables;
        public List<Table> Tables => _tables;

        public TableLogic()
        {
            _tables = Get(Filename);
        }
        
        public void CreateTable(string label, WpfInfo? wpfInfo)
        {
            _tables.Add(new Table()
            {
                Id = Guid.NewGuid(),
                Label = label,
                WpfInfo = wpfInfo,
                Items = new List<Item>()
            });
            Console.WriteLine($"Table {label} has been created!");
            RefreshTables();
        }

        public void AddItems(List<Item> input, Table table)
        {
            foreach (var item in input)
            {
                table.Items.Add(item);
            }
            RefreshTables();
        }
        
        public List<Table> GetTablesWithContent()
        {
            var returnList = new List<Table>();

            foreach (var table in _tables)
            {
                if (table.Items == null || table.Items.Count != 0)
                {
                    returnList.Add(table);
                }
            }
            Console.WriteLine($"{returnList.Count} tables with content have been found");
            RefreshTables();
            return returnList;
        }

        public void RemoveTable(Table table)
        {
            if (table.Items.Count != 0)
            {
                _tables.Remove(table);
                RefreshTables();
            }
            else
            {
                Console.WriteLine("Table couldn't be deleted! There still are items on it!");
            }
        }
        
        private void RefreshTables()
        {
            Put(_tables, Filename);
            _tables = Get(Filename);
        }
    }
}