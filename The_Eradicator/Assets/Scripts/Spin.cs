using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    //need something to control how fast object spins
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, (speed * Time.deltaTime) );
    }
}
