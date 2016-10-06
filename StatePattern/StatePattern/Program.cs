using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------User Registration Wizard -------------------\n");
            User user = new User();
            user.UserState = StateChanger.GetState(user);
            user.PrintCurrentState();

            while(user.UserState.Equals(StateChanger.UserStateNew))
            {
                user.PrintInstructionsToProceed();

                string userId = Console.ReadLine();
                string contactNumber = Console.ReadLine();

                user.UserId = userId;
                user.ContactNumber = contactNumber;

                user.ChangeState();
                user.PrintCurrentState();
            }

            
        
            while(user.UserState.Equals(StateChanger.UserStateDetailed))
            {
                user.PrintInstructionsToProceed();

                string password = Console.ReadLine();
                string confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    user.Password = password;
                    user.ChangeState();
                    user.PrintCurrentState();
                }
                else
                {
                    Console.WriteLine("Passowrd and Confirm passowrd do not match");
                }
            }
            
            user.ChangeState();
            Console.Read();

        }
    }
}
