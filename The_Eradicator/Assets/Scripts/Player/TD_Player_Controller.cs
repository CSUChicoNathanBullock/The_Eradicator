using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TD_Player_Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;
    public GameObject Sniper_Bullet;

    [SerializeField]
    private float Movement_Velocity = 3f;

    [SerializeField]
    private Transform Bullet_Direction;
    private bool canShoot = true;
    public Camera Cam;

    public bool Has_Shotgun = false;
    public bool Has_Sniper = false;

    private float Shoot_Delay_Timer;

    
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
    

    private PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();
    }//Awake

    private void OnEnable()
    {
        controls.Enable();
    }//OnEnable

    private void OnDisable()
    {
        controls.Disable();
    }//OnDisable

    

    void Start()
    {
        Cam = Camera.main;
        //controls.Player.Shoot.performed += _ => PlayerShoot();
    }//Start
    
    private void PlayerShoot()
    {
        if (!canShoot)
        {
            return;
        }//if


        
        Vector2 mousePosition = controls.Player.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //pistol
        if (Has_Sniper == false && Has_Shotgun == false) {
            GameObject g = Instantiate(Bullet, Bullet_Direction.position, Bullet_Direction.rotation);
            g.SetActive(true);
            Shoot_Delay_Timer = .5f;
            StartCoroutine(CanShoot());
        }
        
        

        //shotgun
        else if (Has_Shotgun == true && Has_Sniper == false)
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
            Shoot_Delay_Timer = 1f;
            StartCoroutine(CanShoot());

        }//else if

        //sniper
        else if (Has_Shotgun == false && Has_Sniper == true)
        {
            //Debug.Log("Made it into sniper");
            GameObject g_sniper = Instantiate(Sniper_Bullet, Bullet_Direction.position, Bullet_Direction.rotation);
            g_sniper.SetActive(true);
            Shoot_Delay_Timer = 2f;
            StartCoroutine(CanShoot());
        }//else if
        



    }//PlayerShooot

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(Shoot_Delay_Timer);
        canShoot = true;

    }//CanShoot

    
    void Update()
    {



        //Rotation
        //RotateGun();

        //Movement
        MovePlayer();

    }//Update

    private void FixedUpdate()
    {
        RotateGun();
    }//FixedUpdate

    private void MovePlayer()
    {
        Vector3 movement = controls.Player.Movement.ReadValue<Vector2>() * Movement_Velocity;
        transform.position += new Vector3(movement.x, 0, movement.y) * Time.deltaTime;
    }//MovePlayer

    private void RotateGun()
    {

        Vector2 mouseScreenPosition = controls.Player.MousePosition.ReadValue<Vector2>();

        RaycastHit hit;
        Ray ray = Cam.ScreenPointToRay(Input.mousePosition); //Input.mousePosition
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.point.y <= transform.position.y)
            {
                Vector3 hitPoint = hit.point;
                hitPoint.y = transform.position.y;
                transform.LookAt(hitPoint);
            }//if
        }//if
    }//RotateGun
    
}//TD_Player_Controller
