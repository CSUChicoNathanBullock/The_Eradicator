using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;


    public Transform target;

    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 targetposition = target.position + offset;
            //targetposition.z = transform.position.z;

            transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref velocity, damping);
            
            
        }//if
    }//FixedUpdate

    

}//CamFollow
