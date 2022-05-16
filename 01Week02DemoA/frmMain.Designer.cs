
namespace _01Week02DemoA
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(-1, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(410, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "My Adder";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(107, 76);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 15);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "&X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(107, 95);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(30, 23);
            this.txtX.TabIndex = 2;
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlus.Location = new System.Drawing.Point(143, 93);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(25, 25);
            this.lblPlus.TabIndex = 3;
            this.lblPlus.Text = "+";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(174, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 15);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "&Y";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(174, 95);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(30, 23);
            this.txtY.TabIndex = 5;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquals.Location = new System.Drawing.Point(218, 93);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(25, 25);
            this.lblEquals.TabIndex = 6;
            this.lblEquals.Text = "=";
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(249, 95);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(70, 23);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "-";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 135);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(174, 135);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Re&set";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 135);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(408, 212);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblHeader);
            this.MaximumSize = new System.Drawing.Size(424, 251);
            this.MinimumSize = new System.Drawing.Size(424, 251);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 02 Demo A - My Adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

