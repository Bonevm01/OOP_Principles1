using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Human(string fname)
        : this(fname, null)
    {
    }
    public Human(string fname, string lname)
    {
        this.FirstName = fname;
        this.LastName = lname;
    }
    public override string ToString()
    {
        return string.Format("{0} {1}", this.FirstName, this.LastName);
    }
}

