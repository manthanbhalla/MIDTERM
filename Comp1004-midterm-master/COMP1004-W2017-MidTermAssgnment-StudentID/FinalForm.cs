using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }


        //displaying data in text boxes by calling the variables
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Stats();
            if (raceTextBox.Text == "Human")
            {
                pictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (raceTextBox.Text == "Elf")
            {
                pictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (raceTextBox.Text == "Dwarf")
            {
                pictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if (raceTextBox.Text == "Halfling")
            {
                pictureBox.Image = Properties.Resources.M_Halfling2;
            }
        }


        /// A message will be sent to printer for printing
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer");
        }

        
        /// The program will be closed when clicked on Exit button
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


 
        /// The font of the labels and the text box will be changed 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontDialog.ShowDialog();
            nameTextBox.Font = fontDialog.Font;
            heightTextBox.Font = fontDialog.Font;
            ageTextBox.Font = fontDialog.Font;
            weightTextBox.Font = fontDialog.Font;
            jobTextBox.Font = fontDialog.Font;
            raceTextBox.Font = fontDialog.Font;
            healthTextBox.Font = fontDialog.Font;
            nameLabel.Font = fontDialog.Font;
            ageLabel.Font = fontDialog.Font;
            heightLabel.Font = fontDialog.Font;
            weightLabel.Font = fontDialog.Font;
            jobLabel.Font = fontDialog.Font;
            raceLabel.Font = fontDialog.Font;
            healthPointsLabel.Font = fontDialog.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();

            AboutBox.ShowDialog();
        }

        public void Stats()
        {
            healthTextBox.Text = Program.game.Health;
            raceTextBox.Text = Program.game.Race;
            jobTextBox.Text = Program.game.Job;
            STRTextBox.Text = Program.game.STR;
            DEXTextBox.Text = Program.game.DEX;
            ENDTextBox.Text = Program.game.END;
            INTTextBox.Text = Program.game.INT;
            PERTextBox.Text = Program.game.PER;
            CHATextBox.Text = Program.game.CHA;
        }
    }
}
