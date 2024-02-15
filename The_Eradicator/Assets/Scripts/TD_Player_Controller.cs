using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TD_Player_Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private float Movement_Velocity = 3f;

    [SerializeField]
    private Transform Bullet_Direction;
    private bool canShoot = true;
    private Camera main;

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
        main = Camera.main;
        controls.Player.Shoot.performed += _ => PlayerShoot();
    }//Start

    private void PlayerShoot()
    {
        if (!canShoot) return;
        


            Vector2 MousePosition = controls.Player.MousePosition.ReadValue<Vector2>();
            MousePosition = Camera.main.ScreenToWorldPoint(MousePosition);
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
        Vector2 mouseScreenPosition = controls.Player.MousePosition.ReadValue<Vector2>();
        Vector3 MouseWorldPosition = main.ScreenToWorldPoint(mouseScreenPosition);
        Vector3 targetDirection = MouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle) );
        //Debug.Log("Mouse position is: " + mouseScreenPosition);

        //Movement
        Vector3 movement = controls.Player.Movement.ReadValue<Vector2>() * Movement_Velocity;
        transform.position += movement * Time.deltaTime;

    }//Update

}//TD_Player_Controller
