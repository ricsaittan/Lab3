abstract class Animal
{
    public string name 
    { get; set; }

    public string colour
    { get; set; }

    public int age 
    { get; set; }

    public abstract void Eat();

    public Animal(string Name, string Colour, int Age)
    {
        this.name = Name;
        this.colour = Colour;
        this.age = Age;
    }
}