using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Inventory : MonoBehaviour
{

    public bool Red_key = false;
    public bool Blue_Key = false;
    public bool Yellow_Key = false;

    //private bool Player_Alive = true;

    public bool Has_Shotgun = false;
    public bool Has_Sniper = false;


    //public Shoot_Script check_shotgun;

    //[SerializeField] public Text Health_Text;

    //public float Current_Health;
    //private float Max_Health = 100f;

    [SerializeField] float Health, Max_Health = 100f;

    [SerializeField] Enemy_Health_Bar healthbar;


    private void Start()
    {
        Has_Shotgun = false;
        Has_Sniper = false;
        Health = Max_Health;
        //Health_Text.text = "Health: " + Current_Health;
    }//Start



    private void Awake()
    {
        healthbar = GetComponentInChildren<Enemy_Health_Bar>();
    }//Awake
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Red_Key")
        {
            Red_key = true;
            Destroy(other.gameObject);
        }//if

        if (other.tag == "Blue_Key")
        {
            Blue_Key = true;
            Destroy(other.gameObject);
        }//if

        if (other.tag == "Yellow_Key")
        {
            Yellow_Key = true;
            Destroy(other.gameObject);
        }//if

        /*
        if (other.tag == "Enemy")
        {
            Current_Health -= 10f;

            if(Current_Health <= 0f)
            {
                Game_Over();
            }//if
            
        }//if
        */
        
        if (other.tag == "Sniper")
        {
            Has_Sniper = true;
            Has_Shotgun = false;
            if(Has_Shotgun == true)
            {
                Has_Sniper = true;
                Has_Shotgun = false;
            }//if
            
        }//if
        

        if(other.tag == "Shotgun")
        {
            Has_Shotgun = true;
            Has_Sniper = false;
            if(Has_Sniper == true)
            {
                Has_Shotgun = true;
                Has_Sniper = false;
            }//if


        if(other.tag == "Small_Healthpack")
            {
                Health += 5f;
                if(Health >= Max_Health)
                {
                    Health = Max_Health;
                }//if
            }//if

        if (other.tag == "Medium_Healthpack")
            {
                Health += 15f;
                if (Health >= Max_Health)
                {
                    Health = Max_Health;
                }//if
            }//if
        if (other.tag == "Large_Healthpack")
            {
                Health += 25f;
                if (Health >= Max_Health)
                {
                    Health = Max_Health;
                }//if
            }//if
        }//if
        
        

    }//OnTriggerEnter


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Health -= 10f;

            if (Health <= 0f)
            {
                Game_Over();
            }//if

        }//if
    }//OnTriggerStay


    

    private void Game_Over()
    {
        Has_Shotgun = false;
        Has_Sniper = false;
        Red_key = false;
        Blue_Key = false;
        Yellow_Key = false;

        SceneManager.LoadScene("Game_Over_Menu");
        
        
    }//Game_Over

    /*
    public void Set_Health()
    {
        Health_Text.text = "Health: " + Current_Health;
    }//Set_Health
    */

}//Player_Inventory
