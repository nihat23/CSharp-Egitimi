﻿using System;

namespace Ders08SiniflarClasses
{
    class Ev //C# ta kendi sınıflarımızı bu şekilde oluşturabiliriz
    {
        public int KapiNo;
        public string SokakAdi;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar!");
            Ev evAdresi = new();//Sınıftan nesne oluşturma
            evAdresi.KapiNo = 18; //Sınıftan oluşan nesnelere değer atama işlemi
            evAdresi.SokakAdi = "Arı sokak"; //Sınıftan oluşan nesnelere değer atama işlemi
            Console.WriteLine("Aylinin adresi : {0} No : {1} İstanbul", evAdresi.SokakAdi, evAdresi.KapiNo); //Sınıftan oluşan nesnelerin değerlerini okuma işlemi

            Ev yazlik = new() { SokakAdi = "Yalıkavak sokak", KapiNo = 1 };
            Console.WriteLine($"Aylinin yazlık adresi : {yazlik.SokakAdi} No : {yazlik.KapiNo} Bodrum");

            Kurs kurs = new()
            {
                EgitimAdi = "Yazılım Uzmanlığı",
                KapiNo = 102,
                Gunleri = "Hafta içi",
                KursAdi = "Arı Bilgi",
                SinifMevcut = 4
            };
            Console.WriteLine($"Kurs Bilgileri : \n Eğitim Adı : {kurs.EgitimAdi} \n Kapı No : {kurs.KapiNo} \n Kurs Günleri : {kurs.Gunleri} \n Sınıf Mevcudu : {kurs.SinifMevcut} \n Kurs Adı : {kurs.KursAdi}");

            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            siniftaMetotKullanimi.ToplamaYap();

            Console.WriteLine(SiniftaMetotKullanimi.StatikDegisken); //Sınıflarda static bir değişken veya metot kullanırsak sınıftan new ile örnek almadan direk SınıfAdı.Değişken-MetotAdi şeklinde kullanabiliriz
            SiniftaMetotKullanimi.ToplamaYap(10, 8); //static olarak tanımladığımız toplamayap metodunu da sınıfadı.metotadı şeklinde direk çağırabiliriz new lemeye gerek olmadan

        }
    }

    class Kurs
    {
        public int KapiNo;
        public string KursAdi;
        public string EgitimAdi;
        public int SinifMevcut;
        public string Gunleri;
    }

}
