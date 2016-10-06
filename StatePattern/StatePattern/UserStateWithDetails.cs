using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class UserStateWithDetails : IUserState
    {
        public void ChangeState(User user)
        {
            user.UserState = StateChanger.GetState(user);
        }

        public void PrintInstruction()
        {
            Console.WriteLine("\nEnter password and confirm password. Password length cannot be less than 5.");
        }

        public bool IsValidStateForTheUser(User user)
        {
            bool isUserIdValid = !string.IsNullOrEmpty(user.UserId);
            bool isContactNumberValid = !string.IsNullOrEmpty(user.ContactNumber) && user.ContactNumber.Length == 5;
            bool isPasswordValid = !string.IsNullOrEmpty(user.Password) && user.Password.Length >= 5;
            if (isUserIdValid && isContactNumberValid && !isPasswordValid )
                return true;

            return false;
        }

        public void PrintStateDetails()
        {
            Console.WriteLine("User State<Detailed User>: User has entered UserId and Contact Number but still need to enter password.");
        }
    }
}
