using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class UserStateRegistered : IUserState
    {
        public void ChangeState(User user)
        {
            user.UserState = StateChanger.GetState(user);
        }

        public bool IsValidStateForTheUser(User user)
        {
            bool isUserIdValid = !string.IsNullOrEmpty(user.UserId);
            bool isContactNumberValid = !string.IsNullOrEmpty(user.ContactNumber) && user.ContactNumber.Length == 5;
            bool isPasswordValid = !string.IsNullOrEmpty(user.Password) && user.Password.Length >= 5;
            if (isUserIdValid && isContactNumberValid && isPasswordValid)
                return true;

            return false;
        }

        public void PrintInstruction()
        {
            Console.WriteLine("\nYou are now registered. No more steps remaining.");
        }

        public void PrintStateDetails()
        {
            Console.WriteLine("User State<Registered>: User is registered. No more steps remaining");
        }
    }
}
