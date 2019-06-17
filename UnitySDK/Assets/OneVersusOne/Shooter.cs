using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using UnityEngine;

public class Shooter : MonoBehaviour 
{

    public GameObject bulletPrefab;
    public GameObject bulletShot;
    public GameObject agentObject;

    [Space(5)]
    public ShooterAgent agent;

	// Use this for initialization
	void Start () 
	{
        Invoke("Shoot", 1);
	}
	
	// Update is called once per frame
	void Update () 
	{
        transform.LookAt(agentObject.transform);


		//if(agent.IsDone() == true)
  //      {
  //          bulletShot = Instantiate(bulletPrefab, transform.position, transform.rotation);
  //      }
	}

    void Shoot()
    {
        bulletShot = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}