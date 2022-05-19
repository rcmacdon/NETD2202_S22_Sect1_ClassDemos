
namespace _01Week03DemoB___Temp_Converter
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInputTemp = new System.Windows.Forms.TextBox();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radF = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttpMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderTitle.Location = new System.Drawing.Point(13, 13);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(280, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Temperature Converter";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(24, 62);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(131, 20);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "&Input Temperature";
            // 
            // txtInputTemp
            // 
            this.txtInputTemp.Location = new System.Drawing.Point(24, 86);
            this.txtInputTemp.Name = "txtInputTemp";
            this.txtInputTemp.Size = new System.Drawing.Size(125, 27);
            this.txtInputTemp.TabIndex = 2;
            this.ttpMainForm.SetToolTip(this.txtInputTemp, "Enter your numeric input temperature value");
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(162, 86);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(39, 24);
            this.radC.TabIndex = 3;
            this.radC.TabStop = true;
            this.radC.Text = "&C";
            this.ttpMainForm.SetToolTip(this.radC, "Click here to choose Celcius");
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Location = new System.Drawing.Point(208, 86);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(37, 24);
            this.radF.TabIndex = 4;
            this.radF.TabStop = true;
            this.radF.Text = "&F";
            this.ttpMainForm.SetToolTip(this.radF, "Click here to choose Fahrenheit");
            this.radF.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(261, 83);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Con&vert";
            this.ttpMainForm.SetToolTip(this.btnConvert, "Execute the conversion process");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(389, 84);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(62, 25);
            this.lblAnswer.TabIndex = 6;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(458, 83);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(15, 20);
            this.lblSymbol.TabIndex = 7;
            this.lblSymbol.Text = "°";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(469, 86);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(15, 20);
            this.lblUnits.TabIndex = 8;
            this.lblUnits.Text = "-";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(261, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Re&set";
            this.ttpMainForm.SetToolTip(this.btnReset, "Reset the form to initial defaults");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(361, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.ttpMainForm.SetToolTip(this.btnExit, "Exit the Application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(511, 198);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.radF);
            this.Controls.Add(this.radC);
            this.Controls.Add(this.txtInputTemp);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblHeaderTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 03 Demo B Temperature Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInputTemp;
        private System.Windows.Forms.ToolTip ttpMainForm;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

