using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student : Human
{
    public byte Grade { get; set; }

    public Student(string fname, string lname, byte grade)
        : base(fname, lname)
    {
        this.Grade = grade;
    }

    public override string ToString()
    {
        return string.Format("{0, -10} {1, -10} {2} Grade", this.FirstName, this.LastName, this.Grade);
    }
}
