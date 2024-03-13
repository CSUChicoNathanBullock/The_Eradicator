using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Door_Script : MonoBehaviour
{

    public Player_Inventory check_red;

    private void Start()
    {
        check_red.Red_key = false;
    }//Start

    private Vector3 currentPosition;
    public float timer = 3f;
    public float speed = 10f;





    private void OnTriggerStay(Collider other)
    {
        if (check_red.Red_key == true)
        {
            Move();
            //Debug.Log("Moving door");
            StartCoroutine(DestroyDoorAfterTime());
        }//if
    }//OnTriggerEnter

    IEnumerator DestroyDoorAfterTime()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
        //Debug.Log("Destroying");
    }//IEnumerator


    private void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        //Debug.Log("The vlaue of y is: " + tempPos.y);
        pos = tempPos;
    }//Move

    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }//get
        set
        {
            this.transform.position = value;
        }//set
    }//pos




}//Red_Door_Script

