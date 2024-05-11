using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float Bullet_speed = 10f;
    public float Bullet_Damage;

    private void OnEnable()
    {
        StartCoroutine(DestroyBulletAfterTime());
    }//OnEnable
    

    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }//IEnumerator

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Bullet_speed * Time.deltaTime);
    }//Update

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }//OnTriggerEnter
}//Bullet
