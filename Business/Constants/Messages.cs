using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Başarıyla Eklendi.";
        public static string CarDeleted = "Araba Başarıyla Silindi.";
        public static string CarUpdated = "Araba Başarıyla Güncellendi.";
        public static string CarPriceInvalid = "Girilen Araba Fiyatı Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Arabalar Listelendi.";
        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserEmailInvalid = "Girilen Email Adresi Geçersiz.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı Güncelledi.";
        public static string UserListed = "Kullanıcı Listelendi.";
        public static string CustomerListed = "Müşteriler Listelendi.";
        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string RentalDeleted = "Kiralama Silindi.";
        public static string RentalUpdated = "Kiralama Güncellendi.";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string RentalAdded = "Kiralama Eklendi.";
        public static string CarNotInvalid = "Kiralama Uygun Değil !";
        public static string BrandListed = "Markalar Listelendi.";
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string ColorListed = "Renkler Listelendi.";
        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string AuthorizationDenied = "Yetkiniz Yok!";
        internal static string UserRegistered = "Kayıt Yapıldı.";
        internal static string UserNotFound = "Kullanıcı Bulunamadı.";
        internal static string PasswordError = "Şifre Hatalı";
        internal static string SuccessfulLogin = "Giriş Başarılı";
        internal static string UserAlreadyExists = "Kullanıcı Zaten Kayıtlı";
        internal static string AccessTokenCreated = "Token Yaratıldı";
    }
}
