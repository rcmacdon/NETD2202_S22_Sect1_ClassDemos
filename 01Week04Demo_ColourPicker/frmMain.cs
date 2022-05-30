/* Name: Clint MacDonald
 * Student ID: 100######
 * Date: May 28, 2022
 * Title: NETD2202 - Week 04 - class demo
 */

#region Using and global variables
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

namespace _01Week04Demo_ColourPicker
{
    public partial class frmMain : Form
    {

        #region Main function
        public frmMain()
        {
            InitializeComponent();
        }





        #endregion

        #region Click Events
        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        /// <summary>
        /// Resets the form objects back to their default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Open a colour dialogue allowing the user to choose a colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColour_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                lbxAvailableColours.Items.Add(colorDialog.Color.Name);
            }
        }

        /// <summary>
        /// Adding the text typed into the textbox to the available colours list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddColourManually_Click(object sender, EventArgs e)
        {
            if (txtAddColourManually.Text.Trim().Length > 2)
            {
                lbxAvailableColours.Items.Add(ProfanityFilter(txtAddColourManually.Text.Trim()));
                lblOutput.Text = txtAddColourManually.Text.Trim() + " was added successfully!";
                txtAddColourManually.Clear();
                txtAddColourManually.Focus();
            }
            else
            {
                lblOutput.Text = "The name of the colour is not valid!";
            }
        }

        /// <summary>
        /// Move a string from the available colours list to the favorite colours list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lbxAvailableColours.SelectedItems.Count > 0)
            {
                lbxFavColours.Items.Add(lbxAvailableColours.SelectedItem);
                lbxAvailableColours.Items.Remove(lbxAvailableColours.SelectedItem);
                ShowColours();
            }
            else
            {
                lblOutput.Text = "No available colours have been selected, cancelling operation!";
            }
        }

        /// <summary>
        /// Move a string from the favorites colour list to the available colours list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
           if (lbxFavColours.SelectedItems.Count > 0)
           {
                lbxAvailableColours.Items.Add(lbxFavColours.SelectedItem);
                lbxFavColours.Items.Remove(lbxFavColours.SelectedItem);
                ShowColours();
           }
           else
            {
                lblOutput.Text = "No favorite colours have been selected, cancelling operation!";
            }
        }

        /// <summary>
        /// Add some test colours to the available colours box just for testing purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTestColours_Click(object sender, EventArgs e)
        {
            lbxAvailableColours.Items.Add("Red");
            lbxAvailableColours.Items.Add("Blue");
            lbxAvailableColours.Items.Add("Green");
            lbxAvailableColours.Items.Add("Yellow");
        }
        #endregion

        #region Custom Methods

        #region Application Operations

        /// <summary>
        /// Exits the application upon a confirmation
        /// </summary>
        private void ExitApplication()
        {
            if(MessageBox.Show("Are you sure you want to exit the application?",
                                "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Sets all form objects to their initial default values
        /// </summary>
        private void SetDefaults()
        {
            // Clear the text boxes and labels
            txtAddColourManually.Clear();
            lblOutput.Text = string.Empty;

            // Clear the listboxes
            lbxAvailableColours.Items.Clear();
            lbxFavColours.Items.Clear();
        }

        /// <summary>
        /// receives a string input and checks for specific profanities and replaces the
        /// profanity with a "nice" word!
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private string ProfanityFilter(string inputString)
        {
            string returnString = inputString;

            switch (inputString.Trim().ToLower())
            {
                case "shit":
                    returnString = "poop";
                    break;
                case "fuck":
                    returnString = "fudge";
                    break;
                case "damn":
                    returnString = "darn";
                    break;
                default:
                    returnString = inputString;
                    break;
            }

            return returnString;
        }


        #endregion

        #region Colour Operations

        /// <summary>
        /// Display a string listing the favorite colours currently listed
        /// </summary>
        private void ShowColours()
        {
            string myOutput = string.Empty;

            // iterate through all items in the fav colour list to build an output string
            for (int i = 0; i < lbxFavColours.Items.Count; i++)
            {
                myOutput += lbxFavColours.Items[i].ToString();
                // anything but the last item
                if (i < lbxFavColours.Items.Count - 1)
                {
                    myOutput += ", ";
                }
            }
            // output the result to the output label
            lblOutput.Text = myOutput;
        }
        #endregion

        #endregion

        #region Looping Samples

        private string WhileLoop()
        {
            int counter = 0;
            string output = string.Empty;

            while(counter <= 10)
            {
                output += counter.ToString();
                // if not the last number
                if (counter < 10) output += ", ";

                counter++;
            }

            return output;
        }

        private string DoWhileLoop()
        {
            int counter = 0;
            string output = string.Empty;

            do
            {
                output += counter.ToString();
                // if not the last number
                if (counter < 10) output += ", ";

                counter++;
            } while (counter <= 10);

            return output;
        }

        private string ForLoop()
        {
            string output = string.Empty;

            for (int counter = 0; counter < 10; counter++)
            {
                output += counter.ToString();
                // if not the last number
                if (counter < 10) output += ", ";
            } 

            return output;
        }

        private string ForEachLoop()
        {
            string output = string.Empty;
            int counter = 0;

            foreach (object myItem in lbxAvailableColours.Items)
            {
                output += myItem.ToString();
                // if not the last number
                if (counter < lbxAvailableColours.Items.Count) output += ", ";
                counter++;
            }
            return output;
        }


        #endregion


    }
}
