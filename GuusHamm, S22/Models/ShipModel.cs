using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22.Models
{
    internal class ShipModel
    {
        public int ID { get; private set; }

        public string Name { get; private set; }

        public ShipTypeModel Type { get; private set; }

        public int X { get; private set; }

        public int Y { get; private set; }

        public List<CrewMemberModel> Crew { get; private set; }

        public ShipModel(int id,string name,ShipTypeModel type,int x,int y)
        {
            this.Y = y;
            this.X = x;
            this.Type = type;
            this.Name = name;
            this.ID = id;
        }

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
