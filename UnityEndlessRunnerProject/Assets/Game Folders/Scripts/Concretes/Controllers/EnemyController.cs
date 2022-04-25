using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Managers;
using UnityEndlessRunnerProject.Movements;
using UnityEngine;

namespace UnityEndlessRunnerProject.Controllers
{
    public class EnemyController : MyCharacterController, IEntityController
    {
        
        [SerializeField] float _maxLifeTime = 10f;
        
        VerticalMover _mover;
        float _currentLifeTime = 0f;

        

        private void Awake()
        {
            _mover = new VerticalMover(this);
        }

        private void Update()
        {
            _currentLifeTime += Time.deltaTime;

            if (_currentLifeTime > _maxLifeTime)
            {
                _currentLifeTime = 0f;
                KillYourself();
            }
        }

       

        private void FixedUpdate()
        {
            _mover.FixedTick();
        }
        
        private void KillYourself()//önceden enemylerimiz yok olup tekrar oluşuyordu. artık enemy manager ile set pooldan çekip enemyleri dönüştürüyoruz.
        {
            EnemyManager.Instance.SetPool(this);
        }
    }
}


