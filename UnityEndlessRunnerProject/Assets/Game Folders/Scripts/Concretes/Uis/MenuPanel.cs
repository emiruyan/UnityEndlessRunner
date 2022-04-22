using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Managers;
using UnityEngine;

namespace UnityEndlessRunnerProject.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartButton()
        {
            GameManager.Instance.LoadScene();
        }

        public void ExitButton()
        {
             GameManager.Instance.ExitGame();
        }
    }

}

