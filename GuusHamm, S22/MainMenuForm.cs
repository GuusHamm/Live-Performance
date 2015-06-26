namespace GuusHamm__S22
{
    #region

    using System;
    using System.Windows.Forms;

    using GuusHamm__S22.Managers;
    using GuusHamm__S22.Models;

    #endregion

    /// <summary></summary>
    public partial class MainMenuForm : Form
    {
        /// <summary></summary>
        private CrewManager crewManager = new CrewManager();

        /// <summary></summary>
        private MissionManager missionManager = new MissionManager();

        /// <summary></summary>
        private ShipManager shipManager = new ShipManager();

        /// <summary>Initializes a new instance of the <see cref="MainMenuForm"/> class.</summary>
        public MainMenuForm()
        {
            this.InitializeComponent();
            DatabaseSettings.Initialize();
            
            foreach (MissionModel allActiveMission in missionManager.GetAllActiveMissions())
            {
                lbActiveMissions.Items.Add(allActiveMission);
            }
             
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (this.tbPassword.Text != null || this.tbUsername.Text != null)
            {
                if (crewManager.LogInCrewMember(tbUsername.Text, tbPassword.Text))
                {
                    MessageBox.Show("Succesvol ingelogd");
                }
                else
                {
                    MessageBox.Show("Foute combinatie");
                }
                
            }
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void btnCreateaMission_Click(object sender, EventArgs e)
        {
            MissionForm mission = new MissionForm();
            mission.Show();
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ShipModel shipModel in shipManager.GetAllShips())
            {
                shipManager.ManShip(crewManager.GetAvailableCrewMembers(), shipModel);
            }
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            MissionForm mission = new MissionForm((MissionModel)lbActiveMissions.SelectedItem);
            mission.Show();
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            MissionModel missionModel = (MissionModel)lbActiveMissions.SelectedItem;
            if (missionManager.DeleteMission(missionModel.Id))
            {
                MessageBox.Show("Succes"); 
                lbActiveMissions.Items.Clear();
                foreach (MissionModel allActiveMission in missionManager.GetAllActiveMissions())
                {
                    lbActiveMissions.Items.Add(allActiveMission);
                }
            }
        }
    }
}
