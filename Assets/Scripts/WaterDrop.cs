using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    private Rain _rain;

    public void DropInit(Rain rain)
    {
        _rain = rain;
    }
    
    
    private void Update()
    {
        if (transform.position.y < -1)
        {
            _rain.ReturnObjectToPool(gameObject);
        }
    }
}
