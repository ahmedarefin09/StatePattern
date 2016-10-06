using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IUserState
    {
        bool IsValidStateForTheUser(User user);
        void PrintInstruction();
        void PrintStateDetails();
        void ChangeState(User user);
    }
}
