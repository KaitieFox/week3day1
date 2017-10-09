using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day1 //intro to OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat mittens = new week3day1.Cat();  //this creates the name for the space which contains the cat information.

            //mittens.Name = "Mittens"; //we assign the name here. mittens is the space which presently holds the cat info.
            ////"Mittens" makes the name portion of the info stored in mittens to "Mittens".

            //Cat secondCat = new Cat("Oz", 3, "orange and white"); //must be in order
            ////Now we have created two cats, using first and second methods

            //Console.WriteLine(mittens.Name);
            //Console.WriteLine(secondCat.Name);

            //Console.WriteLine("I want to feed the cat.");
            //Console.WriteLine("Is " + mittens.Name + " hungry?" );

            //mittens.Eat();

            //mittens.WorkOut();

            //mittens.Eat();

            //mittens.WorkOut();


            //dog firstDoge = new dog();

            //firstDoge.Weight = 60.00;
            //firstDoge.Height = 3.2f;
            //firstDoge.FurLength = "flowing mane";
            //firstDoge.RunningSpeed = "will fetch...eventually.";

            //firstDoge.Groom();
            //Console.WriteLine(firstDoge.FurLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            //Console.WriteLine(firstDoge.RunningSpeed);

            //firstDoge.Bark();

            dog seconDoge = new dog("fluffy", 4.04f);
            Console.WriteLine("Lovely dog is " + seconDoge.FurLength);

            seconDoge.Groom();
            Console.WriteLine("Groom Doge, is now " + seconDoge.FurLength);

            seconDoge.RunningSpeed = "faster than lightning";
            Console.WriteLine("Groomed doge is " + seconDoge.RunningSpeed + " and is");

            seconDoge.Run();
            Console.WriteLine(seconDoge.RunningSpeed);

            seconDoge.Weight = 78.9;
            Console.WriteLine(seconDoge.Weight);

            seconDoge.Potty();
            Console.WriteLine("But now doge weighs " + seconDoge.Weight);

            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Hee hee!");


            seconDoge.Bark();













        }
    }
}
