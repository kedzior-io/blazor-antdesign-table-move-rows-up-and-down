using AntDesignBlazorTableSortOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AntDesignBlazorTableSortOrder.Extensions;

namespace AntDesignBlazorTableSortOrder.Pages
{
    public partial class Index
    {
        public List<Item> Items { get; set; }

        protected override void OnInitialized()
        {
            Items = Item.CreateRandomList();
        }

        private void SortUp(Guid id)
        {
            var itemToUpdate = Items.Single(x => x.Id == id);
            var index = Items.IndexOf(itemToUpdate);

            if (index == 0)
            {
                return;
            }

            var newIndex = index - 1;

            Items = SwapSortOrders(Items, index, newIndex);

            // This won't work
            //Items.SwapSortOrders(index, newIndex);
        }

        private void SortDown(Guid id)
        {
            var itemToUpdate = Items.Single(x => x.Id == id);
            var index = Items.IndexOf(itemToUpdate);

            if (index == Items.Count - 1)
            {
                return;
            }

            var newIndex = index + 1;

            Items = SwapSortOrders(Items, index, newIndex);

            // This won't work
            //Items.Swap(index, newIndex);
        }

        public static List<Item> SwapSortOrders(List<Item> list, int indexA, int indexB)
        {
            var tmp = list[indexA].SortOrder;
            list[indexA].SortOrder = list[indexB].SortOrder;
            list[indexB].SortOrder = tmp;

            return list.OrderBy(x => x.SortOrder).ToList();
        }
    }
}