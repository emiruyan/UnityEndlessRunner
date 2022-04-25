using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Abstracts.Movements;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;

namespace  UnityEndlessRunnerProject.Movements
{
    public class HorizontalMover : IMover
    { 
       IEntityController _playerController; 
        float _moveSpeed;
        float _moveBoundary;

        public HorizontalMover(IEntityController entityController)
        {
            _playerController = entityController;
            _moveSpeed = entityController.MoveSpeed;
            _moveBoundary = entityController.MoveBoundary;
        }
        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;
            
                
            _playerController.transform.Translate(Vector3.right*horizontal*Time.deltaTime * _moveSpeed);

            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundary, _moveBoundary);

            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, 0f);
        }
    }
}


