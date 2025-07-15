using System;

// Bebek sınıfı tanımlaması
public class Bebek
{
    // Propertyler (özellikler)
    public DateTime DogumTarihi { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    
    // 1. Constructor - Default (parametresiz)
    public Bebek()
    {
        // Ortak işlemler
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now; // Şu anki tarih
        
        // Default değerler
        Ad = "Bilinmeyen";
        Soyad = "Bilinmeyen";
    }
    
    // 2. Constructor - Ad ve Soyad parametreli
    public Bebek(string ad, string soyad)
    {
        // Ortak işlemler
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now; // Şu anki tarih
        
        // Parametrelerden gelen değerleri atama
        Ad = ad;
        Soyad = soyad;
    }
    
    // Bebek bilgilerini yazdıran metot
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}");
        Console.WriteLine($"Soyad: {Soyad}");
        Console.WriteLine($"Doğum Tarihi: {DogumTarihi}");
        Console.WriteLine("-------------------");
    }
}

// Program sınıfı - Ana program
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== BEBEK SINIFI ÖRNEĞİ ===\n");
        
        // 1. Default constructor ile bebek oluşturma
        Console.WriteLine("1. Default Constructor ile bebek oluşturuluyor:");
        Bebek bebek1 = new Bebek();
        bebek1.BilgileriYazdir();
        
        // Biraz bekleme (farklı zaman göstermek için)
        System.Threading.Thread.Sleep(1000);
        
        // 2. Parametreli constructor ile bebek oluşturma
        Console.WriteLine("2. Parametreli Constructor ile bebek oluşturuluyor:");
        Bebek bebek2 = new Bebek("Jale", "Yılmaz");
        bebek2.BilgileriYazdir();
        
        Console.WriteLine("Program bitti. Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}