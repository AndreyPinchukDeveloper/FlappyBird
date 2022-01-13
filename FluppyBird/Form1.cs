using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluppyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 6;
            }
        }

        private void newTimer(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeButtom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            ScoreText.Text = "Score : "+score;

            if (pipeButtom.Left<-150)
            {
                pipeButtom.Left = 650;
                score++;
                pipeSpeed++;
            }
            if (pipeTop.Left <-180)
            {
                pipeTop.Left = 850;
                score++;
                pipeSpeed++;
            }
            if (Bird.Bounds.IntersectsWith(pipeButtom.Bounds)||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds)||
                Bird.Bounds.IntersectsWith(ground.Bounds)||
                Bird.Top<-25)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            ScoreText.Text = "Your score is: "+ score+ " Game over!";
        }
    }
}
