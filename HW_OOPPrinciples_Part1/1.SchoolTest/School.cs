using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a school. In the school there are classes 
class School : Comment
{
    private readonly string Name;
    private List<Class> classes;

    public School(string name)
    {
        this.Name = name;
        classes = new List<Class>();
    }

    //Classes have unique text identifier - verify it when adding a new class to the school's list
    public void AddAClassInTheSchool(Class cl)
    {
        Console.WriteLine("Adding a new class (\"{0}\") to the school's list:", cl.Name);
        bool isUnique = true;
        do
        {
            isUnique = true;
            foreach (var item in this.classes)
            {
                if (cl.Name == item.Name)
                {
                    isUnique = false;
                    break;
                }
            }
            if (!isUnique)
            {
                Console.Write("The class name \"{0}\" is not free. Please chose an unique name to this class: ", cl.Name);
                cl.Name = Console.ReadLine();
            }
        } while (!isUnique);

        this.classes.Add(cl);
        Console.WriteLine("Adding completed.");
        Console.WriteLine();
    }
}
