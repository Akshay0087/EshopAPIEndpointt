using EshopAPIEndpoint.specs.Model;
using Newtonsoft.Json;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class PostItemCatalogToJson
    {
        public static string CatalogItemObjectToJson(CatalogItem catalogItem)
        {
            
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
                    
                }
            

            return JsonConvert.SerializeObject(postItem);
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
