using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Both teachers and students are people - Human - base class
public abstract class Human : Comment
{
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length<3)
            {
                throw new ArgumentOutOfRangeException("The name can't be shorter than 3 letters.");
            }

            if (value.Length>30)
            {
                throw new ArgumentOutOfRangeException("The name can't be longer than 30 letters.");
            }

            bool isValidName = true;
            foreach (var simbol in value)
            {
                if (!IsValidSimbol(simbol))
                {
                    isValidName = false;
                    break;
                }
            }

            if (isValidName)
            {
                this.name = value;
            }

        }

    }

    public Human(string humanName)
    {
        this.Name = humanName;
    }


    private bool IsValidSimbol(char simbol)
    {
        bool isAllowedChar = char.IsLetter(simbol) || simbol == ' ';
        return isAllowedChar;
    }
}

