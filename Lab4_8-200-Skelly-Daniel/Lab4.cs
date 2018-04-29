using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_8_200_Skelly_Daniel
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }



        int scoreCount = 0;                                                //variable for score count. starts at 0 until how many times the user clicks "Add"
        int scoreTotal = 0;                                                //declared variable for the total score
        int average = 0;
     
        private void addScore_Click(object sender, EventArgs e)            //event handler when user clicks "Add"
        {
            int score = Convert.ToInt32(txtScore.Text);                    //converts the textbox string to an int
      

            scoreCount++;                                                  //increases score count by 1 every time a user clicks "Add"
            scoreTotal += score;                                           //sets the converted variable txtScore to the Score Total box and increases every time user clicks "Add"                     
            average = scoreTotal / scoreCount;                             //divides the total score to the number of times user clicks "Add" for the averages
           

            //these three lines of code below converts the value to a string object
            txtScoreCount.Text = scoreCount.ToString();
            txtScoreTotal.Text = scoreTotal.ToString();
            txtAverage.Text = average.ToString();

            txtScore.Text = "";                                            //displays the score field as an empty string
            txtScore.Focus();                                              //sets input focus to the control
        }

        private void clearScore_Click(object sender, System.EventArgs e)   //event handler when user clicks "Clear"
        {

            //three statements below resets the class variables back to zero
            scoreCount = 0;
            scoreTotal = 0;
            average = 0;

            //the three statements below set the text boxes that display the variables to empty strings
            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();                                             //sets input focus to the control

        }

        private void exit_Click(object sender, EventArgs e)               //Event handler when user clicks "Exit"
        {
            this.Close();                                     
        }
    }
}
