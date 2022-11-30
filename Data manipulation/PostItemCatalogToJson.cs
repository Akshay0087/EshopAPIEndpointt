using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class PostItemCatalogToJson
    {
        public static string CatalogItemObjectToJson(CatalogItem catalogItem)
        {
            string jsonObj="";
            postObject postItem = new postObject();
            if (!(catalogItem.CatalogTypeId == 0 || catalogItem.CatalogBrandId == 0))
                {

                postItem.catalogBrandId = catalogItem.CatalogBrandId;
                postItem.catalogTypeId = catalogItem.CatalogTypeId;
                postItem.description = catalogItem.Description;
                postItem.name = catalogItem.Name;
                postItem.pictureUri = catalogItem.PictureUri;
                postItem.pictureBase64 = catalogItem.PictureBase64;
                postItem.pictureName = catalogItem.PictureName;
                postItem.price = catalogItem.Price;

                jsonObj= JsonConvert.SerializeObject(postItem);
                if (!(catalogItem.Id == null))
                {
                    var jObj = JObject.Parse(jsonObj);
                    
                        jObj["id"] = catalogItem.Id;

                    jsonObj = jObj.ToString(Newtonsoft.Json.Formatting.Indented);
                }
                }


            return jsonObj;
        }
    }
    public class postObject
    {
        public int catalogBrandId;
        public int catalogTypeId;
        public string description;
        public string name;
        public string pictureUri;
        public string pictureBase64;
        public string pictureName;
        public decimal price;
    }
}
