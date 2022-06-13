using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Week7Demo1_DroidClass
{
    public partial class Form1 : Form
    {
        private Form1()
        {
            InitializeComponent();
        }

        private void something()
        {
            int min = Droid.MinDesignationLength;
            
            Droid drd = new Droid();
            drd.Designation = "R2D2";
            drd.Owner = "Obiwon";
            drd.IsInService = true;
            drd.PrimaryColor = Color.Blue;
            drd.SecondaryColor = Color.White;
            string newDrdDesig = drd.Designation;

            Droid drd2 = new Droid("R2D3", "Obiwon", true, Color.Blue, Color.White);


            // sell drd
            drd.SellDroid("Luke Skywalker", true);
            drd2.SellDroid("Anakin Skywalker", false);


            Droid foundDroid = Droid.FindDroid("R2D2");

        }



    }

}

