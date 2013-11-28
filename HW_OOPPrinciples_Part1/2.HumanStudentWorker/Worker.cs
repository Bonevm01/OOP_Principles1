using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Worker : Human
{
    public uint WeekSalary { get; set; }
    public uint HoursPerDay { get; set; }

    public Worker(string fname, string lname, uint weekSalary, uint workHoursPerDay)
        : base(fname, lname)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = workHoursPerDay;
    }

    public double? MoneyPerHour
    {
        get
        {
            if (this.HoursPerDay == 0)
            {
                return null;
            }

            return this.WeekSalary / (double)this.HoursPerDay;
        }
    }

    public override string ToString()
    {
        return string.Format("{0, -10} {1, -10} {2, -5} {3, -2}. Money per hour {4:f2}", this.FirstName, this.LastName, this.WeekSalary, this.HoursPerDay, this.MoneyPerHour);
    }
}
