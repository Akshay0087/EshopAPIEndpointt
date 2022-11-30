using EshopAPIEndpoint.specs.Model;
using System;
using TechTalk.SpecFlow;

namespace EshopAPIEndpoint.specs.Data_manipulation
{
    public static class TableToCatalogItemModel
    {
        public static CatalogItem TableToCatalogItemConversion(Table catalogItem)
        {
            CatalogItem catalogItemModel = new CatalogItem();
            catalogItemModel.CatalogBrandId = Convert.ToInt32(catalogItem.Rows[0]["catalogBrandId"]);
            catalogItemModel.CatalogTypeId = Convert.ToInt32(catalogItem.Rows[0]["catalogTypeId"]);
            catalogItemModel.Description = catalogItem.Rows[0]["description"];
            catalogItemModel.Name = catalogItem.Rows[0]["name"];
            catalogItemModel.PictureUri = catalogItem.Rows[0]["pictureUri"];
            catalogItemModel.PictureBase64 = catalogItem.Rows[0]["pictureBase64"];
            catalogItemModel.PictureName = catalogItem.Rows[0]["pictureName"];
            catalogItemModel.Price = Convert.ToDecimal(catalogItem.Rows[0]["price"]);
            try
            {
                catalogItemModel.Id = Convert.ToInt32(catalogItem.Rows[0]["id"]);
            }catch(Exception) { }

            return catalogItemModel;
        }
    }
}
