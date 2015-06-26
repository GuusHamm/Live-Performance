namespace GuusHamm__S22.Models
{
    #region

    using System;

    #endregion

    /// <summary></summary>
    public class ReadingModel
    {
        /// <summary>Initializes a new instance of the <see cref="ReadingModel"/> class.</summary>
        /// <param name="id">The id.</param>
        /// <param name="reading">The reading.</param>
        /// <param name="captureDate">The capture date.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="missionId">The mission id.</param>
        public ReadingModel(int id, int reading, DateTime captureDate, int x, int y, int missionId)
        {
            if (id != 0)
            {
                this.Id = id;
            }

            this.Reading = reading;
            this.CaptureDate = captureDate;
            this.X = x;
            this.Y = y;
            this.MissionID = missionId;
        }

        /// <summary>Gets the id.</summary>
        public int Id { get; private set; }

        /// <summary>Gets the reading.</summary>
        public int Reading { get; private set; }

        /// <summary>Gets the capture date.</summary>
        public DateTime CaptureDate { get; private set; }

        /// <summary>Gets the x.</summary>
        public int X { get; private set; }

        /// <summary>Gets the y.</summary>
        public int Y { get; private set; }

        /// <summary>Gets the mission id.</summary>
        public int MissionID { get; private set; }
    }
}
