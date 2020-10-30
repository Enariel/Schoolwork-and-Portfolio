using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Oliver(Matthew) Conover
/// Prof. Brioso
/// C# Score Calculator
/// </summary>

namespace ScoreCalculator
{
    public partial class frmScoreCalc : Form
    {
        private float scoresTotaled, scoreAverage;
        private int score;
        private List<int> scores;
        public frmScoreCalc()
        {
            InitializeComponent();
            scores = new List<int>();
        }

        private int ScoreList(int score)
        {
            scores.Add(score);
            return scores.Count;
        }

        private float ScoreTotal(List<int> scores)
        {
            scoresTotaled = 0;
            for (int i = 0; i <= scores.Count - 1; i++)
            {
                scoresTotaled += scores[i];
            }
            return scoresTotaled;
        }

        private float CalculateAverage()
        {
            scoreAverage = ScoreTotal(scores) / scores.Count;
            return scoreAverage;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Add entered score to list of scores
            score = Convert.ToInt32(scoreEntry.Text);
            scoreCountBox.Text = ScoreList(score).ToString();
            scoreTotalBox.Text = ScoreTotal(scores).ToString();
            averageBox.Text = CalculateAverage().ToString();
        }

        private void clearScores_Click(object sender, EventArgs e)
        {
            //Clear list of scores
            scores.Clear();
            //Null all information in textboxes
            scoreCountBox.Text = "0";
            scoreTotalBox.Text = "0";
            averageBox.Text = "0";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
