using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        Destroy(gameObject);
    }
}
