using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Movements;
using UnityEngine;

namespace UnityEndlessRunnerProject.Controllers

{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _horizontalDirection = 0f;

        HorizontalMover _horizontalMover;
            
        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
        }

        private void FixedUpdate()
        {
            _horizontalMover.TickFixed(_horizontalDirection, _moveSpeed);
        }
    }
}


