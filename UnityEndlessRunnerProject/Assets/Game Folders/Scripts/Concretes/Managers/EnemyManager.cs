
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEndlessRunnerProject.Controllers;
using UnityEngine;



namespace  UnityEndlessRunnerProject.Managers
{
    
    //object pool pattern. enemylerimiz spawn olup Instantiate(klonlanıp) edilip tekrardan kullanılıyordu. object pool pattern ile bunun önüne geçeceğiz ve bize performans olarak artısı olacak.
    
    public class EnemyManager : SingletonMonoBehaviourObject<EnemyManager> //singleton yaptık
    {
        [SerializeField] EnemyController[] _enemyPrefabs; 
        Queue<EnemyController> _enemies = new Queue<EnemyController>();

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
            for (int i = 0; i < 10; i++)
            {
                 EnemyController newEnemy = Instantiate(_enemyPrefabs[Random.Range(0, _enemyPrefabs.Length)]);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = this.transform; 
                _enemies.Enqueue(newEnemy);
            }
        }

        public void SetPool(EnemyController enemyController) //havuza ekliyoruz
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = this.transform;//bunu tekrar bünyemize alıyoruz
            _enemies.Enqueue(enemyController);//bunu tekrar poola alıyoruz
        }

        public EnemyController GetPool() //havuzdan çıkarıyoruz
        {
            if (_enemies.Count == 0)
            {
                InitilaizePool();
            }
            return _enemies.Dequeue();
        }
    }
}


