using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Healthbar_Script : MonoBehaviour
{
    [SerializeField] Slider Slider;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;

    public void Health_Update(float Current_Health, float Max_Health)
    {
        Slider.value = Current_Health / Max_Health;

    }//Health_Update

     void Update()
    {
        transform.rotation = camera.transform.rotation;
        transform.position = target.position;
    }//Update


}//Player_Healthbar_Script
