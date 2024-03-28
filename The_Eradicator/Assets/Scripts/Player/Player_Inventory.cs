using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Inventory : MonoBehaviour
{

    public bool Red_key = false;
    public bool Blue_Key = false;
    public bool Yellow_Key = false;

    private bool Player_Alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

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

        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
            Game_Over();
        }//if


    }//OnTriggerEnter

    private void Game_Over()
    {
        
            SceneManager.LoadScene("Game_Over_Menu");
        
    }//Game_Over

}//Player_Inventory
