namespace BowlingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }




        private void button1_Click(object sender, System.EventArgs e)
        {


            bool strike = false; // there is "carryover" when there is a strike or spare, by which I mean the total will update
            bool spare = false;             // in the next frame. This flag will trigger that


            int prevtotal = 0;

            int prevtotalnum = 0;

            for (int frames = 1; frames < 11; frames++)  // 10 frames, 3 textboxes per frame
            {



                Random rnd = new Random();
                int roll1 = rnd.Next(1, 11);
                int roll2 = rnd.Next(1, 11);

                

                int roll1num = (frames * 3 - 3) + 1;

                int roll2num = (frames * 3 - 3) + 2;

                int total3num = (frames * 3 - 3) + 3;

                if(frames > 1)
                {
                    prevtotalnum = ((frames - 1) * 3 - 3) + 3;

                }

               

                RichTextBox richTB = new RichTextBox();

                richTB.Name = "richTextBox" + roll1num;

                richTB.Text = roll1.ToString();

                if(frames > 1)
                {

                    richTB.Name = "richTextBox" + prevtotalnum;


                    Int32.TryParse(richTB.Text, out prevtotal);

                }

    


                richTB.Name = "richTextBox" + roll2num;


                //lookback here is where I check the carryflag from previous run. If it is true, then I go back 
                // and update previous frame.

                Game game = new Game();

                if (strike == true)
                {

                    game.Score(frames, roll1, roll2, prevtotal).ToString();


                }


                if (spare == true)
                {

                    game.Score(frames, roll1, roll2, prevtotal).ToString();


                }



                if (roll1 + roll2 > 9 && (roll1 < 10 && roll2 < 10))
                {
                    spare = true;
                    richTB.Text = "Spare!";

                }
                    
                        
               if(roll1 > 9 || roll2 > 9)
                {
                    strike = true;
                    richTB.Text = "Strike!";

                }

                if (roll1 + roll2 < 10)
                {

                    richTB.Text = roll2.ToString();
                }


                richTB.Name = "richTextBox" + total3num;

                

                

                richTB.Text = game.Score(frames, roll1, roll2, prevtotal, 0).ToString();



 
                  game.roll(roll1);  // add to array for validation at end

                





            }









            textBox1.Text = richTextBox28.Text;  // assign final score to prominant box




        }









    }
}