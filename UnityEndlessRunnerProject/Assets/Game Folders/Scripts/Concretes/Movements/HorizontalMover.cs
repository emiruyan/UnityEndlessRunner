using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;

namespace  UnityEndlessRunnerProject.Movements
{
    public class HorizontalMover
    { 
        PlayerController _playerController; 
        float _moveSpeed;
        float _moveBoundary;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = playerController.MoveSpeed;
            _moveBoundary = playerController.MoveBoundary;
        }
        public void TickFixed(float horizontal)
        {
            if (horizontal == 0f) return;
            
                
            _playerController.transform.Translate(Vector3.right*horizontal*Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundary, _moveBoundary);

            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0f);
        }
    }
}


