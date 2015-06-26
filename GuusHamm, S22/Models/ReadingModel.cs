using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22.Models
{
    public class ReadingModel
    {
        public int Id { get; private set; }

        public int Reading { get; private set; }

        public DateTime CaptureDate { get; private set; }

        public int X { get; private set; }

        public int Y { get; private set; }

        public int MissionID { get; private set; }

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
    }
}
