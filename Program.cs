
using System.Collections;

namespace BowlingGame
{
      class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            

        }
    }




    public class Game
    {


        ArrayList scores_array = new ArrayList();


         int PinCount(int pinPosition)
        {
            return (int)scores_array[pinPosition];
        }


        public int Score(int frame, int rl1, int rl2, int rl3, int rl4) // calculate score for this frame only
        {
 
            int total = 0;
       
               if(frame == 1)
            {
                total = rl1 + rl2;
            }
            else
            {

                total = rl1 + rl2 + rl3 + rl4;

            }
                               
            
            return total;
        }









        public bool  roll(int pins)
        {
            
            scores_array.Add(pins);


            return true;

              
        
        }

        public void frames()
        {









        }


        int score1()
        {
            int total = 0;



            foreach (var score in scores_array)
            {
                total += (int)score;
            }



            scores_array.Clear();

            return total; 

        }





    }


 


}