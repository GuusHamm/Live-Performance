using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuusHamm__S22
{
    using GuusHamm__S22.Managers;
    using GuusHamm__S22.Models;

    public partial class MissionForm : Form
    {
        private MissionModel missionModel;

        public MissionForm(MissionModel missionModel = null)
        {
            InitializeComponent();
            if (missionModel != null)
            {
                this.missionModel = missionModel;
                
                this.AddStuff();
            }

            foreach (ShipModel shipModel in ShipManager.GetAllShips())
            {
                cbShip.Items.Add(shipModel);
            }

        }

        private void AddStuff()
        {
            List<ReadingModel> readings = MissionManager.GetReadingsForMission(missionModel.Id);
            if (readings != null)
            {
                foreach (ReadingModel readingModel in readings)
                {
                    listBox1.Items.Add(readingModel);
                }
            }
            tbDescription.Text = missionModel.Description;
            nudX.Value = missionModel.X;
            nudY.Value = missionModel.Y;
            dtpStart.Value = missionModel.StartDate;
            dtpEnd.Value = missionModel.EndDate;
            nudPoliceNeeded.Value = missionModel.PoliceNeeded;
            cbShip.SelectedItem = ShipManager.GetShipById(missionModel.ShipId);

            gbReading.Enabled = true;
        }

    private void MissionForm_Load(object sender, EventArgs e)
        {

        }

        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            gbHope.Enabled = false;
            gbSIN.Enabled = true;
        }

        private void rbHope_CheckedChanged(object sender, EventArgs e)
        {
            gbHope.Enabled = true;
            gbSIN.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rbHope.Checked)
            {
                if (cbShip.SelectedItem == null || string.IsNullOrEmpty(tbDescription.Text) || nudX.Value == 0 || nudY.Value == 0)
                {
                    MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
                    return;
                }

                this.missionModel = MissionManager.CreateHopeMission(
                    tbDescription.Text,
                    Convert.ToInt32(nudX.Value),
                    Convert.ToInt32(nudY.Value),
                    dtpStart.Value,
                    dtpEnd.Value,
                    (ShipModel)cbShip.SelectedItem);
                this.AddStuff();
            }

            if (rbSin.Checked)
            {
                if (string.IsNullOrEmpty(tbDescription.Text) || nudX.Value == 0 || nudY.Value == 0 || nudPoliceNeeded.Value == 0)
                {
                    MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
                    return;
                }
                this.missionModel = MissionManager.CreateSinMission(tbDescription.Text, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), Convert.ToInt32(nudPoliceNeeded.Value));
                if (this.missionModel != null)
                {
                    this.AddStuff();
                    MessageBox.Show("Missie toegevoegd");
                }
                else
                {
                    MessageBox.Show("Er ging iets mis");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadingModel readingModel = new ReadingModel(0,Convert.ToInt32(nudReadingReading.Value),dtpReading.Value,Convert.ToInt32(nudReadingX.Value),Convert.ToInt32(nudReadingY.Value),missionModel.Id);
            ReadingModel newReadingModel = MissionManager.AddReading(readingModel);
            if (newReadingModel != null)
            {
                MessageBox.Show("Reading toegevoegd");
                this.AddStuff();
                return;
            }
            MessageBox.Show("Oeps er ging iets mis");
            
        }
    }
}
