using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Utilites;
using UnityEngine;

namespace UnityEndlessRunnerProject.Managers
{
    public class SoundManager : SingletonMonoBehaviourObject<SoundManager>
    {
        AudioSource[] _audioSource;
        private void Awake()
        {
            SingletonThisObject(this);

            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
            
        }

        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            } 
        }
    }
}


