using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Scene_Script : MonoBehaviour
{
    public void Feedback()
    {
        //Add URL
        Application.OpenURL("URL");
    } //Play_Game

    public void Exit_Game()
    {
        Debug.Log("Quitting Game");
        Application.Quit();

    }//Exit_Game

}//Win_Scene_Script
