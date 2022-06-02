/* Name: Clint MacDonald
 * Date: June 2, 2022
 * Title: Week 5 Demo 2 - Array of Labels
 */

#region USING
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

namespace _01Week05Demo2_ArrayOfLabels
{
    public partial class frmMain : Form
    {
        #region Main Function
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variables
        string[] DogBreeds;
        Label[] DogLabel;


        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            DogBreeds = new string[]
            {
                "German Shepherd", "Doberman Pincher", "Cocker Spanial",
                "Husky", "Saint Bernhard", "Toy Poodle", "Rottweiler",
                "Bull Dog", "Border Collie", "Stray"
            };

            DogLabel = new Label[]
            {
                label1, label2, label3, label4, label5, label6,
                label7, label8
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randNum = new int();
            // loop through the array of labels
            foreach (Label lbl in DogLabel)
            {
                // gen a random number from 0 to array length -1
                randNum = GenerateRandRange(0, DogBreeds.Length - 1);

                // put the string value from the array into the label propert
                //lbl.Text = DogBreeds[randNum];
                SetLabelText(lbl, DogBreeds[randNum]);
            }
           

        }

        private void SetLabelText(Label inputLabel, String inputString)
        {
            inputLabel.Text = inputString;
        }

        private int GenerateRandRange(int min, int max)
        {
            int returnValue;

            Random r = new Random();
            returnValue = r.Next(min, max);

            return returnValue;
        }
    }
}
