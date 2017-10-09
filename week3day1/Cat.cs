using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3day1  //intro to OOP
{
    class Cat  
    {
        //STATES
        //two types of states:: 
        //::fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;


        //::properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //make one property for each field.
        //so can only access name through deafault constructor at this point.





        //BEHAVIOURS


        //Constructors
        public Cat()
        {
            //default constructor because it takes no parameters in parentheses
            //inside curly braces are called body.
            //default constructor title hinges on parentheses.
            //can still have stuff in body
        }
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
            //we are creating two ways to create a cat object. one default way, one where we can assign value immediately.
            //This allows you to very quickly create similar objects. The two methods.
            //You always need a default constructor.
            //this. is called a pointer. Involves specificity.
        }

        //Methods. The actiony bits.

        public void Eat()
        {
            if(isHungry == true)
            {
                isHungry = false;
            }

            Console.WriteLine("Is the cat hungry? " + isHungry );
        }

        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }
            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }



    }
}
