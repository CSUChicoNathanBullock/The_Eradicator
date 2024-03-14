using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu_Script : MonoBehaviour
{
    public void Play_Game()
    {
        SceneManager.LoadScene("Tutorial");
    } //Play_Game

    public void Exit_Game()
    {
        Debug.Log("Quitting Game");
        Application.Quit();

    }//Exit_Game


}//Main_Menu_Script
