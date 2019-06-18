using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using UnityEngine;

public class Shooter : MonoBehaviour 
{

    //public GameObject bulletPrefab;
    public GameObject bulletShot;
    public GameObject agentObject;
    Vector3 bulletpos;

    [Space(5)]
    public ShooterAgent agent;
    public bool hit;

    float size = 10;

	// Use this for initialization
	void Start () 
	{
        //StartCoroutine(Shooting());
    }
	
	// Update is called once per frame
	void Update () 
	{
        bulletpos = bulletShot.transform.position;
        if (bulletpos.x < -size || bulletpos.x > size || bulletpos.z < -size || bulletpos.z > size)
        {
            ResetBullet();
        }


        if (agent.IsDone() == true)
        {
            //bulletShot.SetActive(true);
            //ShootBullet();
        }

    }

    public void ResetBullet()
    {
        ShootBullet();

        if (hit)
        {
            hit = false;
        }
        else
        {
            agent.SetReward(5);
            agent.Done();
        }
    }

    public void ShootBullet()
    {
        transform.LookAt(agentObject.transform);
        bulletShot.transform.position = transform.position;
        bulletShot.transform.rotation = transform.rotation;
    }

    //public IEnumerator Shooting()
    //{
    //    yield return new WaitForSeconds(1);
    //    ShootBullet();
    //    yield return new WaitForSeconds(3);
    //    ResetBullet();

    //    yield return new WaitForSeconds(1);
        
    //}


}