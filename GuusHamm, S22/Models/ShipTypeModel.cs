using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22.Models
{
    class ShipTypeModel
    {
        public enum ShipTypeEnum
        {
            Klein,
            Middel,
            Groot
        }

        public ShipTypeEnum ShipType { get; private set; }

        public int MaxSpeed { get; private set; }

        public int MaxCrew { get; private set; }

        public ShipTypeModel(ShipTypeEnum shipType, int maxSpeed, int maxCrew)
        {
            this.ShipType = shipType;
            this.MaxSpeed = maxSpeed;
            this.MaxCrew = maxCrew;
        }
    }
}
