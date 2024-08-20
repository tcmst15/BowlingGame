
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


      


   

        public int Score(int frame, int rl1, int rl2, int rl3, bool strike, bool spare) // calculate score for this frame only
        {
 
            int total = 0;
       
               if(frame == 1)
            {


                if (spare == true)
                {
                    total = 10 ;

                }
                else if (strike == true)
                {
                    total = 10 ;

                }

                else
                {

                    total = rl1 + rl2 ;

                }




            }
            else
            {
                if (spare == true)
                {
                    total = 10 + rl3;

                } else if(strike == true)
                {
                    total = 10  + rl3;

                }
             
                else
                {

                    total = rl1 + rl2 + rl3 ;

                }



            }
                               
            
            return total;
        }



        //UpdatPrevTotal(frames -1, game.UpdateScore(roll1, roll2, prevtotal, strike, spare));


        public int UpdateScore(int rl1, int rl2, int rl3, bool strike, bool spare) // calculate score for this frame only
        {

            int total = 0;

         
           
                if (strike == true)
                {
                total =  rl1 + rl2 + rl3;

            }
            else if(spare == true)
                {
                total = rl1 + rl3;

            }
            


            return total;
        }







        public bool  roll(int pins)
        {
            
            scores_array.Add(pins);


            return true;

              
        
        }

       


  




    }


 


}