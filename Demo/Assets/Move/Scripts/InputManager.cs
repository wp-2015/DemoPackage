using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Move
{
    public static class InputManager
    {
        public static float xAxis = 0;
        public static float yAxis = 0;
        public static void GetInput()
        {
            //Input.GetAxis
            if(Input.GetKey(KeyCode.W))
            {
                yAxis = 1;
            }
            else if(Input.GetKey(KeyCode.S))
            {
                yAxis = -1;
            }
            else
            {
                yAxis = 0;
            }

            if (Input.GetKey(KeyCode.A))
            {
                xAxis = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                xAxis = 1;
            }
            else
            {
                xAxis = 0;
            }
        }
    }
}