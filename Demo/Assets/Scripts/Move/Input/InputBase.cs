using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Move
{
    public abstract class InputBase
    {
        public float Angle { get; set; }
        public float Length { get; set; }

        public abstract void Update();
    }
}
