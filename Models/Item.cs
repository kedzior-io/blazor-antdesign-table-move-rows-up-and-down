using System;
using System.Collections.Generic;

namespace AntDesignBlazorTableSortOrder.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public static List<Item> CreateRandomList()
        {
            var list = new List<Item>
            {
                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Krew elfów",
                    SortOrder = 1
                },

                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Czas pogardy",
                    SortOrder = 2
                },

                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Chrzest ognia",
                    SortOrder = 3
                },

                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Wieża Jaskółki",
                    SortOrder = 4
                },

                new Item
                {
                    Id = Guid.NewGuid(),
                    Name = "Pani Jeziora",
                    SortOrder = 5
                }
            };

            return list;
        }
    }
}