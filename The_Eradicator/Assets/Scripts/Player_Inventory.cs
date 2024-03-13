using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Inventory : MonoBehaviour
{

    public bool Red_key = false;
    public bool Blue_Key = false;
    public bool Yellow_Key = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Red_Key")
        {
            Red_key = true;
            Destroy(other.gameObject);
        }//if

        if (other.tag == "Blue_Key")
        {
            Blue_Key = true;
            Destroy(other.gameObject);
        }//if

        if (other.tag == "Yellow_Key")
        {
            Yellow_Key = true;
            Destroy(other.gameObject);
        }//if

        
    }//OnTriggerEnter

}//Player_Inventory
