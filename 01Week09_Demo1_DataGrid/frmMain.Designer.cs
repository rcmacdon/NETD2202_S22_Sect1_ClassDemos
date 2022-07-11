
namespace _01Week09_Demo1_DataGrid
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
            this.dgvTroopers = new System.Windows.Forms.DataGridView();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDefection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroopers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTroopers
            // 
            this.dgvTroopers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTroopers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTroopers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Designation,
            this.NickName,
            this.IsDefection});
            this.dgvTroopers.Location = new System.Drawing.Point(12, 12);
            this.dgvTroopers.MultiSelect = false;
            this.dgvTroopers.Name = "dgvTroopers";
            this.dgvTroopers.RowTemplate.Height = 25;
            this.dgvTroopers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTroopers.Size = new System.Drawing.Size(773, 329);
            this.dgvTroopers.TabIndex = 0;
            this.dgvTroopers.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "ID";
            this.Designation.Name = "Designation";
            this.Designation.Width = 50;
            // 
            // NickName
            // 
            this.NickName.DataPropertyName = "NickName";
            this.NickName.HeaderText = "Nick Name";
            this.NickName.Name = "NickName";
            // 
            // IsDefection
            // 
            this.IsDefection.DataPropertyName = "IsDefective";
            this.IsDefection.HeaderText = "Defective";
            this.IsDefection.Name = "IsDefection";
            this.IsDefection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDefection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(13, 364);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(121, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Sample Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(709, 363);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(151, 364);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(155, 23);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Add One New Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 407);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dgvTroopers);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTroopers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTroopers;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDefection;
    }
}
