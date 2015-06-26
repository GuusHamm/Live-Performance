namespace GuusHamm__S22.Managers
{
    #region

    using System;
    using System.Collections.Generic;

    using GuusHamm__S22.Models;

    using Oracle.DataAccess.Client;

    #endregion

    /// <summary></summary>
    public class MissionManager
    {
        /// <summary></summary>
        private ShipManager shipManager= new ShipManager();

        /// <summary></summary>
        /// <param name="description">The description.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="policeNeeded">The police needed.</param>
        /// <returns>The <see cref="MissionModel"/>.</returns>
        public MissionModel CreateSinMission(string description, int x, int y, int policeNeeded)
        {
            ShipModel shipModel = shipManager.GetClosestShip(x, y, policeNeeded);
            if (shipModel == null)
            {
                return null;
            }

            MissionModel missionModel = new MissionModel(0, shipModel.ID, DateTime.Today, description, x, y, MissionModel.MissionType.Sin, policeNeeded);

            string test = missionModel.StartDate.ToShortDateString();
            try
            {
                string query = string.Format("Insert into MISSION (ID,SHIPID,STARTDATE,DISCRIPTION,X,Y,ACTIVE,RAPPORT,MISSIONTYPE,POLICENEEDED,APPROVED,ENDDATE) values (seq_mission.nextval,'{0}',TO_TIMESTAMP('{1} 09:57:08.493000000', 'YYYY-MM-DD HH24:MI:SS.FF'),'{2}','{3}','{4}','1',null,'{5}','{6}','0',null)", missionModel.ShipId, missionModel.StartDate.ToShortDateString(), missionModel.Description, missionModel.X, missionModel.Y, missionModel.MissionTypeEnum, missionModel.PoliceNeeded);

                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                command.ExecuteNonQuery();
                
                DatabaseSettings.Commit();
                return missionModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary></summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool DeleteMission(int id)
        {
            try
            {
                string query = string.Format("delete from mission where id  = {0}", id);
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                command.ExecuteNonQuery();

                DatabaseSettings.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            

        }
        public bool DeleteReading(int id)
        {
            try
            {
                string query = string.Format("delete from reading where id  = {0}", id);
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                command.ExecuteNonQuery();

                DatabaseSettings.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        /// <summary></summary>
        /// <param name="description">The description.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="ship">The ship.</param>
        /// <returns>The <see cref="MissionModel"/>.</returns>
        public MissionModel CreateHopeMission(string description, int x, int y, DateTime startDate, DateTime endDate, ShipModel ship)
        {
            MissionModel missionModel = new MissionModel(0, ship.ID, description, startDate, x, y, MissionModel.MissionType.Hope, endDate);

            try
            {
                string query =
                    string.Format(
                        "INSERT INTO MISSION (ID, SHIPID, STARTDATE, DISCRIPTION, X, Y, ACTIVE, MISSIONTYPE, APPROVED, ENDDATE) "
                        + "VALUES (seq_mission.nextval, '{0}', TO_TIMESTAMP('{1} 11:39:02.070000000', 'YYYY-MM-DD HH24:MI:SS.FF'), '{2}', '{3}', '{4}', '0', 'HOPE', '0', TO_DATE('{5} 11:39:31', 'YYYY-MM-DD HH24:MI:SS'))", 
                        missionModel.ShipId, missionModel.StartDate.ToShortDateString(), missionModel.Description, missionModel.X, missionModel.Y, missionModel.EndDate.ToShortDateString());

                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                command.ExecuteNonQuery();

                DatabaseSettings.Commit();
                return missionModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary></summary>
        /// <returns>The <see cref="List"/>.</returns>
        public List<MissionModel> GetAllActiveMissions()
        {
            List<MissionModel> missions = new List<MissionModel>();
            MissionModel missionModel = null;

            
            try
            {
                string query = "select * from mission where active != 1";
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);

                OracleDataReader reader = command.ExecuteReader();

                // 0 1   2                             3     4   5   6        7         8    9
                // 4	28	26-06-15 11:39:02,070000000	adsd	3	3	0		HOPE		0	26-06-2015 11:39
                while (reader.Read())
                {
                    MissionModel.MissionType missionType;
                    ShipTypeModel.ShipTypeEnum.TryParse(reader[8].ToString(), true, out missionType);

                    if (missionType == MissionModel.MissionType.Hope)
                    {
                        missionModel = new MissionModel(
                            Convert.ToInt32(reader[0]), 
                            Convert.ToInt32(reader[1]), 
                            reader[3].ToString(), 
                            Convert.ToDateTime(reader[2]), 
                            Convert.ToInt32(reader[4]), 
                            Convert.ToInt32(reader[5]), 
                            missionType, 
                            Convert.ToDateTime(reader[11]));
                    }

                    missions.Add(missionModel);
                }
            }
            catch (Exception)
            {
                return null;
            }
                 
            return missions;
        }

        /// <summary></summary>
        /// <param name="id">The id.</param>
        /// <returns>The <see cref="List"/>.</returns>
        public List<ReadingModel> GetReadingsForMission(int id)
        {
            List<ReadingModel> readings = new List<ReadingModel>();

            ReadingModel readingModel = null;

            try
            {
                string query = string.Format("select * from reading where missionid ={0}", id);
                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    readingModel = new ReadingModel(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToDateTime(reader[2]), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]));
                    readings.Add(readingModel);
                }

                return readings;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary></summary>
        /// <param name="readingModel">The reading model.</param>
        /// <returns>The <see cref="ReadingModel"/>.</returns>
        public ReadingModel AddReading(ReadingModel readingModel)
        {
            
                string query =
                    string.Format(
                        "INSERT INTO READING (ID, READING, CAPTUREDATE, X, Y, MISSIONID) VALUES (seq_reading.nextval, '{0}', TO_TIMESTAMP('{1} 13:25:44.356000000', 'YYYY-MM-DD HH24:MI:SS.FF'), '{2}', '{3}', '{4}')", 
                        readingModel.Reading, 
                        readingModel.CaptureDate.ToShortDateString(), 
                        readingModel.X, 
                        readingModel.Y, 
                        readingModel.MissionID);

                OracleCommand command = new OracleCommand(query, DatabaseSettings.Connection);
                command.ExecuteNonQuery();

                DatabaseSettings.Commit();
                return readingModel;
            
        }
    }
}
