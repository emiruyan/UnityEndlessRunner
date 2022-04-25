using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEndlessRunnerProject.Abstracts.Movements
{
    public interface IJump 
    {
        void FixedTick(float jumpForce);
    }
}



