using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace AbstractFactory
{
    public abstract class IinputReader
    {
        public abstract List<FoodItemInfo> readFile2(string filetext, string country);
    }

    public class xmlRead : IinputReader
    {
        public override List<FoodItemInfo> readFile2(string file, string country)
        {
            var returnDict = new Dictionary<string, string>();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(file);

            FoodItemDataList resultList = new FoodItemDataList();
            resultList.foodItems = new List<FoodItemInfo>();

            XmlNodeList fooditemList;

            if (country == "British")
            {
                fooditemList = xmldoc.SelectNodes("FoodItemData/FoodItem[@country='GB']");
            }
            else
            {
                fooditemList = xmldoc.SelectNodes("FoodItemData/FoodItem[@country='US']");
            }

            foreach (XmlNode foodItem in fooditemList)
            {
                if (foodItem.HasChildNodes)
                {
                    var item = new FoodItemInfo();
                    foreach (XmlNode foodinfo in foodItem)
                    {
                        if (foodinfo.Name == "country")
                        {
                            item.country = foodinfo.InnerText;
                        }

                        if (foodinfo.Name == "category")
                        {
                            item.category = foodinfo.InnerText;
                        }

                        if (foodinfo.Name == "name")
                        {
                            item.name = foodinfo.InnerText;
                        }

                        if (foodinfo.Name == "price")
                        {
                            item.price = foodinfo.InnerText;
                        }


                        if (foodinfo.Name == "description")
                        {
                            item.description = foodinfo.InnerText;
                        }

                    }

                    resultList.foodItems.Add(item);
                }
            }

            return resultList.foodItems;
        }
    }

    public class jsonRead : IinputReader
    {
        public override List<FoodItemInfo> readFile2(string filetext, string country)
        {
            StringBuilder dinnerlist = new StringBuilder();
            StringBuilder lunchlist = new StringBuilder();
            StringBuilder breakfastlist = new StringBuilder();
            StringBuilder snacklist = new StringBuilder();
            StringBuilder appetizerlist = new StringBuilder();
            StringBuilder dessertlist = new StringBuilder();
            StringBuilder sidelist = new StringBuilder();
            string countrySelection = string.Empty;

            if (country == "British")
            {
                countrySelection = "GB";
            }
            else
            {
                countrySelection = "US";
            }

            var returnDict = new Dictionary<string, string>();

            StringBuilder restaurantNames = new StringBuilder();

            var deserializedFoodItems = JsonConvert.DeserializeObject<FoodItemDataList>(filetext);

            return deserializedFoodItems.foodItems.Where(f => f.country == countrySelection).ToList();
        }
    }


    public class FoodItemDataList
    {
        [JsonProperty("FoodItemData")]
        public List<FoodItemInfo> foodItems { get; set; }
    }

    public class FoodItemInfo
    {
        [JsonProperty("-country")]
        public  string country { get; set; }

        [JsonProperty("id")]
        public  string id { get; set; }

        [JsonProperty("name")]
        public  string name { get; set; }

        [JsonProperty("description")]
        public  string description { get; set; }

        [JsonProperty("category")]
        public  string category { get; set; }

        [JsonProperty("price")]
        public  string price { get; set; }
    }

}
