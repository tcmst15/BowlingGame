
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



       // properly update previous frame with new score


        public int UpdateScore(int frames, int rl1, int rl2, int rl3, bool strike, bool prevstrike, bool spare, bool prevspare) // calculate score for this frame only
        {

            int total = 0;

         if(prevspare == true)
            {

              total =  rl3 + rl1;


            } else
           
                if ((strike == true && prevstrike == true) || (strike == true && prevspare == true))
                {
                total = 10 + rl3;

            }
            else if((spare == true && prevspare == true) || (spare == true && prevstrike == true))
                {
                total = rl1 + rl3;

            } else if(prevstrike == true && strike == false && spare == false)
            {
                total = rl1 + rl2 + rl3;

            } else if(prevspare == true && spare == false && strike == false)
            {
                total = rl1 + rl3;

            }
            


            return total;
        }







       


  




    }


 


}