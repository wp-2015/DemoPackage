using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FSM
{
    public class StateBase
    {
        public Animator animator;
        public virtual void Execute()
        {

        }
    }
}
