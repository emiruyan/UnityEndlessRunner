using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;

namespace  UnityEndlessRunnerProject.Movements
{
    public class VerticalMover
    {
        EnemyController _enemyController;
        float _moveSpeed;

        public VerticalMover(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = enemyController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)// float vertical 1 diyerek default değer atamış olduk.
        {
            _enemyController.transform.Translate(Vector3.forward * vertical * _moveSpeed * Time.deltaTime);
        }
    }
}


