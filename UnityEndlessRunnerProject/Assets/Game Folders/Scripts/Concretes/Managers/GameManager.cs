using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEngine;

namespace  UnityEndlessRunnerProject.Managers
{
    
    public class GameManager : SingletonMonoBehaviourObject<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f; //timeScale slow motion time komutudur. 0 yaparsak tamamen duruyor.
        }
    }
}

