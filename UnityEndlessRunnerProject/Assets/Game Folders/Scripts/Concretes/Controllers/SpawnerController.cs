
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Enums;
using UnityEndlessRunnerProject.Managers;
using UnityEngine;
using UnityEngine.SocialPlatforms;


namespace  UnityEndlessRunnerProject.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] EnemyController _enemyPrefab;
        [Range(0.1f, 5f)][SerializeField] float _min = 0.1f;
        [Range(6f, 15f)][SerializeField] float _max = 15f;
        
        float _maxSpawnTime;
        float _currentSpawnTime = 0f;


        private void OnEnable()
        {
            
            GetRandomMaxTime();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            
            if (_currentSpawnTime > _maxSpawnTime)
            {
                 Spawn(); 
            }
            
            
        }

        private void Spawn()
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool((EnemyEnum)Random.Range(0,4));
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;
            newEnemy.gameObject.SetActive(true); 
            
            _currentSpawnTime = 0f;
            GetRandomMaxTime();
            
        }

        private void GetRandomMaxTime()
        {
            _maxSpawnTime = Random.Range(_min, _max);
        }
    }
    
    
    
    
}


