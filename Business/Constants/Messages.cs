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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="";
        internal static string ProductNameAlreadyExists="Bu isimde bir ürün zaten var";
        internal static string CategoryLimitExceded;
       

        public static string  AuthorizationDenied="Yetkiniz yok";
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static User UserNotFound;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static string UserRegistered;
    }
}
