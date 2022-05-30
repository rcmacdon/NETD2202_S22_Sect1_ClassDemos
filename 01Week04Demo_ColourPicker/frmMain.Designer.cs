
namespace _01Week04Demo_ColourPicker
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAddColour = new System.Windows.Forms.Label();
            this.btnAddColour = new System.Windows.Forms.Button();
            this.txtAddColourManually = new System.Windows.Forms.TextBox();
            this.btnAddColourManually = new System.Windows.Forms.Button();
            this.lblAvailableColours = new System.Windows.Forms.Label();
            this.lbxAvailableColours = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.lbxFavColours = new System.Windows.Forms.ListBox();
            this.lblFavColours = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ttpMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddTestColours = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.Black;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(-1, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(311, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Favorite Colour Picker";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddColour
            // 
            this.lblAddColour.AutoSize = true;
            this.lblAddColour.Location = new System.Drawing.Point(12, 47);
            this.lblAddColour.Name = "lblAddColour";
            this.lblAddColour.Size = new System.Drawing.Size(68, 15);
            this.lblAddColour.TabIndex = 1;
            this.lblAddColour.Text = "Add Colour";
            // 
            // btnAddColour
            // 
            this.btnAddColour.Location = new System.Drawing.Point(12, 68);
            this.btnAddColour.Name = "btnAddColour";
            this.btnAddColour.Size = new System.Drawing.Size(75, 23);
            this.btnAddColour.TabIndex = 2;
            this.btnAddColour.Text = "&Add";
            this.ttpMainForm.SetToolTip(this.btnAddColour, "Use a colour dialogue to choose a colour");
            this.btnAddColour.UseVisualStyleBackColor = true;
            this.btnAddColour.Click += new System.EventHandler(this.btnAddColour_Click);
            // 
            // txtAddColourManually
            // 
            this.txtAddColourManually.Location = new System.Drawing.Point(118, 39);
            this.txtAddColourManually.Name = "txtAddColourManually";
            this.txtAddColourManually.Size = new System.Drawing.Size(100, 23);
            this.txtAddColourManually.TabIndex = 3;
            this.ttpMainForm.SetToolTip(this.txtAddColourManually, "Manually type in a colour name");
            // 
            // btnAddColourManually
            // 
            this.btnAddColourManually.Location = new System.Drawing.Point(118, 67);
            this.btnAddColourManually.Name = "btnAddColourManually";
            this.btnAddColourManually.Size = new System.Drawing.Size(100, 23);
            this.btnAddColourManually.TabIndex = 4;
            this.btnAddColourManually.Text = "Add &Manually";
            this.ttpMainForm.SetToolTip(this.btnAddColourManually, "Add the colour typed in above to the colour list");
            this.btnAddColourManually.UseVisualStyleBackColor = true;
            this.btnAddColourManually.Click += new System.EventHandler(this.btnAddColourManually_Click);
            // 
            // lblAvailableColours
            // 
            this.lblAvailableColours.AutoSize = true;
            this.lblAvailableColours.Location = new System.Drawing.Point(13, 113);
            this.lblAvailableColours.Name = "lblAvailableColours";
            this.lblAvailableColours.Size = new System.Drawing.Size(99, 15);
            this.lblAvailableColours.TabIndex = 5;
            this.lblAvailableColours.Text = "A&vailable Colours";
            // 
            // lbxAvailableColours
            // 
            this.lbxAvailableColours.FormattingEnabled = true;
            this.lbxAvailableColours.ItemHeight = 15;
            this.lbxAvailableColours.Location = new System.Drawing.Point(12, 132);
            this.lbxAvailableColours.Name = "lbxAvailableColours";
            this.lbxAvailableColours.Size = new System.Drawing.Size(120, 199);
            this.lbxAvailableColours.TabIndex = 6;
            this.ttpMainForm.SetToolTip(this.lbxAvailableColours, "List of available colours to choose from");
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(138, 183);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(35, 35);
            this.btnMoveRight.TabIndex = 7;
            this.btnMoveRight.Text = ">>";
            this.ttpMainForm.SetToolTip(this.btnMoveRight, "Move a colour from the available list to the favorites list");
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(138, 224);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(35, 35);
            this.btnMoveLeft.TabIndex = 8;
            this.btnMoveLeft.Text = "<<";
            this.ttpMainForm.SetToolTip(this.btnMoveLeft, "Move a colour from the favorites list to the available list");
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // lbxFavColours
            // 
            this.lbxFavColours.FormattingEnabled = true;
            this.lbxFavColours.ItemHeight = 15;
            this.lbxFavColours.Location = new System.Drawing.Point(179, 132);
            this.lbxFavColours.Name = "lbxFavColours";
            this.lbxFavColours.Size = new System.Drawing.Size(120, 199);
            this.lbxFavColours.TabIndex = 10;
            this.ttpMainForm.SetToolTip(this.lbxFavColours, "List of colours the user has chosen as their favorites");
            // 
            // lblFavColours
            // 
            this.lblFavColours.AutoSize = true;
            this.lblFavColours.Location = new System.Drawing.Point(180, 113);
            this.lblFavColours.Name = "lblFavColours";
            this.lblFavColours.Size = new System.Drawing.Size(93, 15);
            this.lblFavColours.TabIndex = 9;
            this.lblFavColours.Text = "&Favorite Colours";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(12, 338);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(287, 94);
            this.lblOutput.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(243, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.ttpMainForm.SetToolTip(this.btnExit, "Exits the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 436);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 45);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Re&set";
            this.ttpMainForm.SetToolTip(this.btnReset, "Reset the form to its default values");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddTestColours
            // 
            this.btnAddTestColours.Location = new System.Drawing.Point(12, 457);
            this.btnAddTestColours.Name = "btnAddTestColours";
            this.btnAddTestColours.Size = new System.Drawing.Size(75, 23);
            this.btnAddTestColours.TabIndex = 14;
            this.btnAddTestColours.Text = "Add Test Colours";
            this.btnAddTestColours.UseVisualStyleBackColor = true;
            this.btnAddTestColours.Click += new System.EventHandler(this.btnAddTestColours_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddColourManually;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(308, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddTestColours);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lbxFavColours);
            this.Controls.Add(this.lblFavColours);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lbxAvailableColours);
            this.Controls.Add(this.lblAvailableColours);
            this.Controls.Add(this.btnAddColourManually);
            this.Controls.Add(this.txtAddColourManually);
            this.Controls.Add(this.btnAddColour);
            this.Controls.Add(this.lblAddColour);
            this.Controls.Add(this.lblHeader);
            this.MaximumSize = new System.Drawing.Size(324, 527);
            this.MinimumSize = new System.Drawing.Size(324, 527);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favorite Colour Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAddColour;
        private System.Windows.Forms.Button btnAddColour;
        private System.Windows.Forms.ToolTip ttpMainForm;
        private System.Windows.Forms.TextBox txtAddColourManually;
        private System.Windows.Forms.Button btnAddColourManually;
        private System.Windows.Forms.Label lblAvailableColours;
        private System.Windows.Forms.ListBox lbxAvailableColours;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.ListBox lbxFavColours;
        private System.Windows.Forms.Label lblFavColours;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddTestColours;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

