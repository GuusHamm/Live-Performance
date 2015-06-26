namespace GuusHamm__S22.Managers
{
    #region

    using System;
    using System.Collections.Generic;

    using GuusHamm__S22.Models;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary></summary>
    class ShipManager
    {
        /// <summary>The get ship by id.</summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="ShipModel"/>.</returns>
        public ShipModel GetShipById(int id)
        {
            ShipModel shipModel = null;

            string query = string.Format("select s.*, st.* from Ship s join shiptype st on (s.shiptypetype = st.type) where id = {0}", id);
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
               
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ShipTypeModel.ShipTypeEnum shipType;
                        ShipTypeModel.ShipTypeEnum.TryParse(reader[2].ToString(), true, out shipType);
                        ShipTypeModel shipTypeModel = new ShipTypeModel(shipType, Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]));
                        shipModel = new ShipModel(Convert.ToInt32(reader[0]), reader[1].ToString(), shipTypeModel, Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]));
                    }

            

            return shipModel;
        }

        /// <summary></summary>
        /// <returns>The <see cref="List"/>.</returns>
        public List<ShipModel> GetAllShips()
        {
            List<ShipModel> ships = new List<ShipModel>();
            ShipModel shipModel = null;

            string query = "select s.*, st.* from Ship s join shiptype st on (s.shiptypetype = st.type) ";
            OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ShipTypeModel.ShipTypeEnum shipType;
                ShipTypeModel.ShipTypeEnum.TryParse(reader[2].ToString(), true, out shipType);
                ShipTypeModel shipTypeModel = new ShipTypeModel(shipType, Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]));
                shipModel = new ShipModel(Convert.ToInt32(reader[0]), reader[1].ToString(), shipTypeModel, Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]));
                ships.Add(shipModel);
            }



            return ships;
        }

        /// <summary></summary>
        /// <returns>The <see cref="List"/>.</returns>
        public List<ShipModel> GetAllAvailableShips()
        {
            List<ShipModel> ships = new List<ShipModel>();
            ShipModel shipModel = null;

            string query = "select s.*, st.* from Ship s join shiptype st on (s.shiptypetype = st.type) where s.id not in (select shipid from mission where active = 1) ";
            OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);

            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ShipTypeModel.ShipTypeEnum shipType;
                ShipTypeModel.ShipTypeEnum.TryParse(reader[2].ToString(), true, out shipType);
                ShipTypeModel shipTypeModel = new ShipTypeModel(shipType, Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]));
                shipModel = new ShipModel(Convert.ToInt32(reader[0]), reader[1].ToString(), shipTypeModel, Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]));
                ships.Add(shipModel);
            }



            return ships;
        }

        /// <summary></summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="policeNeeded">The police needed.</param>
        /// <returns>The <see cref="ShipModel"/>.</returns>
        public ShipModel GetClosestShip(int x, int y, int policeNeeded)
        {
            double distance = 1000;
            int id = 0;

            ShipModel shipModel = null;
                string query = string.Format(
                    "SELECT s.id,  s.x,  s.y FROM Ship s where s.id NOT IN (SELECT shipid FROM mission WHERE active = 1) and(select count(*) from crewmember cm join crewmember_ship cms on (cm.id = cms.crewmemberid) where cms.shipid = s.id and upper(job)= 'POLITIE') >= {0}", policeNeeded);
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
               
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
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

                if (id != 0)
                {
                    shipModel = this.GetShipById(id);
                }

                return shipModel;
            
        }

        /// <summary></summary>
        /// <param name="AvailableCrew">The available crew.</param>
        /// <param name="ship">The ship.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool ManShip(List<CrewMemberModel> AvailableCrew, ShipModel ship )
        {
            List<CrewMemberModel> shipsCrew = new List<CrewMemberModel>();

            // First search for a captain
            foreach (CrewMemberModel crewMemberModel in AvailableCrew)
            {
                if (crewMemberModel.Job == CrewMemberModel.JobEnum.Kapitein)
                {
                    shipsCrew.Add(crewMemberModel);
                    break;
                }
            }

            int i = 0;
            foreach (CrewMemberModel crewMemberModel in AvailableCrew)
                {
                    if (i < ship.Type.MaxCrew)
                    {
                        if (crewMemberModel.Job == CrewMemberModel.JobEnum.Bioloog
                                || crewMemberModel.Job == CrewMemberModel.JobEnum.Politie)
                        {
                             shipsCrew.Add(crewMemberModel);
                            i++;
                        }
                    }
                }
            

                foreach (CrewMemberModel crewMemberModel in shipsCrew)
                {
                    string query = string.Format(
                        "insert into crewmember_ship(shipID,crewmemberID) values({0},{1})", 
                        ship.ID, 
                        crewMemberModel.Id);
                    OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                    command.ExecuteNonQuery();
                }

            return true;
        }
    }
}
