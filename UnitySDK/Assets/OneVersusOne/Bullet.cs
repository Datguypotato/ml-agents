using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine.AI;
using UnityEngine;

public class Bullet : MonoBehaviour 
{

    public float speed;

    private void Start()
    {
        Destroy(this.gameObject, 10);
    }

    void Update () 
	{
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}