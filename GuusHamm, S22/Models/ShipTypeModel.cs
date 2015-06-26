namespace GuusHamm__S22.Models
{
    /// <summary></summary>
    public class ShipTypeModel
    {
        /// <summary></summary>
        public enum ShipTypeEnum
        {
            /// <summary></summary>
            Klein, 

            /// <summary></summary>
            Middel, 

            /// <summary></summary>
            Groot
        }

        /// <summary>Initializes a new instance of the <see cref="ShipTypeModel"/> class.</summary>
        /// <param name="shipType">The ship type.</param>
        /// <param name="maxSpeed">The max speed.</param>
        /// <param name="maxCrew">The max crew.</param>
        public ShipTypeModel(ShipTypeEnum shipType, int maxSpeed, int maxCrew)
        {
            this.ShipType = shipType;
            this.MaxSpeed = maxSpeed;
            this.MaxCrew = maxCrew;
        }

        /// <summary>Gets the ship type.</summary>
        public ShipTypeEnum ShipType { get; private set; }

        /// <summary>Gets the max speed.</summary>
        public int MaxSpeed { get; private set; }

        /// <summary>Gets the max crew.</summary>
        public int MaxCrew { get; private set; }
    }
}
