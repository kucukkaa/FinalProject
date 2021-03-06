using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductLimitError = "Kategori için ürün limiti aşıldı.";
        public static string ProductNameAlreadyExists = "Aynı isimli iki ürün bulunamaz";
        public static string CategoryLimitExceded = "Kategory limiti aşıldı.";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
