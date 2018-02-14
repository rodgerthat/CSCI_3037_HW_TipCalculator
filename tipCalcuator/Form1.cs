using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipCalcuator
{

    public partial class Form1 : Form
    {

        double percentageToTip = 0.0;
        double amountOfBill = 0.0;
        double numberOfPeople = 0;

        double tipAmount = 0.0;
        double totalToPay = 0.0;
        double totalPerPerson = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            // check for input values
            if (string.IsNullOrEmpty(textBoxAmountOfBill.Text)
                || string.IsNullOrEmpty(textBoxPercentageToTip.Text) ) {

                // if there's missing values, generate an error message
                generateUserErrorMessage();

                return;

            }

            // input validatiLOLn, NUMBER ONLY
            // maybe l8tr

            // if everything's hokay, do some smaths

            // get the input values, which are strings and convert to doubles
            // some shenenigans here, concatenating the input string w/ a 0. to make in an 
            // insta~multiplyable floating point deimal

            percentageToTip = Convert.ToDouble( ("0." + textBoxPercentageToTip.Text ) ); 
            amountOfBill = Convert.ToDouble(textBoxAmountOfBill.Text);
            numberOfPeople = Convert.ToDouble(textBoxNumberOfPeople.Text);

            tipAmount = amountOfBill * percentageToTip;
            totalToPay = amountOfBill + tipAmount;
            totalPerPerson = totalToPay / numberOfPeople;

            // update the outputs
            textBoxTipAmount.Text = Convert.ToString(tipAmount);
            textBoxTotalToPay.Text = Convert.ToString(totalToPay);
            textBoxTotalPerPerson.Text = Convert.ToString(totalPerPerson);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // clear all text inputs. 

            textBoxAmountOfBill.Text = string.Empty;

            textBoxPercentageToTip.Text = string.Empty;

            textBoxNumberOfPeople.Text = string.Empty;

            textBoxTipAmount.Text = string.Empty;

            textBoxTotalToPay.Text = string.Empty;

            textBoxTotalPerPerson.Text = string.Empty;
        }

        private void generateUserErrorMessage()
        {
            labelWarning.Text = "Hey, you need to fill in all the top three fields";
        }
    }
}
