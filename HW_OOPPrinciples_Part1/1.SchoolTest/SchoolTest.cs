using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDesign
{
    class SchoolTest
    {
        static void Main()
        {
           //Instance of a school
            School mySchool = new School("125SOU");
            //Instance of a new teacher
            Teacher teach01 = new Teacher("Antonova");
            //Instance of a new discipline
            Discipline discipl01 = new Discipline(DisciplineName.Arts);
            //Add a discipline to teachers list - during this process you have to mark number of lectures and number of exercises
            teach01.AddDiscipline(discipl01);
            //instance of a new class
            Class myClass = new Class("first B");
            //Add this class to schools list
            mySchool.AddAClassInTheSchool(myClass);

            //Instance of another class - with the same name(identifier) - to check if it unique
            Class anotherClass = new Class("first B");
            //Add another class with the same identifier - the program will warn you and will ask to change this identifier
            mySchool.AddAClassInTheSchool(anotherClass);

            //Instance of a student
            Student stud01 = new Student("Petar");
            //Add this student to first class
            myClass.AddAStudent(stud01); //The program will ask for classnumber and will check if it unique

            //Instance of another student
            Student stud02 = new Student("Vania");
            myClass.AddAStudent(stud02); //Try to give this student the same class number as the first student

            //Add a teacher to a class
            myClass.AddATeacher(teach01);

            //Test adding comments
            mySchool.AddComment();
            teach01.AddComment();
        }
    }
}
