using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Demo.Move
{
    public class InputPC : InputBase
    {
        const int RunLength = 2;
        public override void Update()
        {
            var iA = Input.GetKey(KeyCode.A);
            var iD = Input.GetKey(KeyCode.D);

            if (Input.GetKey(KeyCode.W))
            {
                if (iA)
                {
                    Angle = -45;
                }
                else if (iD)
                {
                    Angle = 45;
                }
                else
                {
                    Angle = 0;
                }
                Length = RunLength;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                if (iA)
                    Angle = -135;
                else if (iD)
                    Angle = 135;
                else
                    Angle = -180;
                Length = RunLength;
            }
            else if(iA)
            {
                Angle = -90;
                Length = RunLength;
            }
            else if(iD)
            {
                Angle = 90;
                Length = RunLength;
            }
            else
            {
                Length = 0;
            }
        }
    }
}
