using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class IMenuGenerator
    {
       public abstract List<FoodItemInfo> generateMenu(List<FoodItemInfo> menuFile, string restType);
    }

    public class clsMenuGenerator : IMenuGenerator
    {
        public override List<FoodItemInfo> generateMenu(List<FoodItemInfo> menuFile, string restType)
        {
            StringBuilder menuList = new StringBuilder();

            var result = new List<FoodItemInfo>();
            var orderedMenuFile = menuFile.OrderBy(f => f.category).ThenBy(f => f.name).ToList();

            if (restType == "Diner")
            {

                result.AddRange(AddToStringBuilder2(orderedMenuFile, "breakfast"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "snack"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "appetizer"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "lunch"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "dessert"));
            }
            else if (restType == "All")
            {

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "breakfast"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "snack"));

                result.AddRange(AddToStringBuilder2( orderedMenuFile, "appetizer"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "lunch"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "dinner"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "dessert"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "side dish"));

            }
            else if (restType == "Evening")
            {

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "appetizer"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "dinner"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "dessert"));

                result.AddRange(AddToStringBuilder2(  orderedMenuFile, "side dish"));

            }

            return result;
        }

        private List<FoodItemInfo> AddToStringBuilder2( List<FoodItemInfo> menuFile, string category)
        {
            return menuFile.Where(m => m.category != null && m.category.ToLower() == category).ToList();
        }
    }
}
