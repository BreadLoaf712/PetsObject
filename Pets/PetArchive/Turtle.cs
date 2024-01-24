using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetArchive
{
    public class Turtle : pet
    {
        public Turtle(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + "Grunts at you");
        }

        public void HideInShell()
        {
            Console.WriteLine("The turtle hides in its shell");
        }

        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name +  "thinks " + newFriend.Name + "is food");
        }
    }
}
