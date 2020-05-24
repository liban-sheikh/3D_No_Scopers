using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Simulator : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float force = 5;
    Rigidbody Car;
    // Use this for initialization
    void Start()
    {

    }

    private void OnCollisionEnter()
    {
        if (Car.gameObject.tag == "Rail")
        {
            Debug.Log("Object has been hit");
            Car.AddForce(Vector3.back * force);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
