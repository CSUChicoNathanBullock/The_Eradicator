using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }//if

        
    }//OnTriggerEnter


    

    }//Enemy
