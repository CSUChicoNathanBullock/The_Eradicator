using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pause_Script : MonoBehaviour
{

    public GameObject Pause_Menu;

    public static bool Is_Paused = false;

    // Start is called before the first frame update
    void Start()
    {
        Pause_Menu.SetActive(false);
    }//Start

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if(Is_Paused == true)
            {
                Resume_Game();
            }//if
            else
            {
                Pause_Game();
            }//else if
        }//if

    }//Update

    public void Pause_Game()
    {
        Pause_Menu.SetActive(true);
        
        Time.timeScale = 0f;
        Is_Paused = true;
    }//Pause_Game

    public void Resume_Game()
    {
        Pause_Menu.SetActive(false);
        //Debug.Log("Resuming Game");
        Time.timeScale = 1f;
        Is_Paused = false;
    }//Play_Game


    public void Go_To_Main_Menu()
    {
        Time.timeScale = 1f;
        //Debug.Log("Going back to Main Menu Game");
        SceneManager.LoadScene("Main_Menu_Scene");
        Is_Paused = false;
    }//Go_To_Main_Menu

    public void Quit_Game()
    {
        //Debug.Log("Quitting Game");
        Application.Quit();
    }//Quit_Game

}//Pause_Script
