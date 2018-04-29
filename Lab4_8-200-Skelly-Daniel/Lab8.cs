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
    public partial class Lab8 : Form
    {
        public Lab8()
        {
            InitializeComponent();
        }


        int[] scoresArray = new int[20];                                    //declares array and assigns it at a length of 20
     
        int scoreCount = 0;                                  
        int scoreTotal = 0;                                                
        int average = 0;

        private void addScore_Click(object sender, EventArgs e)
        {

      
            try {
                if (IsValidData())
                {
                    int score = Convert.ToInt32(txtScore.Text);
                    scoresArray[scoreCount] = score;                                     //add score count into the array every time the user clicks "Add"

                    scoreCount++;
                    scoreTotal += score;
                    average = scoreTotal / scoreCount;

            

                    txtScore.Text = score.ToString();
                    txtScoreCount.Text = scoreCount.ToString();
                    txtScoreTotal.Text = scoreTotal.ToString();
                    txtAverage.Text = average.ToString();

                    txtScore.Text = "";
                    txtScore.Focus();
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
            }

        private void clearScore_Click(object sender, System.EventArgs e)  
        {
            scoresArray = new int[20];                                                  //clears the array that lists the scores every time the user clicks "Clear"
        
            scoreCount = 0;
            scoreTotal = 0;
            average = 0;


            txtScoreCount.Text = "";
            txtScoreTotal.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();                                     

        }

        public bool IsValidData()                                                       //data validation that checks to see if user enters the score number in the right format and range
        {
            return
                IsPresent(txtScore, "score") &&
                IsInt32(txtScore, "score") &&
                IsWithinRange(txtScore, "score", 1, 100);
        }

        public bool IsPresent(TextBox textBox, string name)                             //alerts the user that the score text field is empty when they click "Add"
        {
            if (textBox.Text == "") {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textBox, string name)                                //alerts the user that the score text field is entered in the wrong format and must be an integer
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)                   //alerts the user if they enter a number below 1 or above 100
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }



        private void exit_Click(object sender, EventArgs e)               
        {
            this.Close();                                     
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {
          Array.Sort(scoresArray);                                                                           //sorts the scores the user entered
            string scoresString = "";                                                                        //after sorting scores, this string contains the score values in ascending order
            foreach (int i in scoresArray)                          
                if (i != 0)
                {
                    scoresString += i.ToString() + "\n";
                }
            MessageBox.Show(scoresString, "Sorted Scores");                                                  //popup box that lists all the scores the user entered
        }
    }
}
