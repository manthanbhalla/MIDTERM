using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// Program: Midterm DND Character Creator
/// Name: Manthan Bhalla
/// StudentID: 200331757
/// App Creation Date: Feb 24,2017
/// App Description: A character is created which is used for different characteristics

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class AbilityForm : Form
    {
       
        // Random Number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method gives the result
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
         
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }

            return result;
        }


        //display the result in text boxes

        private void RollAbilities()
        {
            STRTextBox.Text = this.Roll3D10().ToString();
            DEXTextBox.Text = this.Roll3D10().ToString();
            ENDTextBox.Text = this.Roll3D10().ToString();
            INTTextBox.Text = this.Roll3D10().ToString();
            PERTextBox.Text = this.Roll3D10().ToString();
            CHATextBox.Text = this.Roll3D10().ToString();
        }


        private void RollButton_Click(object sender, EventArgs e)
        {
            RollAbilities();
            Debug.WriteLine(Roll3D10().ToString());
        }


        //initializing values by using try and catch validation method
        private void NextButton_Click(object sender, EventArgs e)
        {
            Game game = Program.game;

            try
            {

                game.STR = STRTextBox.Text;
                game.DEX = DEXTextBox.Text;
                game.END = ENDTextBox.Text;
                game.INT = INTTextBox.Text;
                game.PER = PERTextBox.Text;
                game.CHA = CHATextBox.Text;

                if (STRTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (DEXTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (ENDTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (INTTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (PERTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (CHATextBox.Text == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fill a valid response or press roll");
                return;
            }
            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }

        private void AbilityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
