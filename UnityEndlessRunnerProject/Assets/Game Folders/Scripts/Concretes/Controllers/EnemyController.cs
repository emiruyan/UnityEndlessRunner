using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Managers;
using UnityEndlessRunnerProject.Movements;
using UnityEngine;

namespace UnityEndlessRunnerProject.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float _moveSpeed = 10f;
        [SerializeField] float _maxLifeTime = 10f;
        
        VerticalMover _mover;
        float _currentLifeTime = 0f;

        public float MoveSpeed => _moveSpeed;
        
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


