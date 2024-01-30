interface IAnimal
{
    public string name
    { get; set; }

    public string colour
    { get; set; }

    public int age
    { get; set; }

    public int height
    { get; set; }

    public abstract void Eat();

    string Cry();
}