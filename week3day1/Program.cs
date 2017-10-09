using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat mittens = new week3day1.Cat();  //this creates the name for the space which contains the cat information.

            mittens.Name = "Mittens"; //we assign the name here. mittens is the space which presently holds the cat info.
            //"Mittens" makes the name portion of the info stored in mittens to "Mittens".

            Cat secondCat = new Cat("Oz", 3, "orange and white"); //must be in order
            //Now we have created two cats, using first and second methods

            Console.WriteLine(mittens.Name);
            Console.WriteLine(secondCat.Name);

            Console.WriteLine("I want to feed the cat.");
            Console.WriteLine("Is " + mittens.Name + " hungry?" );

            mittens.Eat();

            mittens.WorkOut();

            mittens.Eat();

            mittens.WorkOut();







        }
    }
}
