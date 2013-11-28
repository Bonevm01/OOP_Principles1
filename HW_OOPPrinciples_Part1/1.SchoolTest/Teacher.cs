using System;
using System.Collections.Generic;


//Each teacher teaches a set of disciplines. 
//Teachers have name
//Both teachers and students are people
public class Teacher : Human
{
    public List<Discipline> teachersDisciplines;
    

    public Teacher(string name)
        : base(name)
    {
    }

    public void AddDiscipline(Discipline discipl)
    {
        Console.WriteLine("Adding a discipline (\"{1}\") to the teacher {0}:", this.Name, discipl.Name);
        if (this.teachersDisciplines==null)
        {
            this.teachersDisciplines = new List<Discipline>();
        }
        if (discipl.ExerciseNumbers == null)
        {
            Console.Write("Please enter the number of exercises of the discipline {0}/teacher {1}:", discipl.Name, this.Name);
            discipl.ExerciseNumbers = uint.Parse(Console.ReadLine());
        }

        if (discipl.LectureNumber == null)
        {
            Console.Write("Please enter the number of luctures of this discipline {0}/teacher {1}:", discipl.Name, this.Name);
            discipl.LectureNumber = uint.Parse(Console.ReadLine());
        }

        this.teachersDisciplines.Add(discipl);
        Console.WriteLine("Adding completed.");
        Console.WriteLine();
    }

}
