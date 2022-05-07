using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEndlessRunnerProject.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace  UnityEndlessRunnerProject.Managers
{
     
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        [SerializeField] LevelDifficultyData[] _levelDifficultyDatas;
        
        public event System.Action OnGameStop;
        public LevelDifficultyData LevelDifficultyData => _levelDifficultyDatas[DifficultyIndex]; 
        int _difficultyIndex;

        public int DifficultyIndex
        {
            get => _difficultyIndex;
            set
            {
                if (_difficultyIndex< 0 || _difficultyIndex > _levelDifficultyDatas.Length)
                {
                    LoadSceneAsync("Menu");
                }
                else
                {
                    _difficultyIndex = value;
                }
            }
            
        }
        

        private void Awake()//oyunumuz ilk başladığında
        {
            SingletonThisObject(this);
            SoundManager.Instance.PlaySound(0); 
        }

        public void StopGame() //bir nesne ile çarpıştığımızda 
        {
            Time.timeScale = 0f; //timeScale slow motion time komutudur. 0 yaparsak tamamen duruyor.
            OnGameStop?.Invoke();
        }

        public void LoadScene(string sceneName)// oynanış başladığında
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()  
        {
            Application.Quit();
        }
    }
    
  
}

