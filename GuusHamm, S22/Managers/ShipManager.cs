namespace GuusHamm__S22.Managers
{
    #region

    using System;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    using GuusHamm__S22.Models;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary></summary>
    static class ShipManager
    {
        /// <summary>The get ship by id.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="ShipModel"/>.</returns>
        public static ShipModel GetShipById(int id)
        {
            ShipModel shipModel = null;

            using (OracleConnection connection = DatabaseManager.Connection)
            {
                string query = string.Format("select s.*, st.* from Ship s join shiptype st on (s.type = st.type) where id = {0};", id);
                OracleCommand command = new OracleCommand(query, connection);
                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ShipTypeModel.ShipTypeEnum shipType;
                        ShipTypeModel.ShipTypeEnum.TryParse(reader[2].ToString(), true, out shipType);
                        ShipTypeModel shipTypeModel = new ShipTypeModel(shipType, Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]));
                        shipModel = new ShipModel(Convert.ToInt32(reader[0]), reader[1].ToString(), shipTypeModel, Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return shipModel;
        }

        /// <summary></summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="policeNeeded">The police needed.</param>
        /// <returns>The <see cref="ShipModel"/>.</returns>
        public static ShipModel GetClosestShip(int x, int y, int policeNeeded)
        {
            double distance = 1000;
            int id = 0;

            ShipModel shipModel = null;
            using (OracleConnection connection = DatabaseManager.Connection)
            {
                string query =
                    "select id,x,y, count(cm.*) from Ship s join CrewMemberShip cms on (s.id = cms.ShipId) join CrewMember cm on (cms.crewmemberId = cm.id)  where s.id not in (select shipid from mission where active = 1)) and upper(cm.job) = upper('politie')";
                OracleCommand command = new OracleCommand(query, connection);
                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader[3]) >= policeNeeded)
                        {
                            int a = x - Convert.ToInt32(reader[1]);
                            int b = y - Convert.ToInt32(reader[2]);

                            double newDistance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                            if (newDistance < distance)
                            {
                                distance = newDistance;
                                id = Convert.ToInt32(reader[0]);
                            }
                            
                        }
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (id != 0)
                {
                    shipModel = ShipManager.GetShipById(id);
                }

                return shipModel;
            }
        }
    }
}
