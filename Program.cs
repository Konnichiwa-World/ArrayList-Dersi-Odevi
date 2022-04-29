using System;
using System.Collections;
namespace Arraylist
{    class Program
    {   static void Main(string[] args){
        
        Console.WriteLine("Patika.Fuzulev Çekilişine hoşgeldiniz.\n İlk önce, talep ettiğiniz ev için gerekli ücreti odemelisiniz:");
        System.Console.WriteLine("2000 TL = Kömürlük \n10000 TL = Gecekondu \n100.000 TL = TOKİ dairesi \n10.000.000 TL=Boğaza sıfır triplex yalı. Şehir merkezine 1 dk, ama roketle." );
        Int32 x =Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Çekilişe hak kazandınız! Unutmayın, ne kadar yüksek tutar girerseniz o kadar kazanma şansınız artar:");
        ArrayList liste1 = new ArrayList();
        System.Console.WriteLine("İsminizi giriniz:");
        string a = Console.ReadLine();
        liste1.Add(a);
        System.Console.WriteLine("Soyisminiz giriniz:");
        string b = Console.ReadLine();
        liste1.Add(b);
        System.Console.WriteLine("TC Kimlik no giriniz:");
        string c = Console.ReadLine();
        liste1.Add(c);
        if(x==2000){Random rnd = new Random();
        int RastgeleSayi1=rnd.Next(1,101);
        if(RastgeleSayi1<=10){System.Console.WriteLine("Kazanan:" + liste1 +"Tebrikler! Kömürlük hayırlı olsun :)");}
        else{System.Console.WriteLine("Kazanamadınız. Seneye tekrar deneyiniz.");}
        }

        if(x==10000){Random rnd = new Random();
        int RastgeleSayi1=rnd.Next(1,101);
        if(RastgeleSayi1<=20){System.Console.WriteLine("Kazanan:" + liste1 +"Tebrikler! Gecekondunuz hayırlı olsun :)");}
        else{System.Console.WriteLine("Kazanamadınız. Seneye tekrar deneyiniz.");}
        }

        if(x==100000){Random rnd = new Random();
        int RastgeleSayi1=rnd.Next(1,101);
        if(RastgeleSayi1<=30){System.Console.WriteLine("Kazanan:" + liste1 +"Tebrikler! TOKİ daireniz hayırlı olsun :)");}
        else{System.Console.WriteLine("Kazanamadınız. Seneye tekrar deneyiniz.");}
        }

        if(x==10000000){Random rnd = new Random();
        int RastgeleSayi1=rnd.Next(1,101);
        if(RastgeleSayi1<40){System.Console.WriteLine("Kazanan:" + liste1 +"Tebrikler! Villanız hayırlı olsun :)");}
        else{System.Console.WriteLine("Kazanamadınız. Seneye tekrar deneyiniz.");}
        
        }
        else{System.Console.WriteLine("Gerekli ücretleri girmediğiniz ortaya çıktı, lütfen tekrar deneyiniz.");}
    }
        }}
    
    
    
    
    
    
    

    
