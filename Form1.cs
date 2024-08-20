namespace BowlingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {


              


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);

        }




        private void button2_Click(object sender, System.EventArgs e)
        {

            this.Close();

        }




        private void button3_Click(object sender, System.EventArgs e)
        {


            richTextBox1.Text = " ";
            richTextBox2.Text = " ";
            richTextBox3.Text = " ";
            richTextBox4.Text = " ";
            richTextBox5.Text = " ";
            richTextBox6.Text = " ";
            richTextBox7.Text = " ";
            richTextBox8.Text = " ";
            richTextBox9.Text = " ";
            richTextBox10.Text = " ";
            richTextBox11.Text = " ";
            richTextBox12.Text = " ";
            richTextBox13.Text = " ";
            richTextBox14.Text = " ";
            richTextBox15.Text = " ";
            richTextBox16.Text = " ";
            richTextBox17.Text = " ";
            richTextBox18.Text = " ";
            richTextBox19.Text = " ";
            richTextBox20.Text = " ";
            richTextBox21.Text = " ";
            richTextBox22.Text = " ";
            richTextBox23.Text = " ";
            richTextBox24.Text = " ";
            richTextBox25.Text = " ";
            richTextBox26.Text = " ";
            richTextBox27.Text = " ";
            richTextBox28.Text = " ";
            richTextBox29.Text = " ";
            richTextBox30.Text = " ";
            textBox1.Text = " ";







        }



            private void button1_Click(object sender, System.EventArgs e)
        {

            int roll1;
            int roll2;


            bool strike = false; // there is "carryover" when there is a strike or spare, by which I mean the total will update
            bool spare = false;             // in the next frame. This flag will trigger that

            string spare1 = "Spare!";

            string strike1 = "Strike!";

 
                
            int prevtotal = 0;

            int prevtotalnum = 0;

            for (int frames = 1; frames < 11; frames++)  // 10 frames, 3 textboxes per frame
            {



                Random rnd = new Random();
                 roll1 = rnd.Next(1, 11);

                if (roll1 < 9)
                {
                    roll2 = rnd.Next(1, 10 - roll1); // can't knoch down more than 10 pins
                }
                else roll2 = 1;
                

                

                int roll1num = (frames * 3 - 3) + 1;

                int roll2num = (frames * 3 - 3) + 2;

                int total3num = (frames * 3 - 3) + 3;

                if(frames > 1)
                {
                    prevtotalnum = ((frames - 1) * 3 - 3) + 3;

                }



      


                if (frames > 1)
                {
                                         


                    Int32.TryParse(ReturnTextBoxValue(frames - 1), out prevtotal);

                }

                /****************************************************************************************************/
                //lookback here is where I check the carryflag from previous run. If it is true, then I go back 
                // and update previous frame.

                Game game = new Game();


                if (strike == true && frames > 1)
                {



                    UpdatPrevTotal(frames -1, game.UpdateScore(roll1, roll2, prevtotal, strike, spare));

                    strike = false;

                }


                if (spare == true && frames > 1)
                {



                    UpdatPrevTotal(frames -1, game.UpdateScore(roll1, roll2, prevtotal, strike, spare));



                    spare = false;

                }

                /***************************************************************************************************************/



                /*************************************************************************************************************/
                // Now that the previous values were properly updated, recalculate prevtotal


                if (frames > 1)
                {



                    Int32.TryParse(ReturnTextBoxValue(frames - 1), out prevtotal);

                }


                /*************************************************************************************************************/



                if (roll1 + roll2 > 9 && (roll1 < 10 && roll2 < 10))
                {
                    spare = true;


                    UpdateValues(frames, game.Score(frames, roll1, roll2, prevtotal, strike, spare).ToString(), spare1, roll1.ToString());



                }
                    
                        
               if(roll1 > 9 || roll2 > 9)
                {
                    strike = true;
                  
                    UpdateValues(frames, game.Score(frames, roll1, roll2, prevtotal, strike, spare).ToString(), strike1, " ");

                    

                }

                if (roll1 + roll2 < 10)
                {

                 UpdateValues(frames, game.Score(frames, roll1, roll2, prevtotal, strike, spare).ToString(), roll2.ToString(), roll1.ToString());

                }

 

                

 
 
                  game.roll(roll1);  // add to array for validation at end

                





            }









            textBox1.Text = richTextBox28.Text;  // assign final score to prominant box




        }







        public void UpdateValues(int frame, string value1, string value2, string value3)
        {

            if (frame == 1)
            {
                richTextBox1.Text = value1 ;
                richTextBox2.Text = value2;
                richTextBox3.Text = value3;

            }

            if (frame == 2)
            {
                richTextBox4.Text = value1;
                richTextBox5.Text = value2;
                richTextBox6.Text = value3;

            }

            if (frame == 3)
            {
                richTextBox7.Text = value1;
                richTextBox8.Text = value2;
                richTextBox9.Text = value3;


            }

            if (frame == 4)
            {
                richTextBox10.Text = value1;
                richTextBox11.Text = value2;
                richTextBox12.Text = value3;

            }

            if (frame == 5)
            {
                richTextBox13.Text = value1;
                richTextBox14.Text = value2;
                richTextBox15.Text = value3;

            }

            if (frame == 6)
            {
                richTextBox16.Text = value1;
                richTextBox17.Text = value2;
                richTextBox18.Text = value3;

            }

            if (frame == 7)
            {
                richTextBox19.Text = value1;
                richTextBox20.Text = value2;
                richTextBox21.Text = value3;

            }

            if (frame == 8)
            {
                richTextBox22.Text = value1;
                richTextBox23.Text = value2;
                richTextBox24.Text = value3;


            }

            if (frame == 9)
            {
                richTextBox25.Text = value1;
                richTextBox26.Text = value2;
                richTextBox27.Text = value3;


            }

            if (frame == 10)
            {
                richTextBox28.Text = value1;
                richTextBox29.Text = value2;
                richTextBox30.Text = value3;

            }






        }





        public string ReturnTextBoxValue(int frame)
        {

            if (frame == 1)
            {
                 
                return richTextBox1.Text;

            }

            if (frame == 2)
            {
                return richTextBox4.Text;
 

            }

            if (frame == 3)
            {
               return  richTextBox7.Text ;

            }

            if (frame == 4)
            {
                return richTextBox10.Text;

            }

            if (frame == 5)
            {
                return richTextBox13.Text ;

            }

            if (frame == 6)
            {
                return richTextBox16.Text ;
              
            }

            if (frame == 7)
            {
                return  richTextBox19.Text ;

            }

            if (frame == 8)
            {
                return richTextBox22.Text  ;
                

            }

            if (frame == 9)
            {
                return  richTextBox25.Text;


            }

            if (frame == 10)
            {
                return richTextBox28.Text  ;
           

            }


            return " ";



        }




        public void UpdatPrevTotal(int frame, int value1)
        {

            if (frame == 1)
            {
                richTextBox1.Text = value1.ToString();


            }

            if (frame == 2)
            {
                richTextBox4.Text = value1.ToString();

            }

            if (frame == 3)
            {
                richTextBox7.Text = value1.ToString();


            }

            if (frame == 4)
            {
                richTextBox10.Text = value1.ToString();
    

            }

            if (frame == 5)
            {
                richTextBox13.Text = value1.ToString();

            }

            if (frame == 6)
            {
                richTextBox16.Text = value1.ToString();

            }

            if (frame == 7)
            {
                richTextBox19.Text = value1.ToString();

            }

            if (frame == 8)
            {
                richTextBox22.Text = value1.ToString();


            }

            if (frame == 9)
            {
                richTextBox25.Text = value1.ToString();


            }

            if (frame == 10)
            {
                richTextBox28.Text = value1.ToString();

            }






        }




    }
}