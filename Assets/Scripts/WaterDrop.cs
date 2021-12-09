using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    private Fountain fountain;

    public void DropInit(Fountain spawner)
    {
        fountain = spawner;
    }
    
    
    private void Update()
    {
        if (transform.position.y < -5)
        {
            fountain.ReturnObjectToPool(gameObject);
        }
    }
}
