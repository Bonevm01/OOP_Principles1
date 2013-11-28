using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dog : Animal
{
    public Dog(string name, uint age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void Makesound()
    {
        Console.WriteLine("Bau-Bau"); ;
    }
}
