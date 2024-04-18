using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);

        }//if
    }//OnTriggerEnter
}//Collectibles_Script

