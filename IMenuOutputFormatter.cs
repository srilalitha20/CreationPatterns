using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace AbstractFactory
{
    public abstract class IMenuOutputFormatter
    {
        public abstract string formatText(List<FoodItemInfo> menu);
    }

    public class clsOutputFormatterPlainText : IMenuOutputFormatter
    {
        public override string formatText(List<FoodItemInfo> menu)
        {
            var formattedItemList = new List<FormattedFoodItemInfo>();

            bool firstDinner = false;
            bool firstBreakfast = false;
            bool firstLunch = false;
            bool firstAppetizer = false;
            bool firstSnack = false;
            bool firstSide = false;
            bool firstDessert = false;

            foreach (var item in menu)
            {
                var formattedItem = new FormattedFoodItemInfo();

                if (item.category.ToLower() == "dinner" && firstDinner == false)
                {
                    firstDinner = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "lunch" && firstLunch == false)
                {
                    firstLunch = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "appetizer" && firstAppetizer == false)
                {
                    firstAppetizer = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "dessert" && firstDessert == false)
                {
                    firstDessert = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "snack" && firstSnack == false)
                {
                    firstSnack = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "breakfast" && firstBreakfast == false)
                {
                    firstBreakfast = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else if (item.category.ToLower() == "side dish" && firstSide == false)
                {
                    firstSide = true;
                    SetCategoryFormatting(formattedItem, item);
                }
                else
                {
                    formattedItem.category = item.category;
                }
                
                formattedItem.name = item.name;
                formattedItem.price = item.price;
                formattedItem.description = item.description;

                formattedItem.name_afterFormat = string.Empty.PadRight(75 - formattedItem.name.Length, ' ');

                if (item.country == "GB")
                {
                    formattedItem.price_beforeFormat = "GBP";
                }

                if (item.country == "US")
                {
                    formattedItem.price_beforeFormat = "USD";
                }

                formattedItem.price_afterFormat = "\n";
                formattedItem.description_afterFormat = "\n\n";

                formattedItemList.Add(formattedItem);
            }

            /****************************************/
            /****** Creating the String Output ******/
            /****************************************/
            var outputStringBuilder = new StringBuilder();

            AddToStringBuilder(outputStringBuilder, formattedItemList);

            return outputStringBuilder.ToString();
        }

        private void AddToStringBuilder(StringBuilder menuList, List<FormattedFoodItemInfo> menuFile)
        {
            menuList.Append("Menu");
            menuList.Append("\n\n");

            foreach (var item in menuFile)
            {
                if (item.category_beforeFormat == "UPPER")
                {
                    menuList.Append(item.category);
                    menuList.Append("\n\n");
                }

                menuList.Append(item.name_beforeFormat);
                menuList.Append(item.name);
                menuList.Append(item.name_afterFormat);

                menuList.Append(item.price_beforeFormat);
                menuList.Append(item.price);
                menuList.Append(item.price_afterFormat);

                menuList.Append(item.description_beforeFormat);
                menuList.Append(item.description);
                menuList.Append(item.description_afterFormat);
            }
        }

        private void SetCategoryFormatting( FormattedFoodItemInfo formattedItem, FoodItemInfo item)
        {
            formattedItem.category_beforeFormat = "UPPER";
            formattedItem.category = item.category.ToUpper();   
        }
    }

    public class clsMenuOutputFormatterHtml : IMenuOutputFormatter
    {
        public override string formatText(List<FoodItemInfo> menu)
        {
            var formattedItemList = new List<FormattedFoodItemInfo>();
            StringBuilder htmlformatting = new StringBuilder();

            htmlformatting.Append("<!DOCTYPE html>");
            htmlformatting.Append("\n");
            htmlformatting.Append("<html>");
            htmlformatting.Append("\n");
            htmlformatting.Append("<head>");
            htmlformatting.Append("\n");
            htmlformatting.Append("<title>Menu</title>");
            htmlformatting.Append("\n");
            htmlformatting.Append("</head>");
            htmlformatting.Append("\n");
            htmlformatting.Append("<body><CENTER>Menu</CENTER>");
            htmlformatting.Append("\n");

            FormattedFoodItemInfo headfoodItem = new FormattedFoodItemInfo();
            headfoodItem.list_beforeformat = htmlformatting.ToString();
            formattedItemList.Add(headfoodItem);

            var dinnerItemCount = menu.Where(m => m.category.ToLower() == "dinner").Count();
            var breakfastItemCount = menu.Where(m => m.category.ToLower() == "breakfast").Count();
            var appetizerItemCount = menu.Where(m => m.category.ToLower() == "appetizer").Count();
            var snackItemCount = menu.Where(m => m.category.ToLower() == "snack").Count();
            var sideItemCount = menu.Where(m => m.category.ToLower() == "side dish").Count();
            var lunchItemCount = menu.Where(m => m.category.ToLower() == "lunch").Count();
            var dessertItemCount = menu.Where(m => m.category.ToLower() == "dessert").Count();

            int dinnerCount = 0;
            int breakfastCount = 0;
            int lunchCount = 0;
            int appetizerCount = 0;
            int snackCount = 0;
            int sideCount = 0;
            int dessertCount = 0;

            foreach (var item in menu)
            {
                var formattedItem = new FormattedFoodItemInfo();

                formattedItem.name = item.name;
                formattedItem.description_beforeFormat = "<i>";
                formattedItem.description = item.description;
                formattedItem.description_afterFormat = "</i><br>";
                formattedItem.price = item.price;
                formattedItem.category = item.category.ToUpper();

                if (formattedItem.category.ToLower() == "dinner")
                {
                    SetCategoryFormatting(dinnerCount, formattedItem);
                    formatList(dinnerItemCount, ref dinnerCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "lunch")
                {
                    SetCategoryFormatting(lunchCount, formattedItem);
                    formatList(lunchItemCount, ref lunchCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "appetizer")
                {
                    SetCategoryFormatting(appetizerCount, formattedItem);
                    formatList(appetizerItemCount, ref appetizerCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "dessert")
                {
                    SetCategoryFormatting(dessertCount, formattedItem);
                    formatList(dessertItemCount, ref dessertCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "snack")
                {
                    SetCategoryFormatting(snackCount, formattedItem);
                    formatList(snackItemCount, ref snackCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "breakfast")
                {
                    SetCategoryFormatting(breakfastCount, formattedItem);
                    formatList(breakfastItemCount, ref breakfastCount, formattedItem);
                }
                if (formattedItem.category.ToLower() == "side dish")
                {
                    SetCategoryFormatting(sideCount, formattedItem);
                    formatList(sideItemCount, ref sideCount, formattedItem);
                }

                formattedItemList.Add(formattedItem);
    
            }

             StringBuilder endofHtml = new StringBuilder();
             endofHtml.Append("</body>");
             endofHtml.Append("\n");
             endofHtml.Append("</html>");

             FormattedFoodItemInfo endfoodItem = new FormattedFoodItemInfo();
             endfoodItem.list_afterformat = endofHtml.ToString();
             formattedItemList.Add(endfoodItem);


             /****************************************/
             /****** Creating the String Output ******/
             /****************************************/
             var outputStringBuilder = new StringBuilder();

             if (!string.IsNullOrEmpty(formattedItemList[0].list_beforeformat))
             {
                 outputStringBuilder.Append(formattedItemList[0].list_beforeformat);
             }

             AddToStringBuilder(outputStringBuilder, formattedItemList);

             var endFoodItem = formattedItemList.Where(m => m.list_afterformat != null).ToList();
             if (!string.IsNullOrEmpty(endFoodItem[0].list_afterformat))
             {
                 outputStringBuilder.Append(endFoodItem[0].list_afterformat);
             }

             return outputStringBuilder.ToString();
        }

        private void formatList(int itemCount,ref int count, FormattedFoodItemInfo formattedItem)
        {
            if (itemCount == 1)
            {
                formattedItem.name_beforeFormat = "<ul><li>";
                formattedItem.name_afterFormat = "</li>\n";
                formattedItem.price_afterFormat = "</ul>\n";

                return;
            }

            if (count == 0)
            {
                
                formattedItem.name_beforeFormat = "<ul><li>";
                formattedItem.name_afterFormat = "</li>\n";
                formattedItem.price_afterFormat = "</ul>\n";
            }
            else if (itemCount == count + 1)
            {
               
                formattedItem.name_beforeFormat = "<ul><li>";
                formattedItem.name_afterFormat = "</li>\n";
                formattedItem.price_afterFormat = "</ul>\n";
            }
            else
            {
                formattedItem.name_beforeFormat = "<ul><li>";
                formattedItem.name_afterFormat = "</li>\n";
                formattedItem.price_afterFormat = "</ul>\n";
            }

            count++;
        }

        private void SetCategoryFormatting(int count, FormattedFoodItemInfo formattedItem)
        {
            if (count == 0)
            {
                formattedItem.category_beforeFormat = "<h1>";
                formattedItem.category_afterFormat = "</h1>";
            }
        }

        private void AddToStringBuilder(StringBuilder menuList, List<FormattedFoodItemInfo> menuFile)
        {
          
            foreach (var item in menuFile.Where(m => m.list_afterformat == null && m.list_beforeformat == null))
            {

                if (!string.IsNullOrEmpty(item.category_beforeFormat) && !string.IsNullOrEmpty(item.category_afterFormat))
                {
                    menuList.Append(item.category_beforeFormat);
                    menuList.Append(item.category);
                    menuList.Append(item.category_afterFormat);
                }

                menuList.Append(item.name_beforeFormat);
                menuList.Append(item.name);
                menuList.Append(item.name_afterFormat);

                menuList.Append(item.description_beforeFormat);
                menuList.Append(item.description);
                menuList.Append(item.description_afterFormat);

                menuList.Append(item.price_beforeFormat);
                menuList.Append(item.price);
                menuList.Append(item.price_afterFormat);
            }
        }
    }

    public class clsMenuOutputFormatterXml : IMenuOutputFormatter
    {
        public override string formatText(List<FoodItemInfo> menu)
        {
            var formattedItemList = new List<FormattedFoodItemInfo>();
            XmlDocument xmlmenu = new XmlDocument();

            XmlDeclaration xmldeclaration = xmlmenu.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlNode root = xmlmenu.CreateElement("MenuItems");
            xmlmenu.AppendChild(root);
            xmlmenu.InsertBefore(xmldeclaration, root);

            bool firstDinner = false;
            bool firstBreakfast = false;
            bool firstLunch = false;
            bool firstAppetizer = false;
            bool firstSnack = false;
            bool firstSide = false;
            bool firstDessert = false;
            XmlNode previousCategory = null;

            foreach (var item in menu)
            {
                XmlNode currentCategory = null;

                if (item.category.ToLower() == "dinner" && firstDinner == false)
                {
                    firstDinner = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "lunch" && firstLunch == false)
                {
                    firstLunch = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "appetizer" && firstAppetizer == false)
                {
                    firstAppetizer = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "dessert" && firstDessert == false)
                {
                    firstDessert = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "snack" && firstSnack == false)
                {
                    firstSnack = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "breakfast" && firstBreakfast == false)
                {
                    firstBreakfast = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else if (item.category.ToLower() == "side dish" && firstSide == false)
                {
                    firstSide = true;
                    currentCategory = SetCategoryFormatting(xmlmenu, item);
                }
                else
                {
                    currentCategory = previousCategory;
                }

                XmlNode menuItemnode = xmlmenu.CreateElement("MenuItem");
                currentCategory.AppendChild(menuItemnode);

                    XmlNode nameNode = xmlmenu.CreateElement("Name");
                    nameNode.InnerText = item.name;
                    menuItemnode.AppendChild(nameNode);

                    XmlNode priceNode = xmlmenu.CreateElement("Price");
                    priceNode.InnerText = item.price;
                    menuItemnode.AppendChild(priceNode);

                    XmlNode descriptionNode = xmlmenu.CreateElement("Description");
                    descriptionNode.InnerText = item.description;
                    menuItemnode.AppendChild(descriptionNode);

                previousCategory = currentCategory;
            }

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            xmlmenu.WriteTo(tx);

            string str = sw.ToString();
            return str;
        }

        private XmlNode SetCategoryFormatting(XmlDocument xmlmenu, FoodItemInfo item)
        {
            XmlNode categoryNode = xmlmenu.CreateElement("MenuCategory");
            XmlAttribute categoryAttribute = xmlmenu.CreateAttribute("category");
            categoryAttribute.Value = item.category.ToUpper();
            categoryNode.Attributes.Append(categoryAttribute);
            xmlmenu.DocumentElement.AppendChild(categoryNode);

            return categoryNode;
        }
    }

    public class FormattedFoodItemInfo
    {
        public string country { get; set; }
        public string id { get; set; }
        public  string name { get; set; }
        public  string description { get; set; }
        public  string category { get; set; }
        public  string price { get; set; }

        public  string id_beforeFormat { get; set; }
        public  string id_afterFormat { get; set; }

        public  string name_beforeFormat { get; set; }
        public  string name_afterFormat { get; set; }

        public  string description_beforeFormat { get; set; }
        public  string description_afterFormat { get; set; }

        public  string category_beforeFormat { get; set; }
        public  string category_afterFormat { get; set; }

        public  string price_beforeFormat { get; set; }
        public  string price_afterFormat { get; set; }

        public string list_beforeformat { get; set; }
        public string list_afterformat { get; set; }
    }
}

