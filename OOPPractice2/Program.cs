class Program
{
    static void Main(string[] args)
    {
        // Default constructor 
        Baby baby1 = new Baby();
        Console.WriteLine($"Name: {bebek1.Name}, Surname: {baby1.Surname}, BirthDate: {baby1.DateBirthTime}");

        // Parametres constructor
        Baby bebek2 = new Baby("Furkancan", "Yilmaz");
        Console.WriteLine($"Name: {bebek2.Name}, Surname: {baby2.Surname}, BirthDate: {baby2.DateBirthTime}");
    }
}
