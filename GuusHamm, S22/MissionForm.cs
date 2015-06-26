namespace GuusHamm__S22
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using GuusHamm__S22.Managers;
    using GuusHamm__S22.Models;

    #endregion

    /// <summary></summary>
    public partial class MissionForm : Form
    {
        /// <summary></summary>
        private MissionManager missionManager = new MissionManager();

        /// <summary></summary>
        private MissionModel missionModel;

        /// <summary></summary>
        private ShipManager shipManager = new ShipManager();

        /// <summary>Initializes a new instance of the <see cref="MissionForm"/> class.</summary>
        /// <param name="missionModel">The mission model.</param>
        public MissionForm(MissionModel missionModel = null)
        {
            InitializeComponent();
            if (missionModel != null)
            {
                this.missionModel = missionModel;
                
                this.AddStuff();
            }

            foreach (ShipModel shipModel in shipManager.GetAllShips())
            {
                cbShip.Items.Add(shipModel);
            }

        }

        /// <summary></summary>
        private void AddStuff()
        {
            List<ReadingModel> readings = missionManager.GetReadingsForMission(missionModel.Id);
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
            cbShip.SelectedItem = shipManager.GetShipById(missionModel.ShipId);

            gbReading.Enabled = true;
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void MissionForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            gbHope.Enabled = false;
            gbSIN.Enabled = true;
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void rbHope_CheckedChanged(object sender, EventArgs e)
        {
            gbHope.Enabled = true;
            gbSIN.Enabled = false;
        }

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (rbHope.Checked)
            {
                if (cbShip.SelectedItem == null || string.IsNullOrEmpty(tbDescription.Text) || nudX.Value == 0 || nudY.Value == 0)
                {
                    MessageBox.Show("Niet alle gegevens zijn correct ingevuld");
                    return;
                }

                this.missionModel = missionManager.CreateHopeMission(
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

                this.missionModel = missionManager.CreateSinMission(tbDescription.Text, Convert.ToInt32(nudX.Value), Convert.ToInt32(nudY.Value), Convert.ToInt32(nudPoliceNeeded.Value));
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

        /// <summary></summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            ReadingModel readingModel = new ReadingModel(0, Convert.ToInt32(nudReadingReading.Value), dtpReading.Value, Convert.ToInt32(nudReadingX.Value), Convert.ToInt32(nudReadingY.Value), missionModel.Id);
            ReadingModel newReadingModel = missionManager.AddReading(readingModel);
            if (newReadingModel != null)
            {
                MessageBox.Show("Reading toegevoegd");
                this.AddStuff();
                return;
            }

            MessageBox.Show("Oeps er ging iets mis");
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ReadingModel readingModel = (ReadingModel)listBox1.SelectedItem;
            nudReadingX.Value = readingModel.X;
            nudReadingY.Value = readingModel.Y;
            dtpReading.Value = readingModel.CaptureDate;
            nudReadingReading.Value = readingModel.Reading;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadingModel readingModel = (ReadingModel)listBox1.SelectedItem;
            missionManager.DeleteReading(readingModel.Id);
        }
    }
}
