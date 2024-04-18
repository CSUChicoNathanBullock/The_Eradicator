using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper_Bullet_Code : MonoBehaviour
{
    private int count = 0;
    private int limit = 3;
    public int Sniper_Damage;

    private float Sniper_Bullet_speed = 10f;

    private void OnEnable()
    {
        StartCoroutine(DestroyBulletAfterTime());
    }//OnEnable


    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }//IEnumerator

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Sniper_Bullet_speed * Time.deltaTime);
    }//Update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Debug.Log("hit Enemy");
            count++;
            //Debug.Log("Count is: " + count);
        }//if

        //Debug.Log("count is: " + count);
        if (count >= limit)
        {
            Destroy(gameObject);
            //Debug.Log("Penetration has reached limit");
        }//if
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }//OnTriggerEnter

}//Sniper_Bullet_Code
