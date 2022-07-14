/* Author: Clint MacDonald
 * StudentID: 100######
 * Date: July 7, 2022
 * Title: ICE 4 - Trooper Inventory
 */
#region USING statements
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

namespace _01Week10_MultiFormEditor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<String> Planets = new List<String>();
        Boolean DoGridSelectionChange = false;
        #endregion

        #region EVENT HANDLERS
        /// <summary>
        /// Main form loading commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            Trooper.troopers.AddRange(Trooper.GetSampleTroopers());
            UpdateDataGrid();
        }

        #endregion

        #region CUSTOM METHODS

        private void UpdateDataGrid()
        {
            DoGridSelectionChange = false;
            dgvClones.DataSource = null;
            dgvClones.DataSource = Trooper.troopers;
            dgvClones.ClearSelection();
            DoGridSelectionChange = true;
        }

        #endregion

        private void Selected_Trooper(object sender, EventArgs e)
        {
            if (DoGridSelectionChange && dgvClones.SelectedRows.Count > 0)
            {
                //MessageBox.Show(dgvClones.SelectedRows[0].Cells[1].Value.ToString());
                int trooperID = int.Parse(dgvClones.SelectedRows[0].Cells[0].Value.ToString());
                Editor frmEditor = new Editor(trooperID);
                frmEditor.ShowDialog();

                //Trooper trp = Trooper.FindTrooper(trooperID);
                //PopulateTrooper(trp);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Editor frmEditor = new Editor();
            frmEditor.ShowDialog();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            //MessageBox.Show("Hey I am here");
            UpdateDataGrid();
        }
    }
}
