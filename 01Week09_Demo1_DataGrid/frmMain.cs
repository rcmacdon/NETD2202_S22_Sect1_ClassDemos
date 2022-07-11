using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Week09_Demo1_DataGrid
{
    public partial class frmMain : Form
    {

        #region Global Variables
        bool DoSelectionChange = false;

        #endregion
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Trooper.troopers.AddRange(Trooper.GetSampleTroopers());
            UpdateDataGrid();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            Trooper trp = new Trooper("George", "Endor", new DateTime(1965, 03, 07), "Orange", false,
                        Color.Black, Color.Blue);
            Trooper.troopers.Add(trp);
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            DoSelectionChange = false;
            dgvTroopers.DataSource = null;
            dgvTroopers.DataSource = Trooper.troopers;
            dgvTroopers.ClearSelection();
            DoSelectionChange = true;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (DoSelectionChange && dgvTroopers.SelectedRows.Count > 0) 
            { 
                String desigSelected = dgvTroopers.SelectedRows[0].Cells[0].Value.ToString();
                String homeWorld = dgvTroopers.SelectedRows[0].Cells[2].Value.ToString();
                MessageBox.Show(desigSelected + " - " + homeWorld);
            }
        }
    }
}
