using Objectorientatedprinciples;

class Program
{

    static void Main(String[] args)
    {
        People Person1 = new People("Amukelani", "Female", "Black", 26);
        People Person2 = new People("Creseldah", "Female", "Black", 19);
        People Person3 = new People("Bongani", "Male", "Black", 08);

        Console.WriteLine(Person1.Name + " " + Person1.Gender + " " + Person1.Race + " " + Person1.Age);
        Console.WriteLine(Person2.Name + " " + Person2.Gender + " " + Person2.Race + " " + Person2.Age);
        Console.WriteLine(Person3.Name + " " + Person3.Gender + " " + Person3.Race + " " + Person3.Age);

    }


}