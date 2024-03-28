using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_Follow : MonoBehaviour
{

    public NavMeshAgent enemy;
    
    public float Target_range;

    public Transform player;

    

    // Update is called once per frame
    void Update()
    {
        Chase();
        //enemy.SetDestination(player.position);
    }//Update


    private void Chase()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        //Debug.Log("Distance is: " + distance);

        if(Target_range > distance)
        {
            Debug.Log("Chasing player!");
            enemy.SetDestination(player.position);
        }//if
        
    }//Chase

}//Enemy_Follow
