using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            number = 4.85;
            Console.WriteLine(number);
            Console.WriteLine("*****Fiyat Listesi*****");
            Console.WriteLine("");

            double applePrice, orangePrice, strawberryPrice, patotoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            patotoPrice = 9.74;
            tomatoPrice = 6.88;
            Console.WriteLine("----Elma fiyat: " + applePrice + "TL");
            Console.WriteLine("----Portakal fiyat: " + orangePrice + "TL");
            Console.WriteLine("----Çilek fiyat: " + strawberryPrice + "TL");
            Console.WriteLine("----Patates fiyat: " + patotoPrice + "TL");
            Console.WriteLine("----Domates fiyat: " + tomatoPrice + "TL");

            double appleGram, orangeGram, strawberryGram, patotoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            patotoGram = 4.859;
            tomatoGram = 3.745;
            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double patotoTotalPrice = patotoPrice * patotoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;
            Console.WriteLine("-----Hesap-----");
            Console.WriteLine("----Elmanın Toplam Fiyatı: " + appleTotalPrice + "TL");
            Console.WriteLine("----Portakal Toplam Fiyatı: " + orangeTotalPrice + "TL");
            Console.WriteLine("----Çilek Toplam Fiyatı: " + strawberryTotalPrice + "TL");
            Console.WriteLine("----Patates Toplam Fiyatı: " + patotoTotalPrice + "TL");
            Console.WriteLine("----Domates Toplam Fiyatı: " + tomatoTotalPrice + "TL");
            double shoppingTotalPrice;
            shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patotoTotalPrice + tomatoTotalPrice;
            Console.WriteLine("");
            Console.WriteLine("-----Toplam Tutar-----" + shoppingTotalPrice + "TL");
            #region klavyedenveri girişi
            Console.WriteLine("-----C# hava yolları yolcu bilgileri-----");
            Console.WriteLine("");
            string passengerName, passengerSurname, passengerDistrict, passsengerCity, passsengerAge, passengerIdentityNumber;
            Console.Write("Yolcu Adı:");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı:");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe:");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir:");
            passsengerCity = Console.ReadLine();
            Console.Write("Yolcu yaşı:");
            passsengerAge = Console.ReadLine();
            Console.Write("Yolcu TC:");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Yolcu Bilgieri: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " " + passsengerCity + " " + passsengerAge + " " + passengerIdentityNumber);
            #endregion
            #region klavyeden tam sayı girişleri

            #endregion
            #region klavyeden tam sayı girişleri ve dönüşümler

            int shoesprice, computerprice, chairprice, tvprice;
            shoesprice = 1000;
            computerprice = 20000;
            chairprice = 5000;
            tvprice = 1200;

            int shoescount, computercount, chaircount, tvcount;
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoescount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computercount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız masa sayısını giriniz: ");
            chaircount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            tvcount = int.Parse(Console.ReadLine());
            int totalprice = shoescount * shoesprice + computercount * computerprice + chaircount * chairprice + tvprice * tvcount;
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("TOPLAM TUTAR:" + totalprice);

            #endregion

            #region klavyeden ondalıklı sayı işlemleri
            double exam1, exam2, exam3, result;
            Console.Write("Lütfen 1.sınav notunu giriniz:");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 2.sınav notunu giriniz:");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 3.sınav notunu giriniz:");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.Write("Sınav Ortalamanız:" + result);


            #endregion
            #region klavyeden karekter girişleri


            #endregion


            Console.ReadKey();


        }
    }
}
