using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Controllers;
using UnityEngine;

namespace UnityEndlessRunnerProject.Abstracts.Movements
{
    public interface IMover 
    {
        void FixedTick(float direction);
    }
}


