using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun_Script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);

        }//if
    }//OnTriggerEnter

}//Shotgun_Script
