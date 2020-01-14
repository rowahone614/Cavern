using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;

namespace Cavern
{
    public partial class GameScreen : UserControl
    {
        // things to do
        //things to do 2

        //player1 button control keys - DO NOT CHANGE
        Boolean downArrowDown, upArrowDown;

        //player2 button control keys - DO NOT CHANGE
        //Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        //TODO create your global game variables here
        int yPosition;
        int crusaderSpeed;
        SolidBrush heroBrush = new SolidBrush(Color.Black);
        Random rGen = new Random();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            //TODO - setup all your initial game values here. Use this method
            // each time you restart your game to reset all values.
            yPosition = 200;
            crusaderSpeed = 5;
            nameLabel.Text = MainForm.playerName;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // opens a pause screen is escape is pressed. Depending on what is pressed
            // on pause screen the program will either continue or exit to main menu
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }

            //TODO - basic player 1 key down bools set below. Add remainging key down
            // required for player 1 or player 2 here.

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO - basic player 1 key up bools set below. Add remainging key up
            // required for player 1 or player 2 here.

            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        public void TempMethod()
        {
            //jkalsdjflkED
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //TODO move main character        
            if (downArrowDown == true && yPosition <= this.Height - 41)
            {
                yPosition = yPosition + crusaderSpeed;
                crusaderDesign(yPosition);
            }
            if (upArrowDown == true && yPosition >= 0)
            {
                yPosition = yPosition - crusaderSpeed;
                crusaderDesign(yPosition);
            }

            TempMethod();
            //TODO collisions checks 


            //calls the GameScreen_Paint method to draw the screen.
            Refresh();
        }


        //Everything that is to be drawn on the screen should be done here
        //private void GameScreen_Paint(object sender, PaintEventArgs e)
        //{
        //    //draw rectangle to screen
        //    e.Graphics.FillRectangle(heroBrush, heroX, heroY, heroSize, heroSize);
        //}
        private void crusaderDesign(int crusaderY)
        {
            crusaderImage.Location = new Point(100, crusaderY);
        }


        private void obstacleDesign()
        {
           
            
        }
    }

}
