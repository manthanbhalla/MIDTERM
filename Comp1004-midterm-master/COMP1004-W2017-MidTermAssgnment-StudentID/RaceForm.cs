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
    public partial class RaceForm : Form
    {
        public AbilityForm previousForm;      
        private string _optedRace;        //instance variables

        private int _StrValue = Convert.ToInt32(Program.game.STR);
        private int _DexValue = Convert.ToInt32(Program.game.DEX);
        private int _EndValue = Convert.ToInt32(Program.game.END);
        private int _IntValue= Convert.ToInt32(Program.game.INT);
        private int _PerValue = Convert.ToInt32(Program.game.PER);
        private int _ChaValue = Convert.ToInt32(Program.game.CHA);


        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Game game = Program.game;

            game.Race = _optedRace;


            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        private void HumanRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            PictureBox.Image = Properties.Resources.M_Human1;
            RadioButton optedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase all abilities by 5";

            _StrValue = _StrValue + 5;
            _DexValue = _DexValue + 5;
            _EndValue = _EndValue + 5;
            _IntValue = _IntValue + 5;
            _PerValue = _PerValue + 5;
            _ChaValue = _ChaValue + 5;


            this._optedRace = optedRace.Text;
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            PictureBox.Image = Properties.Resources.M_Elf1;
            RadioButton optedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DexValue = _DexValue + 20;
            _PerValue = _PerValue + 20;

            this._optedRace = optedRace.Text;

        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PictureBox.Image = Properties.Resources.M_Dwarf1;
            RadioButton optedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _StrValue = _StrValue + 20;
            _PerValue = _PerValue + 20;
            _ChaValue = _ChaValue- 10;
            this._optedRace = optedRace.Text;

        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PictureBox.Image = Properties.Resources.M_Halfling2;
            RadioButton optedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DexValue = _DexValue + 20;
            _IntValue = _IntValue + 20;
            _StrValue = _StrValue - 10;

            this._optedRace = optedRace.Text;

        }

        private void RaceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
