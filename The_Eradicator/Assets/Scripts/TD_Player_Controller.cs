using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TD_Player_Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private float Movement_Velocity = 3f;

    [SerializeField]
    private Transform Bullet_Direction;
    private bool canShoot = true;
    public Camera Cam;

    private Vector2 mousePos;

    public Rigidbody body;

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
        controls.Player.Shoot.performed += _ => PlayerShoot();
    }//Start

    private void PlayerShoot()
    {
        if (!canShoot) return;

        

            Vector2 mousePosition = controls.Player.MousePosition.ReadValue<Vector2>();
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //Debug.Log("mouse position is " + mousePosition);
            GameObject g = Instantiate(Bullet, Bullet_Direction.position, Bullet_Direction.rotation);
            g.SetActive(true);
        StartCoroutine(CanShoot());
        
    }//PlayerShooot

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(.5f);
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
