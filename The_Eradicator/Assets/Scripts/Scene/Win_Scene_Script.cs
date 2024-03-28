using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Scene_Script : MonoBehaviour
{
    public void Feedback()
    {
        //Add URL
        Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSddfYoVw1-npXbmOoEtICkR-mavt7ijTU0RL-DnVWeqYpuhcg/viewform");
    } //Play_Game

    public void Exit_Game()
    {
        Debug.Log("Quitting Game");
        Application.Quit();

    }//Exit_Game

}//Win_Scene_Script
