using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    public enum AllState
    {
        Idle,
        Walk,
    }

    public class Utils
    {
        public static StateBase GetState(AllState state)
        {
            switch(state)
            {
                case AllState.Idle:
                    return IdleState;

            }
        }
        
    }
}
