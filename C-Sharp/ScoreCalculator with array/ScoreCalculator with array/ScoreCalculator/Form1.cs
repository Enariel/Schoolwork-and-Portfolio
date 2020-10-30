using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Oliver Conover
    Prof Brioso
    C#
    8-1 & 8-2
 */

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare and initialize scores array/list;
        //8-1: private int[] scores = new int[20];

        //8-2
        private List<int> scores = new List<int>();

        int total = 0;
        //int count = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);
            total += score;
            //8-2 
            //Add score to list;
            scores.Add(score);
            int count = scores.Count();
            //Set the score at index of [count];
            //8-1 scores[count] = score;
            //count += 1;
            int average = total / count;
            txtScoreTotal.Text = total.ToString();
            txtScoreCount.Text = count.ToString();
            txtAverage.Text = average.ToString();
            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            //count = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            //Create an empty array of size 20, and set scores equal to it to clear it;
            //8-1 int[] clear = new int[20];
            //8-1 scores = clear;
            //8-2 score list is cleared by intantiating it as a new list;
            scores = new List<int>();
            txtScore.Focus();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {
            //Make sure there is something in the list/array
            if (scores != null)
            {
                //8-1 Array.Sort(scores);
                //8-2 sort list;
                scores.Sort();
                string scoreMsg = "";
                foreach (int score in scores)
                {
                    //If a score is 0 it is assumed null;
                    if (score > 0)
                    {
                        scoreMsg += score.ToString() + "\n";
                    }
                }
                MessageBox.Show(scoreMsg, "Scores: Sorted");
                txtScore.Focus();
            }
        }
    }
}