using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StateChanger
    {
        private static IUserState userStateNew = new UserStateNew();
        private static IUserState userStateDetailed = new UserStateWithDetails();
        private static IUserState userStateRegistered = new UserStateRegistered();

        public static IUserState UserStateNew { get { return userStateNew; } }
        public static IUserState UserStateDetailed { get { return userStateDetailed; } }
        public static IUserState UserStateRegistered { get { return UserStateRegistered; } }

        public static IUserState GetState(User user)
        {
            if (userStateNew.IsValidStateForTheUser(user))
                return userStateNew;
            else if (userStateDetailed.IsValidStateForTheUser(user))
                return userStateDetailed;
            else if (userStateRegistered.IsValidStateForTheUser(user))
                return userStateRegistered;

            return null;
        }
    }
}
