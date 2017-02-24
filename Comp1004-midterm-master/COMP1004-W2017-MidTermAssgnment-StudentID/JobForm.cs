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
    public partial class JobForm : Form
    {

        private string _jobSelected;

        public RaceForm previousForm;

        private int _soldierHealthPoint = 30;
        private int _rogueHealthPoint = 28;
        private int _magickerHealthPoint = 15;
        private int _cultistHealthPoint = 24;


        private int _DexHealthValue = Convert.ToInt32(Program.game.DEX);
        private int _EndHealthValue = Convert.ToInt32(Program.game.END);
        private int _IntHealthValue = Convert.ToInt32(Program.game.INT);
        private int _ChaHealthValue = Convert.ToInt32(Program.game.CHA);




        //constructor
        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Game game = Program.game;
           game.Job = _jobSelected;
            game.Health = healthTextBox.Text;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthTextBox.Text = (_soldierHealthPoint + _EndHealthValue).ToString();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthTextBox.Text = (_rogueHealthPoint + _DexHealthValue).ToString();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthTextBox.Text = (_magickerHealthPoint + _IntHealthValue).ToString();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedJob = (RadioButton)sender;
            this._jobSelected = selectedJob.Text;
            healthTextBox.Text = (_cultistHealthPoint + _ChaHealthValue).ToString();
        }

        private void jobGroupBox_Enter(object sender, EventArgs e)
        {


        }

        private void RadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
