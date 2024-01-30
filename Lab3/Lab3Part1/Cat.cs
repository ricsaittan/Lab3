class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice");
    }
    
    public Cat(string name, string colour, int age) : base(name, colour, age)
    {
        
    }
}