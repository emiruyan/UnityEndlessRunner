using System;
using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Managers;
using UnityEndlessRunnerProject.ScriptableObjects;
using UnityEngine;
    
namespace UnityEndlessRunnerProject.Controllers
{
    public class LevelInitiliaizerController : MonoBehaviour
    {
        LevelDifficultyData _levelDifficultyData;

        private void Awake()
        {
            _levelDifficultyData = GameManager.Instance.LevelDifficultyData;//cashladik
        }

        private void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.SkyboxMaterial;
            Instantiate(_levelDifficultyData.FloorPrefab);
            Instantiate(_levelDifficultyData.SpawnerPrefab);
            EnemyManager.Instance.SetMoveSpeed(_levelDifficultyData.MoveSpeed);
            EnemyManager.Instance.SetAddDelayTime(_levelDifficultyData.AddDelayTime);
        }
    }
}

