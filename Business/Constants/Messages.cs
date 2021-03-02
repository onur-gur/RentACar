using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Arabalar eklendi";
        public static string CarDescriptionInvalid = "Arabalar ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalarler listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string Added = "eklendi";
        public static string Updated = "güncellendi";
        public static string Deleted = "silindi";
        public static string Listed = "listelendi";
        public static string InvalidDate = "Geçersiz tarih";
        public static string DeliveredCar = "Araç teslim edildi";
        public static string FailImageLimitExceeded = "Araba resim sayısı 5'i geçemez";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccesfullLogin="Başarılı login";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string UserRegistered="Kullanıcı başarılıyla kaydedildi";
        public static string AccessTokenCreated="AccessToken Başarıyle oluşturuldu";
        public static string AuthorizationDenied="Yetkiniz yok";
    }
}
