using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Flowers : MonoBehaviour
{
    public Sprite flowerSprite;

    public GameObject spritePrefab;

    private int nrOfFlowers = 100;


    private void Start()
    {
        for (int i = 0; i < nrOfFlowers; i++)
        {
            var flowerObject = Instantiate(spritePrefab);
            flowerObject.GetComponent<SpriteRenderer>().sprite = flowerSprite;
            flowerObject.transform.position = new Vector3(
                Random.Range(-12f, 12f),
                Random.Range(4.8f, 5.5f),
                Random.Range(-14f, -13f));
        }
    }
}
