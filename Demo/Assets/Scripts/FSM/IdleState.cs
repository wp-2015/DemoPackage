using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    public class IdleState : StateBase
    {
        public override void Execute()
        {
            animator?.SetInteger()

        }
    }
}
