﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OrderingSystem.Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}  