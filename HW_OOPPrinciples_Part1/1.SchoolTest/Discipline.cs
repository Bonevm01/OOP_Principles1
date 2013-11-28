using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Disciplines have name, number of lectures and number of exercises
public class Discipline
{
    public DisciplineName Name;
    private uint? numberOfLectures;
    private uint? numberOfExerceses;
   // public List<string> Comments;????

    public Discipline(DisciplineName name)
    {
        this.Name = name;
    }

    public uint? LectureNumber
    {
        get
        {
            return this.numberOfLectures;
        }

        set
        {
            if (value < 1 || value > 15)
            {
                throw new ArgumentOutOfRangeException("Lectures must be between 1 and 15.");
            }
            this.numberOfLectures = value;
        }
    }

    public uint? ExerciseNumbers
    {
        get
        {
            return this.numberOfExerceses;
        }
        set
        {
            if (value < 1 || value > 25)
            {
                throw new ArgumentOutOfRangeException("Exercises must be between 1 and 25.");
            }
            this.numberOfExerceses = value;
        }
    }
}
