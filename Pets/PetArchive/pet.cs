using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetArchive
{
    public abstract class pet
    {
        //pet is a class of animals. the type of pet is a subclass
        public string Name { get; set; }

        //constructor
        public pet(string name)
        {
            Name=name;
        }

        public abstract void MakeSound();
        public void showInfo()
        {
            Console.WriteLine("pet Name: " + Name);
        }
    }
}
