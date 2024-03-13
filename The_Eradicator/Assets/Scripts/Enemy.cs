using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    





    /*
    public Transform target;
    public float Speed = 3f;
    public float Rotate_Speed = .25f;
    private Rigidbody rb;

    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }//Start

    // Update is called once per frame
    void Update()
    {
        if (!target)
        {
            Get_Target();
        }//if
        else
        {
            RotateEnemy();
        }//else
    }//Update



    private void FixedUpdate()
    {
        rb.velocity = transform.up * Speed;
    }//Fixed Update

    private void RotateEnemy()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, Rotate_Speed);
    }//rotateEnemy

    private void Get_Target()
    {
            target = player.transform;
        
    }//Get_Target


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }//if

        else if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            target = null;
        }//else if
    }//OnTriggerEnter


    */

    }//Enemy
