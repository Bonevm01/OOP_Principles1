using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal : ISound
{
    public string Name { get; set; }
    public uint Age { get; set; }
    public Sex Sex { get; private set; }


    public Animal(string name, uint age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }


    public virtual void Makesound()
    {
        Console.WriteLine("Animal sound"); ;
    }

    public static double AverageAge(Animal[] arr)
    {
        if (arr.Length > 0)
        {
            uint sum = 0;
            foreach (Animal an in arr)
            {
                sum += an.Age;
            }

            return sum / (double)arr.Length;
        }
        return 0;

    }
}
