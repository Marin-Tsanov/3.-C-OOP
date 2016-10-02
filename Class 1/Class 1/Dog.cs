using System;

class Dog
{
    private string name;
    private string breed;

    public Dog()
    {
    }

    public static Dog operator +(Dog c1, Dog c2)
    {
        var newDog = new Dog();
        newDog.Name = c1.Name + " " + c2.Name;
        newDog.Breed = c1.breed + " " + c2.Breed;
        return newDog;
    }

    public Dog(string name, string breed)
    {
        this.name = name;
        this.breed = breed;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public void SayBau()
    {
        Console.WriteLine("{0} said: Bauuuuuu!",
            this.name ?? "[unnamed dog]");
    }

    public void Walk()
    {
        Console.WriteLine("Walk from {0}", this.name);
    }
}