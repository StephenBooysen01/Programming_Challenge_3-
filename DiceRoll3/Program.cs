using System;
using System.Collections.Generic;
using System.Linq;


namespace DiceRoll3
{
    public class Program
    {

        // ask people if they want to roll a dice 
        static void Main(string[] args)
        {
            // varibles 

            ClGame DuhNewGame = new ClGame (); 
            
            //DuhNewGame.Results.Add(1);

            while(true)
            {
                 // ask if they want to roll
            Console.WriteLine("do you want to roll a dice ? type yes or no");
           string  playerAnswer = Console.ReadLine().ToLower();
           
            int NumDie;
            // evulate anser
            if(playerAnswer == "yes")
            {
                // run the game and ask 
                Console.WriteLine("how many die will you run");
                NumDie = Int32.Parse(Console.ReadLine());

                // add dice to dice list  list 

                for(int i = 0; i < NumDie; i ++)
                {
                    
                    DuhNewGame.AddDie(NumDie); // add.
                    
                    
                }

               DuhNewGame.RollAllDice();
          
                
                // extrac options 

                Console.WriteLine("Would you like the Avarge, press 1");
                Console.WriteLine("Would you like the Total, press 2");
                Console.WriteLine("Would you like the list of what you rolled, press 3");
                string secondAnswer= Console.ReadLine();

                switch (secondAnswer)
                {
                    case "1" : 
                    {
                        // avarge 
                        Console.WriteLine("Avarge is " + DuhNewGame.GetAverage());
                        break;
                    }
                    case "2" :
                    {
                        // total
                        Console.WriteLine("Total is " +  DuhNewGame.GetTotal());
                        break;

                    }
                    case "3":
                    {
                        Console.WriteLine("List of rolls are");
                              // display List 

                        foreach(int i in DuhNewGame.Results )
                        {
                            Console.WriteLine(i);
                        }
                        break;


                    }
                    default:
                    {
                        Console.WriteLine("not an answer try agian");
                        break;

                    }

                }
              
                



            }
            else
            {
                // run the game and ask 
                Console.WriteLine("Goodbye");
                break;
                
            }

            }
           
           


        }
    }
}



/*                foreach(int i in ClGame.Results)
                {
                    Console.WriteLine(i);

                }
                */
