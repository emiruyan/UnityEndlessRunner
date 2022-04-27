
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEndlessRunnerProject.Controllers;
using UnityEndlessRunnerProject.Enums;
using UnityEngine;



namespace  UnityEndlessRunnerProject.Managers
{
    
    //object pool pattern. enemylerimiz spawn olup Instantiate(klonlanıp) edilip tekrardan kullanılıyordu. object pool pattern ile bunun önüne geçeceğiz ve bize performans olarak artısı olacak.
    
    public class EnemyManager : SingletonMonoBehaviourObject<EnemyManager> //singleton yaptık
    {
        [SerializeField] EnemyController[] _enemyPrefabs; 
        Dictionary<EnemyEnum,Queue<EnemyController>> _enemies = new Dictionary<EnemyEnum, Queue<EnemyController>>();

        private void Awake()
        {
            SingletonThisObject(this); //snigleton yaptık
        }

        private void Start()
        {
            InitilaizePool();
        }

        private void InitilaizePool()
        {
            for (int i = 0; i < _enemyPrefabs.Length; i++)
            {
                Queue<EnemyController> enemyControllers = new Queue<EnemyController>();
                for (int j = 0; j < 10; j++)
                {
                    EnemyController newEnemy = Instantiate(_enemyPrefabs[i]); //döngü her çalıştığında 0. çalışacak.Daha sonra for i++ sayesinde bir artacak
                    newEnemy.gameObject.SetActive(false);
                    newEnemy.transform.parent = this.transform;
                    enemyControllers.Enqueue(newEnemy);
                
                }
                
                _enemies.Add((EnemyEnum)i,enemyControllers);
            }
        }

        public void SetPool(EnemyController enemyController) //havuza ekliyoruz
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = this.transform;//bunu tekrar bünyemize alıyoruz
            
            Queue<EnemyController> enemyControllers = _enemies[enemyController.EnemyType];
            enemyControllers.Enqueue(enemyController);
        }

        public EnemyController GetPool(EnemyEnum enemyType) //havuzdan çıkarıyoruz
        {
            Queue<EnemyController> enemyControllers = _enemies[enemyType];

            if (enemyControllers.Count==0)
            {
                for (int i = 0; i < 2; i++)
                {
                    EnemyController newEnemy = Instantiate(_enemyPrefabs[(int) enemyType]);
                    enemyControllers.Enqueue(newEnemy);
                }
                
            }

            return enemyControllers.Dequeue();
        }
        
    }
}


