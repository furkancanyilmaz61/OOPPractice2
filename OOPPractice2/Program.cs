class Program
{
    static void Main(string[] args)
    {
        // Default constructor ile nesne oluşturma
        Bebek bebek1 = new Bebek();
        Console.WriteLine($"Ad: {bebek1.Ad}, Soyad: {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

        // Parametreli constructor ile nesne oluşturma
        Bebek bebek2 = new Bebek("Furkancan", "Yilmaz");
        Console.WriteLine($"Ad: {bebek2.Ad}, Soyad: {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");
    }
}