namespace GuusHamm__S22.Models
{
    #region

    using System.Collections.Generic;

    #endregion

    /// <summary></summary>
    public class ShipModel
    {
        /// <summary>Initializes a new instance of the <see cref="ShipModel"/> class.</summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public ShipModel(int id, string name, ShipTypeModel type, int x, int y)
        {
            this.Y = y;
            this.X = x;
            this.Type = type;
            this.Name = name;
            this.ID = id;
        }

        /// <summary>Gets the id.</summary>
        public int ID { get; private set; }

        /// <summary>Gets the name.</summary>
        public string Name { get; private set; }

        /// <summary>Gets the type.</summary>
        public ShipTypeModel Type { get; private set; }

        /// <summary>Gets the x.</summary>
        public int X { get; private set; }

        /// <summary>Gets the y.</summary>
        public int Y { get; private set; }

        /// <summary>Gets the crew.</summary>
        public List<CrewMemberModel> Crew { get; private set; }

        /// <summary></summary>
        /// <param name="crew">The crew.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool SetCrew(List<CrewMemberModel> crew)
        {
            if (crew != null)
            {
                this.Crew = crew;
                return true;
            }

            return false;
        }
    }
}
