namespace GuusHamm__S22.Models
{
    #region

    using System;

    #endregion

    /// <summary></summary>
    public class CrewMemberModel
    {
        /// <summary></summary>
        public enum JobEnum
        {
            /// <summary></summary>
            Ceo, 

            /// <summary></summary>
            Administrator, 

            /// <summary></summary>
            Bioloog, 

            /// <summary></summary>
            Politie, 

            /// <summary></summary>
            Kapitein, 

            /// <summary></summary>
            Technicus
        }

        /// <summary>Initializes a new instance of the <see cref="CrewMemberModel"/> class.</summary>
        /// <param name="id">The id.</param>
        /// <param name="name">The name.</param>
        /// <param name="job">The job.</param>
        /// <param name="birthDay">The birth day.</param>
        /// <param name="userName">The user name.</param>
        public CrewMemberModel(int id, string name, JobEnum job, DateTime birthDay, string userName)
        {
            this.Id = id;
            this.Name = name;
            this.Job = job;
            this.BirthDay = birthDay;
            this.UserName = userName;
        }

        /// <summary>Gets the id.</summary>
        public int Id { get; private set; }

        /// <summary>Gets the name.</summary>
        public string Name { get; private set; }

        /// <summary>Gets the birth day.</summary>
        public DateTime BirthDay { get; private set; }

        /// <summary>Gets the job.</summary>
        public JobEnum Job { get; private set; }

        /// <summary>Gets the user name.</summary>
        public string UserName { get; private set; }
    }
}
