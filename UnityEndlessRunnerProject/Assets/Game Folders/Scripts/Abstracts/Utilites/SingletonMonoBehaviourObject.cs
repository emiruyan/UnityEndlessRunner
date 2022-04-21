using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEndlessRunnerProject.Abstracts.Utilites
{
    public abstract class SingletonMonoBehaviourObject<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get;private set; }

        protected void SingletonThisObject(T entity)
        {
            if (Instance==null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }   
}


