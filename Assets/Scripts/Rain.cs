using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Rain : MonoBehaviour
{

    private Queue<GameObject> objectPool;
    public GameObject dropPrefab;
    private int poolSize = 1500;

    
    private void Start()
    {
        PoolWarmUp();
        
    }


    private void Update()
    {
        for (int i = 0; i < objectPool.Count; i++)
        {
            var drop = GetObjectFromPool();
            drop.GetComponent<WaterDrop>().DropInit(this);
            drop.transform.position = new Vector3(
                Random.Range(-15f, 15f),
                Random.Range(15f, 25f),
                Random.Range(-15f, 15f));
        }

    }


    private GameObject GetObjectFromPool()
    {
        if (objectPool.TryDequeue(out var drop))
        {
            drop.GetComponent<MeshRenderer>().enabled = true;
            return drop;
        }
        return Instantiate(dropPrefab);
    }
    
    public void ReturnObjectToPool(GameObject drop)
    {
        drop.GetComponent<MeshRenderer>().enabled = false;
        objectPool.Enqueue(drop);
    }
    
    
    private void PoolWarmUp()
    {
        objectPool = new Queue<GameObject>();

        for (var i = 0; i < poolSize; i++)
        {
            var drop = Instantiate(dropPrefab);
            drop.GetComponent<MeshRenderer>().enabled = false;
            objectPool.Enqueue(drop);
        }
    }
}
