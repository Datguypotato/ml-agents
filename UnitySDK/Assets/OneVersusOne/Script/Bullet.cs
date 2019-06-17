using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using MLAgents;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Shooter shooter;
    public float speed;


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("agent"))
        {
            shooter.agent.SetReward(-1);
            shooter.hit = true;
            shooter.agent.Done();
        }
    }
}