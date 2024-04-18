using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Health_Bar : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void Health_Update(float Current_Health, float Max_Health)
    {
        slider.value = Current_Health / Max_Health;
    }//Health_Update

    private void Update()
    {
        
    }//Update

}//Enemy_Health_Bar
