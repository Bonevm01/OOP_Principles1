using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tomcat : Cat
{
    public Tomcat(string name, uint age)
        : base(name, age, Sex.Male)
    {
    }

    public override void Makesound()
    {
        Console.WriteLine("Mur-Mur"); ;
    }
}
