using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CSharpEgitimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler
            //double number;
            //number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawPrice + "TL");
            //Console.WriteLine("---- Patetes Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "TL"); 

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram* strawPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyat :" + applePrice + "  Gramaj : " + appleGram + " - Toplam Tutar :" + appleTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyat :" + orangePrice + "  Gramaj : " + orangeGram + " - Toplam Tutar :" + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyat :" + strawPrice + "  Gramaj : " + strawGram + " - Toplam Tutar :" + strawTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün : Patates - " + " Birim Fiyat :" + potatoPrice + "  Gramaj : " + potatoGram + " - Toplam Tutar :" + potatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün : Domates - " + " Birim Fiyat :" + tomatoPrice + "  Gramaj : " + tomatoGram + " - Toplam Tutar :" + tomatoTotalPrice + "TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutarı : " + shoppingTotalPrice);
            //Console.Read();
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            //Console.Read();



            #endregion


            #region Klavyeden Veri Girişleri String Girişleri

            //Console.WriteLine("****Csharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soy Adı : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu İl Bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarası : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Yolcu Bilgileri - " + passengerName+" "+passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber );

            //Console.Read();



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //// int shoesPrice, computerPrice, chairPrice, tvPrice;
            //// shoesPrice = 1000;
            //// computerPrice = 20000;
            //// chairPrice= 5000;
            //// tvPrice = 12000;

            //// int shoesCount, computerCount,  chairCount, tvCount;

            //// Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //// shoesCount=int.Parse(Console.ReadLine());
            //// Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //// computerCount = int.Parse(Console.ReadLine());
            //// Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //// chairCount = int.Parse(Console.ReadLine());
            //// Console.Write("Lütfen aldığınız tv sayısını giriniz : ");
            ////tvCount = int.Parse(Console.ReadLine());

            //// int totalPrice=shoesPrice*shoesCount+chairPrice *chairCount+tvPrice*tvPrice+ chairCount*chairPrice;

            //// Console.WriteLine("Ödeyeceğiniz Toplam Tutar : " + totalPrice);

            //// Console.Read();

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = ( exam1 + exam2+exam3)/3;

            //Console.WriteLine("Ortalama Notunuz =" + result);

            //Console.Read();
            #endregion

            #region Klavyeden karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz");
            //gender= char.Parse(Console.ReadLine());
            //Console.WriteLine("Cinsiyet = "+ gender);
            //Console.Read();



            #endregion
        }


    }
}
