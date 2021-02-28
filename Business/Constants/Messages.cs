using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Add products";
        public static string ProductNameInvalid = "Invalid product name ";
        public static string MaintenanceTime = "System maintenance ";
        public static string ProductsListed = "List products";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExist = "Aynı isimde birden çok ürün eklenemez.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetkinniz yok.";
    }
}
