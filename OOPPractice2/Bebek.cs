using System;

class Baby
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DateBirthTime { get; set; }

    // Default Constructor
    public Baby()
    {
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now.Year; 
    }

    // Parameters Constructor
    public Baby(string name, string surname)
    {
        Console.WriteLine("Ingaaaa");
        Name = name;
        Surname = surname;
        DateBirthTime = DateTime.Now.Year; 
    }
}
