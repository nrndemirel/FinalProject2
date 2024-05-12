using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sayfa bakimda";
        public static string ProductListed = "Urun listelendi";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla !0 urun olabilir";
        public static string ProductNameExistError = "Ayni isimde urun eklenemez!";
        public static string categoryCountExceedError = "Kategori limiti asildigi icin yeniurun eklenemez.";
    }
}