
namespace _01Week11_FileIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvClones = new System.Windows.Forms.DataGridView();
            this.colDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefective = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClones
            // 
            this.dgvClones.AllowUserToAddRows = false;
            this.dgvClones.AllowUserToDeleteRows = false;
            this.dgvClones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClones.BackgroundColor = System.Drawing.Color.Black;
            this.dgvClones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesignation,
            this.colNickName,
            this.dataGridViewTextBoxColumn1,
            this.colBorn,
            this.dataGridViewTextBoxColumn2,
            this.colDefective,
            this.colHairColor,
            this.colEyeColor});
            this.dgvClones.Location = new System.Drawing.Point(14, 52);
            this.dgvClones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClones.MultiSelect = false;
            this.dgvClones.Name = "dgvClones";
            this.dgvClones.ReadOnly = true;
            this.dgvClones.RowHeadersVisible = false;
            this.dgvClones.RowHeadersWidth = 51;
            this.dgvClones.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dgvClones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvClones.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(0)))));
            this.dgvClones.RowTemplate.Height = 25;
            this.dgvClones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClones.ShowEditingIcon = false;
            this.dgvClones.Size = new System.Drawing.Size(1041, 296);
            this.dgvClones.TabIndex = 1;
            this.dgvClones.VirtualMode = true;
            this.dgvClones.SelectionChanged += new System.EventHandler(this.Selected_Trooper);
            // 
            // colDesignation
            // 
            this.colDesignation.DataPropertyName = "Designation";
            this.colDesignation.HeaderText = "Designation";
            this.colDesignation.MinimumWidth = 6;
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.ReadOnly = true;
            this.colDesignation.Width = 125;
            // 
            // colNickName
            // 
            this.colNickName.DataPropertyName = "NickName";
            this.colNickName.HeaderText = "Nick Name";
            this.colNickName.MinimumWidth = 6;
            this.colNickName.Name = "colNickName";
            this.colNickName.ReadOnly = true;
            this.colNickName.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HomeWorld";
            this.dataGridViewTextBoxColumn1.HeaderText = "Home World";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // colBorn
            // 
            this.colBorn.DataPropertyName = "Born";
            this.colBorn.HeaderText = "Born";
            this.colBorn.MinimumWidth = 6;
            this.colBorn.Name = "colBorn";
            this.colBorn.ReadOnly = true;
            this.colBorn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // colDefective
            // 
            this.colDefective.DataPropertyName = "IsDefective";
            this.colDefective.HeaderText = "Defective";
            this.colDefective.MinimumWidth = 6;
            this.colDefective.Name = "colDefective";
            this.colDefective.ReadOnly = true;
            this.colDefective.Width = 125;
            // 
            // colHairColor
            // 
            this.colHairColor.DataPropertyName = "HairColor";
            this.colHairColor.HeaderText = "Hair Colour";
            this.colHairColor.MinimumWidth = 6;
            this.colHairColor.Name = "colHairColor";
            this.colHairColor.ReadOnly = true;
            this.colHairColor.Width = 125;
            // 
            // colEyeColor
            // 
            this.colEyeColor.DataPropertyName = "EyeColor";
            this.colEyeColor.HeaderText = "Eye Colour";
            this.colEyeColor.MinimumWidth = 6;
            this.colEyeColor.Name = "colEyeColor";
            this.colEyeColor.ReadOnly = true;
            this.colEyeColor.Width = 125;
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitleBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleBar.ForeColor = System.Drawing.Color.Black;
            this.lblTitleBar.Location = new System.Drawing.Point(1, 1);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(1066, 47);
            this.lblTitleBar.TabIndex = 3;
            this.lblTitleBar.Text = "Clone Inventory";
            this.lblTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(29, 356);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(93, 79);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(828, 356);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 79);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save\r\nto File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(927, 356);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(93, 79);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "&Load from File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "CSV Files|*.csv|Text Files|*.txt ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV Files|*.csv|Text Files|*.txt";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 356);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 79);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 744);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblTitleBar);
            this.Controls.Add(this.dgvClones);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Droid Factory";
            this.Activated += new System.EventHandler(this.RefreshForm);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClones;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDefective;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHairColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEyeColor;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClear;
    }
}

