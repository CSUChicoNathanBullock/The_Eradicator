using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float Health, Max_Health = 30f;

    [SerializeField] Enemy_Health_Bar healthbar;

    //[SerializeField] private Camera camera;
    //[SerializeField] private Transform target;
    private Bullet bulletDmg;
    private Sniper_Bullet_Code SniperbulletDmg;

    public float Player_Damage;

    private void Awake()
    {
        healthbar = GetComponentInChildren<Enemy_Health_Bar>();
    }//Awake

    private void Start()
    {
        Health = Max_Health;
        healthbar.Health_Update(Health, Max_Health);
        
    }//Start

    public void Take_Damage(float Damage_Amount)
    {
        Health -= Damage_Amount;
        healthbar.Health_Update(Health, Max_Health);
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }//if
    }//Take_Damage


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            
            bulletDmg = other.GetComponent<Bullet>();
            Take_Damage(bulletDmg.Bullet_Damage);
            //currentHealth -= bulletDmg.bulletDamage;

            //GameManager.instance.UpdateScore(points);
            Destroy(other.gameObject);
        }//if

        if (other.tag == "Sniper_Bullet")
        {
            SniperbulletDmg = other.GetComponent<Sniper_Bullet_Code>();
            Take_Damage(SniperbulletDmg.Sniper_Damage);
            //currentHealth -= bulletDmg.bulletDamage;

            //GameManager.instance.UpdateScore(points);
           
        }//if



    }//OnTriggerEnter
    /*
    private void Update()
    {
        transform.rotation = camera.transform.rotation;
        transform.position = target.position;
    }//Update
    */

}//Enemy
