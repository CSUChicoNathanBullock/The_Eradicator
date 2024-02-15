using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float Bullet_speed = 4f;

    IEnumerator DestroyBulletAfterTime()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }//IEnumerator

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Bullet_speed * Time.deltaTime);
    }//Update

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }//OnTriggerEnter
}//Bullet