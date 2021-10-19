using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

namespace Demo.Move
{
    public class InputManager : Singleton_CSharp<InputManager>
    {
        private InputBase input;
        public void Init()
        {
            input = new InputPC();
        }

        public void Update()
        {
            input?.Update();
        }

        public float GetAngle()
        {
            return input.Angle;
        }

        public float GetLength()
        {
            return input.Length;
        }
    }
}