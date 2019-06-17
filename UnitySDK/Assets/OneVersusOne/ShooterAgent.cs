using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using MLAgents;
using UnityEngine;

public class ShooterAgent : Agent
{

    //public Transform floorOffset;
    public Transform bulletTransform;

    public override void AgentReset()
    {
        
    }

    private void Update()
    {
        if(bulletTransform == null)
        {
            
        }
    }
}