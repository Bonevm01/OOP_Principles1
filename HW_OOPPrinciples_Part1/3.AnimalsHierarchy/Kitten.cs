using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Kitten : Cat
{
    //private readonly Sex Sex = Sex.Female;
    
    public Kitten(string name, uint age)
        : base(name, age, Sex.Female)
    {
    }
    public override void Makesound()
    {
        Console.WriteLine("Miiaauu"); ;
    }
}
