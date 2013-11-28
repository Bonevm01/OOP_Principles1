using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Students, classes, teachers and disciplines could have optional comments (free text block).
public class Comment
{
    public List<string> Comments;

    public void AddComment()
    {
        if (this.Comments==null)
        {
            this.Comments = new List<string>();
        }
         Console.Write("Enter your comment here: ");
         string input = Console.ReadLine();
         this.Comments.Add(input);
    }
}
