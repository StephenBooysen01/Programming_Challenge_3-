using System;
using System.Collections.Generic;
using System.Linq;



namespace DiceRoll3
{
    public abstract class Game
    {
        // create a list

         public  List<Die> listOfRoll = new List<Die>();


        
        public  void AddDie(int sides)
        {
            listOfRoll.Add(new Die()); // add die to list
        }

        
          public abstract int RollAllDice();
        



    }
}
