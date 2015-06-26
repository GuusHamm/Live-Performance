namespace GuusHamm__S22
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using GuusHamm__S22.Managers;
    using GuusHamm__S22.Models;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary></summary>
    public partial class MainMenuForm : Form
    {

        /// <summary>Initializes a new instance of the <see cref="MainMenuForm"/> class.</summary>
        public MainMenuForm()
        {
            this.InitializeComponent();
            DatabaseManager.Initialize();
            
            foreach (MissionModel allActiveMission in MissionManager.GetAllActiveMissions())
            {
                lbActiveMissions.Items.Add(allActiveMission);
            }
             
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (this.tbPassword.Text != null || this.tbUsername.Text != null)
            {
                if (CrewManager.LogInCrewMember(tbUsername.Text, tbPassword.Text))
                {
                    MessageBox.Show("Succesvol ingelogd");
                }
                else
                {
                    MessageBox.Show("Foute combinatie");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShipModel newShipModel = ShipManager.GetClosestShip(500, 745, 2);
        }

        private void btnCreateaMission_Click(object sender, EventArgs e)
        {
            MissionForm mission = new MissionForm();
            mission.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ShipModel shipModel in ShipManager.GetAllShips())
            {
                ShipManager.ManShip(CrewManager.GetAvailableCrewMembers(), shipModel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MissionForm mission = new MissionForm((MissionModel)lbActiveMissions.SelectedItem);
            mission.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MissionModel missionModel = (MissionModel)lbActiveMissions.SelectedItem;
            if (MissionManager.DeleteMission(missionModel.Id))
            {
                MessageBox.Show("Succes"); 
                lbActiveMissions.Items.Clear();
                foreach (MissionModel allActiveMission in MissionManager.GetAllActiveMissions())
                {
                    lbActiveMissions.Items.Add(allActiveMission);
                }
            }
        }
    }
}
