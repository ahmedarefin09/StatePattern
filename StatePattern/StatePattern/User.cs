using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class User
    {
        public string UserId { get; set; }
        public string ContactNumber { get; set; }
        public string Password { get; set; }

        public IUserState UserState { get; set; }

        public void ChangeState()
        {
            UserState.ChangeState(this);
        }

        public void PrintCurrentState()
        {
            UserState.PrintStateDetails();
        }

        public void PrintInstructionsToProceed()
        {
            UserState.PrintInstruction();
        }
    }
}
