using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Inputs;
using UnityEndlessRunnerProject.Inputs;
using UnityEndlessRunnerProject.Movements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityEndlessRunnerProject.Controllers

{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;    
        [SerializeField] float _jumpForce = 300f;
        

        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jump;
        IInputReader _input; 
        float _horizontal; 
        bool _isJump;
            
        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
           _horizontal= _input.Horizontal;
           if (_input.IsJump)
           {
               _isJump = true;
           }
           
        }

        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontal, _moveSpeed);
            
            if (_isJump)
            {
                _jump.TickFixed(_jumpForce);
                
            }
            
            _isJump = false;
        }
    }
}


