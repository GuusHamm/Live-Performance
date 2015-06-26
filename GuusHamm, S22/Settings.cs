namespace GuusHamm__S22
{
    #region

    using GuusHamm__S22.Models;

    #endregion

    /// <summary></summary>
    static class Settings
    {
        /// <summary>Gets the loged in user.</summary>
        public static CrewMemberModel LogedInUser { get; private set; }

        /// <summary></summary>
        public static void Initialize()
        {
            LogedInUser = null;
        }

        /// <summary></summary>
        /// <param name="user">The user.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool LoginUser(CrewMemberModel user)
        {
            if (user != null)
            {
                LogedInUser = user;
                return true;
            }

            return false;
        }

        /// <summary></summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool LogOut()
        {
            LogedInUser = null;
            return true;
        }
    }
}
