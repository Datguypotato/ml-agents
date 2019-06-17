using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using MLAgents;
using UnityEngine;

public class ShooterAgent : Agent
{
    public float size = 8;
    public float speed = 4;

    public Transform floorOffset;
    public Shooter shooter;

    public Transform bulletTransform;

    bool reset;

    private void Start()
    {
        
    }

    public override void AgentReset()
    {
        //reset posistion

        transform.position = new Vector3(Random.Range(-size, size), 0.5f, Random.Range(-size, size));
        shooter.transform.position = new Vector3(Random.Range(-size, size), 0.5f, Random.Range(-size, size));

        shooter.ResetBullet();
        //shooter.ShootBullet();
    }

    public override void CollectObservations()
    {
        AddVectorObs(this.transform.position);
        AddVectorObs(bulletTransform.position);

        AddVectorObs(shooter.transform.position);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];
        controlSignal.z = vectorAction[1];

        transform.Translate(controlSignal * Time.deltaTime * speed);

        float distance = Vector3.Distance(transform.position, shooter.bulletShot.transform.position);

    }

    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -size, size), 0.5f, Mathf.Clamp(transform.position.z, -size, size));
    }
}