using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Abstracts.Inputs;
using UnityEndlessRunnerProject.Abstracts.Movements;
using UnityEndlessRunnerProject.Inputs;
using UnityEndlessRunnerProject.Managers;
using UnityEndlessRunnerProject.Movements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityEndlessRunnerProject.Controllers

{
    public class PlayerController : MyCharacterController, IEntityController
    {

        [SerializeField] float _jumpForce;
        
     
        IMover _mover;
        IJump _jump;
        IInputReader _input; 
        float _horizontal; 
        bool _isJump;
        bool _isDead; //playerımız çarpıştığında komut almasının önüne geçtik
        public Joystick _joystick;
        

        private void Awake()
        {
            _mover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }

        private void Update()
        {
            if (_isDead )  return; //playerımız çarpıştığında komut almasının önüne geçtik
            
           _horizontal= -_joystick.Horizontal;
           
           if (_input.IsJump)
           {
               _isJump = true;
           }

           
           
           
        }

        private void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);
            
        }

        private void OnTriggerEnter(Collider other)
        {
            {
                IEntityController entityController = other.GetComponent<IEntityController>();

                if (entityController != null)
                {
                    _isDead = true; //playerımız çarpıştığında komut almasının önüne geçtik
                    GameManager.Instance.StopGame();
                }
            }
        }

        public void JumpTrigger()
        {
            _jump.FixedTick(_jumpForce);
        }
    }
}


