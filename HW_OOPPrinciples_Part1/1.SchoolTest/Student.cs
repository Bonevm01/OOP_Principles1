using System;
using System.Collections.Generic;

//Students have name and unique class number
//Both teachers and students are people
public class Student : Human
{
    private byte? classNumber;
    

    public Student(string name)
        : base(name)
    {
    }

    public byte? ClassNumber  //I check if the number is unique when add a student to a school class
    {
        get
        {
            return this.classNumber;
        }
        set
        {
            if (value<1|| value>40)
            {
                throw new ArgumentOutOfRangeException("The class number must be between 1 and 40.");
            }
            this.classNumber = value;
        }
    }
}
