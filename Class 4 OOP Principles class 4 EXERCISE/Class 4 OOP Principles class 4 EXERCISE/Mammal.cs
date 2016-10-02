using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4_OOP_Principles_class_4_EXERCISE
{
    public class Mammal : Animal
    {
        //protected int LimbsCount { get; set; }

        public int Age { get; set; }

        public Mammal(string name,int age) : base(name)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh! I'm sleeping!");
        }

        public virtual void Move()
        {
            Console.WriteLine(" I am mammal and I am moving");
        }

        public void Move(int speed)
        {
            Console.WriteLine("I am moving with {0} km/h",speed);
        }

        public override void DoSomethingVeryImportant()
        {
            throw new NotImplementedException();
        }
    }
}


public interface Imoveable
{
    void Move();
    void Move(int speed);
}

public abstract class Animal : Imoveable
{
    public string Name { get; set; }

    public Animal(string name)
    {
        this.Name = name;
    }

    public abstract void DoSomethingVeryImportant();

    public void Move()
    {
        throw new NotImplementedException();
    }

    public void Move(int speed)
    {
        throw new NotImplementedException();
    }
}
