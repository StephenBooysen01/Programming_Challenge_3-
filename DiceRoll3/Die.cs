// populate a list of dies 
using System;
namespace DiceRoll3
{
    public  class Die
    {
        // create a list
         
        public  int sides { get; set; }

        // constructor 
        public Die( int pDieface)
        {
            sides = pDieface;

        }
        // 
        public  Die(){sides = 6;}
        // function 

        public int Roll ()
        {
            // generate random number 1-6
            Random numRan = new Random();
            int dieResult = new Random().Next(1,sides + 1); // generate number 
            Console.WriteLine($"Sides = {sides}");
            return dieResult;
            

        }

        public int GetDieSide(Die a)
        {
            return sides;

        }
       


   
    }
}
