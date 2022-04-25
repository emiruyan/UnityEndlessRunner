using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Abstracts.Movements;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;

namespace  UnityEndlessRunnerProject.Movements
{
    public class VerticalMover : IMover
    {
        IEntityController _entityController;
        float _moveSpeed;

        public VerticalMover(IEntityController entityController)
        {
            _entityController  = entityController;
            //_moveSpeed = entityController.MoveSpeed;
        }

        public void FixedTick(float vertical = 1)// float vertical 1 diyerek default değer atamış olduk.
        {
            _entityController.transform.Translate(Vector3.forward * vertical * _moveSpeed * Time.deltaTime);
        }
    }
}


