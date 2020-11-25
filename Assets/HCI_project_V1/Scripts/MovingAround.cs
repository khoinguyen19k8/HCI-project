using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Testing_V2
{
    public class MovingAround : MonoBehaviour
    {
        // Start is called before the first frame update
        public float speed;
        public Transform vrCamera;
        private CharacterController myCharacterController;
        Vector3 move = Vector3.zero;

        float m_VerticalAngle, m_HorizontalAngle;
        void Start()
        {
            myCharacterController = GetComponent<CharacterController>(); // gets character controller from the mover
            vrCamera = Camera.main.transform; // gets the transform from the main camera;
        }

        // Update is called once per frame
        void Update()
        {

            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            if (move.sqrMagnitude > 1.0f)
                move.Normalize();
            move = move * speed * Time.deltaTime;
            move = vrCamera.TransformDirection(move);
            myCharacterController.Move(move);
        }
    }
}

