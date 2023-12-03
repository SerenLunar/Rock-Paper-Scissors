using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxRock1_Click(object sender, EventArgs e)
        {
            pictureBoxRock1.Enabled = false;
            pictureBoxPaper1.Visible = false;
            pictureBoxScissors1.Visible = false;
        }

        private void pictureBoxPaper1_Click(object sender, EventArgs e)
        {
            pictureBoxPaper1.Enabled = false;
            pictureBoxRock1.Visible = false;
            pictureBoxScissors1.Visible = false;
        }

        private void pictureBoxScissors1_Click(object sender, EventArgs e)
        {
            pictureBoxScissors1.Enabled = false;
            pictureBoxRock1.Visible = false;
            pictureBoxPaper1.Visible = false;
        }

        private void pictureBoxRock2_Click(object sender, EventArgs e)
        {
            pictureBoxRock2.Enabled = false;
            pictureBoxScissors2.Visible = false;
            pictureBoxPaper2.Visible = false;
        }

        private void pictureBoxPaper2_Click(object sender, EventArgs e)
        {
            pictureBoxPaper2.Enabled=false;
            pictureBoxRock2.Visible=false;
            pictureBoxScissors2.Visible=false;
        }

        private void pictureBoxScissors2_Click(object sender, EventArgs e)
        {
            pictureBoxScissors2.Enabled=false;
            pictureBoxRock2.Visible=false;
            pictureBoxPaper2.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Stop();
            timer2.Start();
            if (pictureBoxPaper1.Enabled == true &&
                pictureBoxRock1.Enabled == true &&
                pictureBoxScissors1.Enabled == true)
            {
                MessageBox.Show("Önce seçim edin!!!");
                timer1.Start();
            }
            else
            {
                pictureBoxPaper1.Visible = false;
                pictureBoxRock1.Visible = false;
                pictureBoxScissors1.Visible = false;
                pictureBoxOk1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            if (pictureBoxPaper2.Enabled == true &&
                pictureBoxRock2.Enabled == true &&
                pictureBoxScissors2.Enabled == true)
            {
                timer2.Start();
                MessageBox.Show("Önce seçim edin!!!");
            }
            else
            {
                pictureBoxPaper2.Visible = false;
                pictureBoxRock2.Visible = false;
                pictureBoxScissors2.Visible = false;
                pictureBoxOk2.Visible = true;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            
            string score1 = labelScore1.Text;
            string score2 = labelScore2.Text;
            int say1 = 0;
            int say2 = 0;
            say1 = Convert.ToInt32(score1);
            say2 = Convert.ToInt32(score2);

                if (pictureBoxOk1.Visible == false && pictureBoxOk2.Visible == false)
                {
                    MessageBox.Show("Önce seçimlerinizi edin!!!");
                }
                else if (pictureBoxPaper1.Enabled == pictureBoxPaper2.Enabled &&
                    pictureBoxRock1.Enabled == pictureBoxRock2.Enabled &&
                    pictureBoxScissors1.Enabled == pictureBoxScissors2.Enabled)
                {
                    MessageBox.Show("None");
                }
                else if (pictureBoxRock1.Enabled == pictureBoxScissors2.Enabled &&
                    pictureBoxPaper1.Enabled == pictureBoxRock2.Enabled &&
                    pictureBoxScissors1.Enabled == pictureBoxPaper2.Enabled)
                {
                    say1 = say1 + 1;
                    labelScore1.Text = say1.ToString();
                    MessageBox.Show("Player1 Win " + "ScoreP1:" + labelScore1.Text + " ScoreP2:" + labelScore2.Text);
                    if (say1 == 3 && say2 < 3)
                    {
                     DialogResult result = MessageBox.Show("***OYUNUN QALIBI PLAYER1***\n\n", "Yeniden baslamaq isteyirsiniz?", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        {
                        labelScore1.Text = "0";
                        labelScore2.Text = "0";
                    }
                        else if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                }
                else if (pictureBoxRock2.Enabled == pictureBoxScissors1.Enabled &&
                    pictureBoxPaper2.Enabled == pictureBoxRock1.Enabled &&
                    pictureBoxScissors2.Enabled == pictureBoxPaper1.Enabled)
                {
                    say2 = say2 + 1;
                    labelScore2.Text = say2.ToString();
                    MessageBox.Show("Player 2 Win " + "ScoreP1:" + labelScore1.Text + " ScoreP2:" + labelScore2.Text);
                    if (say1 < 3 && say2 == 3) 
                    {
                    DialogResult result = MessageBox.Show("***OYUNUN QALIBI PLAYER2***\n\n", "Yeniden baslamaq isteyirsiniz?", MessageBoxButtons.YesNo);
                          if(result == DialogResult.Yes) 
                          {
                        labelScore1.Text = "0";
                        labelScore2.Text = "0";
                          }
                          else if (result == DialogResult.No)
                          {
                             this.Close();
                          }
                    }
                }
            pictureBoxPaper1.Visible = true;
            pictureBoxRock1.Visible = true;
            pictureBoxScissors1.Visible = true;
            pictureBoxPaper2.Visible = true;
            pictureBoxRock2.Visible = true;
            pictureBoxScissors2.Visible = true;

            pictureBoxOk1.Visible = false;
            pictureBoxOk2.Visible = false;

            pictureBoxPaper1.Enabled = true;
            pictureBoxPaper2.Enabled = true;
            pictureBoxScissors1.Enabled = true;
            pictureBoxScissors2.Enabled = true;
            pictureBoxRock1.Enabled = true;
            pictureBoxRock2.Enabled = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("isleyir");
            
           int time = Convert.ToInt32(labelPl1.Text);
           time++;
           labelPl1.Text = time.ToString();
            if (time >=15)
            {
                timer1.Stop();
                MessageBox.Show("vaxtiniz bitmisdir, gedis random edildi");
                List<PictureBox> enabledPictureBoxes = new List<PictureBox>();
                if (pictureBoxPaper1.Enabled && pictureBoxRock1.Enabled && pictureBoxScissors1.Enabled)

                {
                    enabledPictureBoxes.Add(pictureBoxPaper1);
                    enabledPictureBoxes.Add(pictureBoxRock1);
                    enabledPictureBoxes.Add(pictureBoxScissors1);
                }

                Random random = new Random();
                int randomIndex = random.Next(enabledPictureBoxes.Count);
                PictureBox selectedPictureBox = enabledPictureBoxes[randomIndex];

                selectedPictureBox.Enabled = false;
                selectedPictureBox.Visible = false;
                pictureBoxPaper1.Visible= false;
                pictureBoxRock1.Visible= false;
                pictureBoxScissors1.Visible= false;
                pictureBoxOk1.Visible = true;

                timer2.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int time = Convert.ToInt32(labelPl2.Text);
            time++;
            labelPl2.Text = time.ToString();
            if (time >= 15)
            {
                timer2.Stop();
                MessageBox.Show("vaxtiniz bitmisdir, gedis random edildi");
                List<PictureBox> enabledPictureBoxes = new List<PictureBox>();

                if (pictureBoxPaper2.Enabled && pictureBoxRock2.Enabled && pictureBoxScissors2.Enabled)

                {
                    enabledPictureBoxes.Add(pictureBoxPaper2);
                    enabledPictureBoxes.Add(pictureBoxRock2);
                    enabledPictureBoxes.Add(pictureBoxScissors2);
                }

                Random random = new Random();
                int randomIndex = random.Next(enabledPictureBoxes.Count);
                PictureBox selectedPictureBox = enabledPictureBoxes[randomIndex];

                selectedPictureBox.Enabled = false;
                selectedPictureBox.Visible = false;
                pictureBoxPaper2.Visible = false;
                pictureBoxRock2.Visible = false;
                pictureBoxScissors2.Visible = false;
                pictureBoxOk2.Visible = true;
            }
        }
    }
}
