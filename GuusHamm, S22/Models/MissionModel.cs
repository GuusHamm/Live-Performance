namespace GuusHamm__S22.Models
{
    #region

    using System;

    #endregion

    /// <summary></summary>
    public class MissionModel
    {
        /// <summary>The mission type.</summary>
        public enum MissionType
        {
            /// <summary></summary>
            Sin, 

            /// <summary></summary>
            Hope
        }

        /// <summary>Initializes a new instance of the SIN Mission.</summary>
        /// <param name="id">The id.</param>
        /// <param name="shipId">The ship id.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="description">The description.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="missionTypeEnum">The mission type enum.</param>
        /// <param name="policeNeeded">The police needed.</param>
        public MissionModel(int id, int shipId, DateTime startDate, string description, int x, int y, MissionType missionTypeEnum, int policeNeeded)
        {
            if (id != 0)
            {
                this.Id = id;
            }

            this.ShipId = shipId;
            this.StartDate = startDate;
            this.Description = description;
            this.X = x;
            this.Y = y;
            this.MissionTypeEnum = missionTypeEnum;
            if (missionTypeEnum == MissionType.Sin)
            {
                this.PoliceNeeded = policeNeeded;
            }
        }

        /// <summary>Initializes a new instance of the HOPE Mission.</summary>
        /// <param name="id">The id.</param>
        /// <param name="shipId">The ship id.</param>
        /// <param name="description">The description.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="missionTypeEnum">The mission type enum.</param>
        /// <param name="endDate">The end date.</param>
        public MissionModel(int id, int shipId, string description, DateTime startDate, int x, int y, MissionType missionTypeEnum, DateTime endDate)
        {
            if (id != 0)
            {
                this.Id = id;
            }

            this.ShipId = shipId;
            this.Description = description;
            this.StartDate = startDate;
            this.X = x;
            this.Y = y;
            this.MissionTypeEnum = missionTypeEnum;
            if (missionTypeEnum == MissionType.Hope)
            {
                this.Approved = false;
                this.EndDate = endDate;
            }
        }

        /// <summary>Gets the id.</summary>
        public int Id { get; private set; }

        /// <summary>Gets the ship id.</summary>
        public int ShipId { get; private set; }

        /// <summary>Gets the start date.</summary>
        public DateTime StartDate { get; private set; }

        /// <summary>Gets the description.</summary>
        public string Description { get; private set; }

        /// <summary>Gets the x.</summary>
        public int X { get; private set; }

        /// <summary>Gets the y.</summary>
        public int Y { get; private set; }

        /// <summary>Gets the rapport.</summary>
        public string Rapport { get; private set; }

        /// <summary>Gets the mission type enum.</summary>
        public MissionType MissionTypeEnum { get; private set; }

        /// <summary>Gets the police needed.</summary>
        public int PoliceNeeded { get; private set; }

        /// <summary>Gets a value indicating whether approved.</summary>
        public bool Approved { get; private set; }

        /// <summary>Gets the end date.</summary>
        public DateTime EndDate { get; private set; }
    }
}
