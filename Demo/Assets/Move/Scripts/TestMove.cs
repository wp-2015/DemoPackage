using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Move
{
    public class TestMove : MonoBehaviour
    {
        public Animator animator;

        void Update()
        {
            float move = Input.GetAxis("");
        }

        public void SetAniDirection()
        {

        }
    }
}
