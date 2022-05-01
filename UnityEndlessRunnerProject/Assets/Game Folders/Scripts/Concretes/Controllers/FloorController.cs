using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEndlessRunnerProject.Controllers
{
    public class FloorController : MonoBehaviour
    {
        [Range(0.01f,2.5f)]
        [SerializeField] float _moveSpeed;
        Material _material;
 
         private void Awake()
         {
             _material = GetComponentInChildren<MeshRenderer>().material;
         }
 
         private void Update() //update her framede bir çalışır
         {
             _material.mainTextureOffset += Vector2.up * Time.deltaTime * _moveSpeed;   //vector2.down(benim projemde ters gittiği için up kullandım) bize y transformunda eksi bir döner
         }
    }
}


