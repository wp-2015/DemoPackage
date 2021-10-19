using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Move
{
    public class AllManager : MonoBehaviour
    {
        InputManager inputManager;
        private void Awake()
        {
            inputManager = InputManager.Instance;
            inputManager.Init();
        }

        void Update()
        {
            inputManager.Update();
        }
    }
}