

class Cat : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public string Cry()
    {
        return "Meow!";
    }

    public string name { get; set; }

    public string colour { get; set; }

    public int age { get; set; }

    public int height { get; set; }

}