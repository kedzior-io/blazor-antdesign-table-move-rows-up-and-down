using AntDesignBlazorTableSortOrder.Models;
using System.Collections.Generic;
using System.Linq;

namespace AntDesignBlazorTableSortOrder.Extensions
{
    public static class ListExtensions
    {
        public static List<Item> Swap(this List<Item> list, int indexA, int indexB)
        {
            var tmp = list[indexA].SortOrder;
            list[indexA].SortOrder = list[indexB].SortOrder;
            list[indexB].SortOrder = tmp;

            return list.OrderBy(x => x.SortOrder).ToList();
        }
    }
}