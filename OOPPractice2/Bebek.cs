using System;

class Bebek
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumTarihi { get; set; }

    // Default Constructor
    public Bebek()
    {
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now.Year; // Anlık yılı ata
    }

    // Parametreli Constructor
    public Bebek(string ad, string soyad)
    {
        Console.WriteLine("Ingaaaa");
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now.Year; // Anlık yılı ata
    }
}