using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot_Script : MonoBehaviour
{


    [SerializeField]
    private GameObject Bullet;
    public GameObject Sniper_Bullet;
    

    [SerializeField]
    private Transform Bullet_Direction;
    private bool canShoot = true;

    public bool Has_Shotgun = false;
    public bool Has_Sniper = false;
    //public Camera Cam;




    //shotgun spawns
    //bullet spawn 1
    public Transform Barrel_Exit_1;
    //bullet spawn 2
    public Transform Barrel_Exit_2;
    //bullet spawn 3
    public Transform Barrel_Exit_3;
    //bullet spawn 4
    public Transform Barrel_Exit_4;
    //bullet spawn 5
    public Transform Barrel_Exit_5;



    public Player_Inventory check_shotgun;
    public Player_Inventory check_sniper;
    // Start is called before the first frame update
    void Start()
    {
        check_shotgun.Has_Shotgun = false;
        check_sniper.Has_Sniper = false;
    }//Start

    // Update is called once per frame
    void Update()
    {
        if(Pause_Script.Is_Paused == false)
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                Fire_Gun();
            }//if
        }//if
        
    }//Update

    private void Fire_Gun()
    {
        if (!canShoot)
        {
            return;
        }//if

        //pistol
        if(check_sniper.Has_Sniper == false && check_shotgun.Has_Shotgun == false)
        {
            GameObject g = Instantiate(Bullet, Bullet_Direction.position, Bullet_Direction.rotation);
            g.SetActive(true);
            StartCoroutine(CanShoot());
        }
   
        //shotgun
        else if (check_shotgun.Has_Shotgun == true && check_sniper.Has_Sniper == false)
        {
            //Debug.Log("Made it into Shotgun");
            //bullet 1
            GameObject g1 = Instantiate(Bullet, Barrel_Exit_1.position, Barrel_Exit_1.rotation);
            g1.SetActive(true);
            //bullet 2
            GameObject g2 = Instantiate(Bullet, Barrel_Exit_2.position, Barrel_Exit_2.rotation);
            g2.SetActive(true);
            //bullet 3
            GameObject g3 = Instantiate(Bullet, Barrel_Exit_3.position, Barrel_Exit_3.rotation);
            g3.SetActive(true);
            //bullet 4
            GameObject g4 = Instantiate(Bullet, Barrel_Exit_4.position, Barrel_Exit_4.rotation);
            g4.SetActive(true);
            //bullet 5
            GameObject g5 = Instantiate(Bullet, Barrel_Exit_5.position, Barrel_Exit_5.rotation);
            g5.SetActive(true);
            StartCoroutine(CanShoot());

        }//if

        //sniper
        else if (check_shotgun.Has_Shotgun == false && check_sniper.Has_Sniper == true)
        {
            //Debug.Log("Made it into sniper");
            GameObject g_sniper = Instantiate(Sniper_Bullet, Bullet_Direction.position, Bullet_Direction.rotation);
            g_sniper.SetActive(true);
            StartCoroutine(CanShoot());
        }//if


    }//Fire_Gun

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(.5f);
        canShoot = true;

    }//CanShoot

    

}//Shoot_Script
