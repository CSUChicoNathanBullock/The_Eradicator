using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager_Script : MonoBehaviour
{
    public Text Health_Text;

    public int Current_Health;
    private int Max_Health = 100;


    // Start is called before the first frame update
    void Start()
    {
        Current_Health = Max_Health;
    }//Start

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Set_Health(int Current_health)
    {
        Health_Text.text = "Health: " + Current_Health;
    }//Set_Health

}//Game_Manger_Script
