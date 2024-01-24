using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetArchive
{
    public class Chimp : pet
    {
        public Chimp(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + "Hoots at you");
        }

        public void Climb()
        {
            Console.WriteLine(Name + "Climbs the wall");
        }

        public void Meet(Chimp newFriend)
        {
            Console.WriteLine(Name + "Hoots and throws shit at" + newFriend.Name);
        }
    }
}
