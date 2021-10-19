using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Move
{
    public class TestMove : MonoBehaviour
    {
        public Animator animator;
        public Transform tfHero;

        private InputManager inputManager;
        private void Start()
        {
            inputManager = InputManager.Instance;
        }

        private float angleOld;

        void Update()
        {
            var angle = inputManager.GetAngle();
            var length = inputManager.GetLength();
            if(angleOld != angle)
            {
                Debug.LogError("+angle++++" + angle);
                tfHero.eulerAngles = new Vector3(0, angle, 0);
                angleOld = angle;
            }
            animator.SetInteger(AniConst.AniKey, (int)length);
        }

        public void SetAniDirection()
        {

        }
    }
}
