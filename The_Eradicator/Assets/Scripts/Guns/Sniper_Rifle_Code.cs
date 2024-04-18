using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper_Rifle_Code : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            
        }//if
    }//OnTriggerEnter


}//Sniper_Rifle_Code