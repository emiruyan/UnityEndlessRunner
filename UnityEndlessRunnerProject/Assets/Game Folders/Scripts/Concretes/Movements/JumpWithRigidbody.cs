using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;

namespace UnityEndlessRunnerProject.Movements
{
    public class JumpWithRigidbody 
    { 
        Rigidbody _rigidbody;

        public bool CanJump => _rigidbody.velocity.y != 0f;

        public JumpWithRigidbody(PlayerController playerController)
        {
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void TickFixed(float jumpForce)
        {
           if (CanJump) return;
            
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
            
        }
    }

}
