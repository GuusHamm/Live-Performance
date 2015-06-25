using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuusHamm__S22
{
    using GuusHamm__S22.Models;

    static class Settings
    {
        public static CrewMemberModel LogedInUser { get; private set; }

        public static void Initialize()
        {
            LogedInUser = null;
        }

        public static bool LoginUser(CrewMemberModel user)
        {
            if (user != null)
            {
                LogedInUser = user;
                return true;
            }
            return false;
        }

        public static bool LogOut()
        {
            LogedInUser = null;
            return true;
        }

    }
}
