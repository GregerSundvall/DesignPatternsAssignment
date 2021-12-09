using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Resources : MonoBehaviour
{
    public static Resources Instance { get; private set; }
    
    
    
    static int woodAmount = 0;
    static int waterAmount = 0;
    static bool dirty = false;
    

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            
        }
    }
    
    public static bool AmIDirty()
    {
        return dirty;
    }
      
    public static void MakeMeClean()
    {
        dirty = false;
    }
    
    public static int GetWoodAmount()
    {
        return woodAmount;
    }
    
    public static int GetWaterAmount()
    {
        return waterAmount;
    }

    public static void AddWood()
    {
        woodAmount++;
        dirty = true;
    }
    
    public static void AddWater()
    {
        waterAmount++;
        dirty = true;
    }
}
