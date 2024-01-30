class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public Dog(string name, string colour, int age) : base(name, colour, age)
    {

    }

}

