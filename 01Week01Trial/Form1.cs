/* Comment Header
 * Name: Clint MacDonald
 * StudentID: 100######
 * Date: May 5, 2022
 * Title: Week 1 Demo File - Section 1
 */ 


using System;
using System.Drawing;
using System.Windows.Forms;

namespace _01Week01Trial
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblMyName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
