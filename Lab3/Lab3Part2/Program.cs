namespace Lab3Part2
{
    class Program
    {
        //Dog method that allows users to set setters and getters Dog class
        static void DogMethod()
        {
            Dog DogVar = new Dog();
            Console.WriteLine("Enter Dog Name: ");
            DogVar.name = Console.ReadLine();
            Console.WriteLine("Enter Colour of Dog: ");
            DogVar.colour = Console.ReadLine();
            Console.WriteLine($"Enter age of Dog: ");
            DogVar.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of Dog: ");
            DogVar.height = Convert.ToInt32(Console.ReadLine());
            DogVar.Eat();
            Console.WriteLine(DogVar.Cry());
        }
        
        //Cat method that allows users to set setters and getters for Cat class
        static void CatMethod()
        {
            Cat CatVar = new Cat();
            Console.WriteLine("Enter Cat Name: ");
            CatVar.name = Console.ReadLine();
            Console.WriteLine("Enter Colour of Cat: ");
            CatVar.colour = Console.ReadLine();
            Console.WriteLine($"Enter age of Cat: ");
            CatVar.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of Cat: ");
            CatVar.height = Convert.ToInt32(Console.ReadLine());
            CatVar.Eat();
            Console.WriteLine(CatVar.Cry());
        }

        //Animal list that generates a list of Dog and Cat objects and outputs their names
        static void AnimalList()
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog {name = "Rogue"});
            animals.Add(new Dog {name = "Striker"});
            animals.Add(new Cat {name = "Sparkle"});
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine($"This animals name is {animal.name} they go {animal.Cry()}");
            }


        }

        //Main method that starts the program
        static void Main(string[] args)
        {
            DogMethod();
            CatMethod();
            AnimalList();
        }
    }
}