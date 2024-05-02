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

    public bool Has_Shotgun = false;
    public bool Has_Sniper = false;

    public float Player_Damage;
    public float Health_Up;
    
    private Enemy playerDmg;
    private HealthPack_Script playerHeal;

    //public float Current_Health;
    //private float Max_Health = 100f;

    [SerializeField] float Health, Max_Health = 100f;

    
    [SerializeField] Player_Healthbar_Script healthbar;


    private void Start()
    {
        Has_Shotgun = false;
        Has_Sniper = false;
        Health = Max_Health;
        //Health_Text.text = "Health: " + Current_Health;

    }//Start



    private void Awake()
    {
        healthbar = GetComponentInChildren<Player_Healthbar_Script>();
        Health = Max_Health;
    }//Awake


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Red_Key")
        {
            Red_key = true;
        }//if

        if (other.tag == "Blue_Key")
        {
            Blue_Key = true;
        }//if

        if (other.tag == "Yellow_Key")
        {
            Yellow_Key = true;
        }//if

       
        if (other.tag == "Enemy")
        {
            //Debug.Log("Hitting Enemy");
            
            playerDmg = other.GetComponent<Enemy>();
           
            Damage_Player(playerDmg.Player_Damage);
            
        }//if
        
        
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


        if(other.tag == "Healthpack")
            {
                Debug.Log("Hitting Health");
               
                playerHeal = other.GetComponent<HealthPack_Script>();
                Heal_Player(playerHeal.Player_Heal);
                
            }//if
        /*
        if (other.tag == "Medium_Healthpack")
            {
                Debug.Log("Player health is:" + Health);
                Health_Up = 100;
                Heal_Player(Health_Up);
                Health_Up = 0;
            }//if
        if (other.tag == "Large_Healthpack")
            {
                Health += 25f;
                if (Health >= Max_Health)
                {
                    Health = Max_Health;
                }//if
            }//if
            */
        }//if
        
        

    }//OnTriggerEnter


    

    private void Game_Over()
    {
        Has_Shotgun = false;
        Has_Sniper = false;
        Red_key = false;
        Blue_Key = false;
        Yellow_Key = false;

        SceneManager.LoadScene("Game_Over_Menu");
        
        
    }//Game_Over

    public void Damage_Player(float Player_Damage)
    {
        
        Health -= Player_Damage;
        healthbar.Health_Update(Health, Max_Health);
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Game_Over();
        }//if
    }//Damage_Player


    public void Heal_Player(float Player_Heal)
    {
        Health += Player_Heal;
        healthbar.Health_Update(Health, Max_Health);
        if (Health >= Max_Health)
        {
            Health = Max_Health;
        }//if
    }//Heal_Player

}//Player_Inventory
