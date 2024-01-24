using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetArchive
{
    public class Cat : pet
    {
        public Cat(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + "Meows at you");
        }
        
        public void Climb()
        {
            Console.WriteLine("The cat climbs the wall");
        }
        public void Meet(Cat newFriend)
        {
            Console.WriteLine(Name + "attempts to dominate" + newFriend.Name);
        }
    }
}
