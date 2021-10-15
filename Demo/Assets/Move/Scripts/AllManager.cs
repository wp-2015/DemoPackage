using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Move
{
    public class AllManager : MonoBehaviour
    {
        private void Start()
        {
            
        }

        void Update()
        {
            InputManager.GetInput();
        }
    }
}