using System;
using FizzBuzz;

namespace FizzBuzz.Main
{
    class FizzBuzzMain
    {
        static void Main(string[] args)
        {
            //instantiate and create new object for class FizzBuzzClass
            FizzBuzzClass myFizz = new FizzBuzzClass();

            //Define what to count to
            for (int n = 1; n <= 100; n++) 
            {
                //Create variable and pass n into the Get method
                string myVar = myFizz.Get(n);
                
                //output myVar if meets FizzBuzz.Get method conditions else output number
                Console.WriteLine(myVar);
            }

            //Call Get method from within FizzBuzzClass

            Console.ReadLine();

        }
    }
}
