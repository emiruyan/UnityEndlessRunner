using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace  UnityEndlessRunnerProject.Managers
{
    
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        public event System.Action OnGameStop;
        
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f; //timeScale slow motion time komutudur. 0 yaparsak tamamen duruyor.
            OnGameStop?.Invoke();
        }

        public void LoadScene(string sceneName)
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
            Debug.Log("Exit On Clikced");
            Application.Quit();
        }
    }
    
  
}

