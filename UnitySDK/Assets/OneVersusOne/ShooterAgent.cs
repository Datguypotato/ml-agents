using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using MLAgents;
using UnityEngine;

public class ShooterAgent : Agent
{

    public float speed = 4;

    public Transform floorOffset;
    public Shooter shooter;

    //Transform bulletTransform;

    private void Start()
    {
        
    }

    public override void AgentReset()
    {
        //reset posistion

        transform.position = new Vector3(Random.Range(-23, 23), 0.5f, Random.Range(-23, 23));
        shooter.transform.position = new Vector3(Random.Range(-23, 23), 0.5f, Random.Range(-23, 23));
    }

    public override void CollectObservations()
    {
        AddVectorObs(this.transform.position);

        //AddVectorObs(bulletTransform.position);
        AddVectorObs(shooter.transform.position);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];
        controlSignal.z = vectorAction[1];

        transform.Translate(controlSignal * Time.deltaTime * speed);

        //float distance = Vector3.Distance(transform.position, shooter.bulletShot.transform.position);

        //if(distance < .8f)
        //{
        //    SetReward(-1);
        //    Done();
        //}

    }

    private void Update()
    {
        //Debug.Log(Vector3.Distance(transform.position, shooter.bulletShot.transform.position));
    }
}