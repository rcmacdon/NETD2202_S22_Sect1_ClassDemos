using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Week06Demo1_PlayingWithCollections
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Global Variables
        const int NumLabels = 10;
        List<Label> TheLabels = new List<Label>();

        // Lists, Queues, and Stacks are generic collections
        // List is a object thrown in a box in random order
        // Queue is FIFO lineup (like a line at a bar)
        // Stack is LIFO pile (like a stack of books)
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            Label myLabel = new Label();
            myLabel.Name = "lblHeader";
            myLabel.Text = "Week 6 Demo 1";
            myLabel.AutoSize = false;
            myLabel.Top = 0;
            myLabel.Left = 0;
            myLabel.Height = 40;
            myLabel.Width = this.Width;

            myLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left |AnchorStyles.Right;
            myLabel.BackColor = Color.Black;
            myLabel.ForeColor = Color.White;

            myLabel.TextAlign = ContentAlignment.MiddleCenter;
            myLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            this.Controls.Add(myLabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl;

            for (int i = 0; i < NumLabels; i++)
            {
                lbl = new Label();
                lbl.Name = "lblMyLabel" + i.ToString();
                lbl.Text = "Label " + i.ToString();

                TheLabels.Add(lbl); // adding labels to the generic collection (List)
            }

            // do math stuff to organize it, but essentially then use a for each loop
            int Left = 10;
            int Top = button1.Top + button1.Height + 10;

            foreach(Label lbl2 in TheLabels)
            {
                lbl2.Left = Left;
                lbl2.Top = Top;
                this.Controls.Add(lbl2);
                
                Left = 10; // would be calc if needed
                Top += lbl2.Height + 5;
            }

        }
    }
}
