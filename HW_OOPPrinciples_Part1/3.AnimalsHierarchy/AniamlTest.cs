using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AniamlTest
{
    static void Main()
    {
        // Animal an00 = new Animal("animal", 99, Sex.Male); //- it is not possible to initialize Animal - the class is abstract

        Frog an01 = new Frog("Jabka", 1, Sex.Female);
        Console.Write("sound of a frog is:");
        an01.Makesound();
        Dog an02 = new Dog("Balkan", 5, Sex.Male);
        Console.Write("sound of a dog is:");
        an02.Makesound();
        Cat an03 = new Cat("Muro", 2, Sex.Male); // Cat could be male or female
        Cat an04 = new Cat("Izabela", 4, Sex.Female); // Cat could be male or female
        Console.Write("sound of a cat is:");
        an04.Makesound();
        Kitten an05 = new Kitten("Chochi", 2);  //Kitten is alwais female
        Console.WriteLine("Kitten's sex is {0}", an05.Sex);
        Console.Write("sound of a kitten is:");
        an05.Makesound();
       // an05.Sex = Sex.Male; //It is not possible to access/change the sex of an Animal
        Tomcat an06 = new Tomcat("Gosho", 5);
        Console.WriteLine("Tomcat's sex is {0}", an06.Sex);
        Console.Write("sound of a tomcat is:");
        an06.Makesound();

        Dog an07 = new Dog("Lara", 8, Sex.Female);
        Dog an08 = new Dog("Sharo", 3, Sex.Male);
        Frog an09 = new Frog("Cermit", 2, Sex.Male);
        Kitten an10 = new Kitten("Suzi", 5);
        Tomcat an11 = new Tomcat("Tom", 2);


        Frog[] frogs = { an01, an09 };
        Console.WriteLine("The average age of frogs is {0:f2}", Animal.AverageAge(frogs)); //Static method in class Animal
        Console.WriteLine("The average age of frogs calculated by lambda is {0:f2}",frogs.Average(x=>x.Age));

        Dog[] dogs = { an02, an07, an08};
        Console.WriteLine("The average age of dogs is {0:f2}", Animal.AverageAge(dogs));
        Console.WriteLine("The average age of dogs calculated by lambda is {0:f2}", dogs.Average(x => x.Age));

        Cat[] allKindOfCats = { an03, an04, an05, an06, an10, an11};
        Console.WriteLine("The average age of all kind of cats is {0:f2}", Animal.AverageAge(allKindOfCats));
        Console.WriteLine("The average age of all kin of cats calculated by lambda is {0:f2}", allKindOfCats.Average(x => x.Age));

        Console.WriteLine();
        //Mix array
        Animal[] allAnimals = { an01,an02,an03, an04,an05, an06, an07, an08, an09, an10, an11};
        //split mixed aray to groups
        var groups = from kind in allAnimals
                     group kind by kind.GetType() into species
                     select species;
        //calculate and print average age by groups
        foreach (var item in groups)
        {
            Console.WriteLine("Kind ->{0, -10}; Average age ->{1:f2}", item.Key.Name, item.Average(x => x.Age));
        }

    }
}
