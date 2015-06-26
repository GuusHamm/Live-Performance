using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22.Models
{
    public class CrewMemberModel
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public DateTime BirthDay { get; private set; }

        public JobEnum Job { get; private set; }

        public string UserName { get; private set; }

        public CrewMemberModel(int id, string name, JobEnum job, DateTime birthDay, string userName)
        {
            this.Id = id;
            this.Name = name;
            this.Job = job;
            this.BirthDay = birthDay;
            this.UserName = userName;
        }
        public enum JobEnum
        {
            Ceo,
            Administrator,
            Bioloog,
            Politie,
            Kapitein,
            Technicus
        }
    }
}
