using System;
using System.Collections.Generic;

namespace OrderingSystem.Domain
{
    public class Table
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public WpfInfo? WpfInfo { get; set; }
        public List<Item> Items { get; set; }
    }
}