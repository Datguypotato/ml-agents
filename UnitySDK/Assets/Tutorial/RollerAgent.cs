using System.Collections;
using System.Collections.Generic;
using MLAgents;
using UnityEngine;

public class RollerAgent : Agent {

    public Transform target;

    Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    public override void AgentReset()
    {
        if(this.transform.position.y < 0)
        {
            //resets posistion
            this.rb.angularVelocity = Vector3.zero;
            this.rb.velocity = Vector3.zero;
            this.transform.position = new Vector3(0, 0.5f, 0);
        }

        target.position = new Vector3(Random.value * 8 - 4, 0.5f, Random.value * 8 - 4);
    }

    public override void CollectObservations()
    {
        //remembers the target pos en it owns
        AddVectorObs(target.position);
        AddVectorObs(this.transform.position);

        //agent velocity
        AddVectorObs(rb.velocity.x);
        AddVectorObs(rb.velocity.z);
    }

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        //setup controls for agent
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];
        controlSignal.z = vectorAction[1];
        rb.AddForce(controlSignal * speed);
    }
}
