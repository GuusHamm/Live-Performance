namespace GuusHamm__S22
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using GuusHamm__S22.Managers;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary></summary>
    public partial class Form1 : Form
    {
        /// <summary>Initializes a new instance of the <see cref="Form1"/> class.</summary>
        public Form1()
        {
            this.InitializeComponent();
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
    }
}
