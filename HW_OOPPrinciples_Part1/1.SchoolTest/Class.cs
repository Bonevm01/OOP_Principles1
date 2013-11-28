using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//classes of students. Each class has a set of teachers
public class Class : Comment
{
    private string name; //unique identifier - I check it when add a new class to schools list
    public List<Student> students;
    public List<Teacher> teachers;
    

    public Class(string className)
    {
        this.Name = className;
        students = new List<Student>();
        teachers = new List<Teacher>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    //Students have unique class number
    public void AddAStudent(Student stud)
    {
        Console.WriteLine("Adding a new student ({0}) to the class \"{1}\":", stud.Name, this.Name);
        if (stud.ClassNumber == null)
        {
            Console.Write("Please enter the class number of the student {0}:", stud.Name);
            stud.ClassNumber = byte.Parse(Console.ReadLine());
        }

        bool isUnique = true;
        do
        {
            isUnique = true;
            foreach (var item in this.students)
            {
                if (item.ClassNumber == stud.ClassNumber)
                {
                    isUnique = false;
                    break;
                }
            }
            if (!isUnique)
            {
                Console.Write("The class number {0} for the student {1} is not free. Please enter another class number:", stud.ClassNumber, stud.Name);
                stud.ClassNumber = byte.Parse(Console.ReadLine());
            }

        } while (!isUnique);

        this.students.Add(stud);
        Console.WriteLine("Adding completed.");
        Console.WriteLine();
    }

    public void AddATeacher(Teacher teach)
    {
        Console.WriteLine("Adding a new teacher ({0}) to the class \"{1}\":", teach.Name, this.Name);
        this.teachers.Add(teach);
        Console.WriteLine("Adding completed.");
        Console.WriteLine();
    }


}
