using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main()
    {
        Student stud01 = new Student("Georgi", "Petrov", 3);
        Student stud02 = new Student("Nedko", "Ivanov", 2);
        Student stud03 = new Student("Stojan", "Vasilev", 1);
        Student stud04 = new Student("Ivan", "Ganchev", 4);
        Student stud05 = new Student("Alexander", "Hristov", 3);
        Student stud06 = new Student("Marin", "Tsonev", 4);
        Student stud07 = new Student("Orlin", "Nedelchev", 2);
        Student stud08 = new Student("Mario", "Nikolov", 3);
        Student stud09 = new Student("Nikola", "Dertliev", 1);
        Student stud010 = new Student("Angel", "Penchev", 1);

        List<Student> myClass = new List<Student> { stud01, stud010, stud02, stud03, stud04, stud05, stud06, stud07, stud08, stud09 };

        var sortedList = myClass.OrderBy(x => x.Grade);

        Console.WriteLine("Students sorted by their Grade:");
        foreach (Student stud in sortedList)
        {
            Console.WriteLine(stud);
        }
        Console.WriteLine();

        Worker work01 = new Worker("Gosho", "Peshev", 300, 8);
        Worker work02 = new Worker("Nedjalko", "Ivanov", 422, 7);
        Worker work03 = new Worker("Vasil", "Vasilev", 198, 3);
        Worker work04 = new Worker("Angel", "Ganchev", 411, 9);
        Worker work05 = new Worker("Sasho", "Hristov", 312, 8);
        Worker work06 = new Worker("Andrey", "Tsonev", 264, 7);
        Worker work07 = new Worker("Ognjan", "Nedelchev", 289, 8);
        Worker work08 = new Worker("Minko", "Nikolov", 300, 5);
        Worker work09 = new Worker("Kolio", "Dertliev", 100, 2);
        Worker work010 = new Worker("Svetlio", "Penchev", 145, 3);

        List<Worker> myTeam = new List<Worker> { work01, work010, work02, work03, work04, work05, work06, work07, work08, work09 };
        Console.WriteLine("Workers sorted by money per hour:");
        var bestPaid =
            from person in myTeam
            orderby person.MoneyPerHour descending
            select person;

        foreach (Worker item in bestPaid)
        {
            Console.WriteLine(item);
        }

        List<Human> mergedList = new List<Human>();
        mergedList.AddRange(sortedList);
        mergedList.AddRange(bestPaid);

        var alphabetOrder =
            from person in mergedList
            orderby person.FirstName, person.LastName
            select person;

        Console.WriteLine();
        Console.WriteLine("List of Students and Workers (alphabetical order):");
        foreach (var person in alphabetOrder)
        {
            Console.WriteLine("{0, -10} {1, -10} {2}",person.FirstName, person.LastName, person.GetType());
        }
    }
}
