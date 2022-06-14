using System;
using System.Collections.Generic;
using System.Linq;


namespace DiceRoll3
{
    public class ClGame:Game
    {
        // create a list

        public List<int> Results = new List<int>(); // resault

        public string Name { get; set; }
      
      // function 

      // GetAverage()

        public override  int RollAllDice()
        { 
             // roll the dice 
                foreach(Die i in listOfRoll)
                {
                    Results.Add(i.Roll()); // add die
                }

            
            return 1;
        }

        public double GetAverage() // avarge
        {
       
            // sum and display
            double total = Double.Parse(GetTotal().ToString()); //
            double avrage = total/ Results.Count;

            return avrage;
        }


      // get total

        public int GetTotal()
        {
            int Total = Results.Sum();
            return Total;
        }

        public void SetResults(int[] nums){
            Results = nums.ToList();
        }

    }
}
