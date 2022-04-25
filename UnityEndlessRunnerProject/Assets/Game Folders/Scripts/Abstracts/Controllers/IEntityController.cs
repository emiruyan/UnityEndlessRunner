using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEndlessRunnerProject.Abstracts.Controllers
{
    public interface  IEntityController 
    {
        Transform transform { get; }

         float MoveSpeed { get; }

         public float MoveBoundary { get; }
    } 
}


