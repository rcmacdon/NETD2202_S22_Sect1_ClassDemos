/*
Name: Clint MacDonald
StudentID: 
Date: May 19, 2022
Title: Week 3 Demo B - Temp converter
GitHub: 
*/

#region Using Includes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace _01Week03DemoB___Temp_Converter
{
    public partial class frmMain : Form
    {

        #region Constants and Global Variables

        const double convertMultiplier = 1.8;
        const double convertAdder = 32;


        #endregion


        #region Main Form Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region UI Events

       /// <summary>
       /// Exits the application after a confirmation
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void btnExit_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Are you sure you want to exit?",
                    "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            };
           
        }

        /// <summary>
        /// Resets the entire form to its initial default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            Double inputValue, outputValue;

            inputValue = ValidateDecimal(txtInputTemp.Text);
            if (inputValue != 0)
            {
                // good conversion

                if (radC.Checked)
                {
                    outputValue = inputValue * convertMultiplier + convertAdder;
                    lblUnits.Text = "F";
                    lblAnswer.Text = outputValue.ToString();
                }
                else if (radF.Checked)
                {
                    outputValue = (inputValue - convertAdder) / (convertMultiplier);
                    lblUnits.Text = "C";
                    lblAnswer.Text = outputValue.ToString();
                }
                else
                {
                    MessageBox.Show("You must choose the input units!");
                }
            }
            else
            {
                MessageBox.Show("The input temperature is not a valid number!");
                txtInputTemp.SelectAll();
                txtInputTemp.Focus();
            }
        }
        #endregion

        #region CustomFunctions

        /// <summary>
        /// Action of resetting the form to initial defaults
        /// </summary>
        private void SetDefaults()
        {
            txtInputTemp.Clear();
            radC.Checked = false;
            radF.Checked = false;
            lblAnswer.Text = string.Empty;
            lblUnits.Text = "-";
            txtInputTemp.Focus();
        }

        private Double ValidateDecimal(string inputString)
        {
            Double retVal = -999;

            double.TryParse(inputString, out retVal);

            return retVal;
        }

        #endregion

       
    }
}
