using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class UserStateNew : IUserState
    {
        public void ChangeState(User user)
        {
            user.UserState = StateChanger.GetState(user);
        }

        public bool IsValidStateForTheUser(User user)
        {
            bool isUserIdValid = !string.IsNullOrEmpty(user.UserId);
            bool isContactNumberValid = !string.IsNullOrEmpty(user.ContactNumber) && user.ContactNumber.Length == 5;

            if (!isUserIdValid || !isContactNumberValid)
                return true;

            return false;
        }

        public void PrintInstruction()
        {
            Console.WriteLine("\nEnter user id and contact number. contact number should have exactly 5 digits.");
        }

        public void PrintStateDetails()
        {
            Console.WriteLine("User State<New>: User has not valid userid and contact number yet.");
        }
    }
}
