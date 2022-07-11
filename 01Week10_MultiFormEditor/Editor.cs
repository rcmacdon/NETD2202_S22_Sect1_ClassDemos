using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Week10_MultiFormEditor
{
    public partial class Editor : Form
    {

        #region Global Vars
        List<String> Planets = new List<String>();
        #endregion

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            PopulatePlanets();
            this.cboPlanets.DataSource = Planets;
            SetDefaults();
        }

        #region Custom Methods
        private void PopulatePlanets()
        {
            Planets.Add("Alderaan");
            Planets.Add("Bespin");
            Planets.Add("Coruscant");
            Planets.Add("Dagobah");
            Planets.Add("Endor");
            Planets.Add("Geonosis");
            Planets.Add("Hoth");
            Planets.Add("Jakku");
            Planets.Add("Kamino");
            Planets.Add("Mandalore");
            Planets.Add("Mustafar");
            Planets.Add("Naboo");
            Planets.Add("Scarif");
            Planets.Add("Tatooine");
            Planets.Add("Yavin");
        }

        private void SetDefaults()
        {
            lblHairColour.BackColor = Color.Gray;
            lblEyeColour.BackColor = Color.Gray;
            txtNickName.Clear();
            txtUnit.Clear();
            cboPlanets.SelectedIndex = -1;
            dtpBorn.Value = DateTime.Now;
            nudDesignation.Value = 0;
            chkDefective.Checked = false;
        }
        private void PopulateTrooper(Trooper t)
        {
            this.txtNickName.Text = t.NickName;
            this.chkDefective.Checked = t.IsDefective;
            this.nudDesignation.Value = t.Designation;
            this.cboPlanets.SelectedItem = t.HomeWorld;
            this.dtpBorn.Value = t.Born;
            this.txtUnit.Text = t.Unit;
            this.lblHairColour.BackColor = t.HairColor;
            this.lblEyeColour.BackColor = t.EyeColor;
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
