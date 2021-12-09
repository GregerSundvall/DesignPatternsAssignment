using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    
    public TextMeshProUGUI woodUI;
    public TextMeshProUGUI waterUI;
    
    
    private string woodString = "Wood: ";
    private string waterString = "Water: ";

    private void Update()
    {
        if (Resources.AmIDirty())
        {
            UpdateUI();
        }
    }
    
    private void UpdateUI()
    {
        woodUI.text = woodString + Resources.GetWoodAmount();
        waterUI.text = waterString + Resources.GetWaterAmount();
        Resources.MakeMeClean();
    }

}
