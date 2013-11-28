using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Frog : Animal
{
    public Frog(string name, uint age, Sex sex)
        : base(name, age, sex)
    {
    }

    public override void Makesound()
    {
        Console.WriteLine("Kva-Kva"); ;
    }
}
