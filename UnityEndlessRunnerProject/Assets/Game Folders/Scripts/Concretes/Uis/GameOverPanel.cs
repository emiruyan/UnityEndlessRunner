using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Managers;
using UnityEngine;

namespace UnityEndlessRunnerProject.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
          GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        { 
            GameManager.Instance.LoadScene("Menu");
        }
    }
    
}


