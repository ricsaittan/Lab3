using System.Net.Http.Headers;


namespace Lab3Part1
{
    class Program
    {
        //Cat Method That allows user to enter and create a Cat object
        static void CatMethod()
        {
            Console.WriteLine("Enter Cat Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Enter Colour of {Name}: ");
            string Colour = Console.ReadLine();
            Console.WriteLine($"Enter age for {Name}: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Cat CatVar = new Cat(Name, Colour, Age);
            Console.WriteLine($"{CatVar.name} has a colour of {CatVar.colour} and is {CatVar.age} years old" );
            CatVar.Eat();
        }
        
        //Dog Method That allows user to enter and create a Dog object
        static void DogMethod()
        {
            Console.WriteLine("Enter Dog Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Enter Colour of {Name}: ");
            string Colour = Console.ReadLine();
            Console.WriteLine($"Enter age for {Name}: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Dog DogVar = new Dog(Name, Colour, Age);
            Console.WriteLine($"{DogVar.name} has a colour of {DogVar.colour} and is {DogVar.age} years old" );
            DogVar.Eat();
        }

        //Main Method that runs the program
        static void Main(string[] args)
        {
            DogMethod();
            CatMethod();
        }
    }
}