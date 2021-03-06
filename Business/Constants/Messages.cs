﻿using Core.Entities.Concrete;
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
        internal static string CategoryLimitExceded="h";
       

        public static string  AuthorizationDenied="Yetkiniz yok";
        public static string PasswordError = "Parola Yanlış";
        internal static string SuccessfulLogin="Giriş Başarılı";
        internal static string UserNotFound="Kullanıcı Bulunamadı";
        internal static string UserAlreadyExists= "Kullanıcı adı bulunmakta";
        internal static string AccessTokenCreated= "Giriş anahtarı oluşturuldu";
        internal static string UserRegistered="Giriş Onaylandı";
    }
}
