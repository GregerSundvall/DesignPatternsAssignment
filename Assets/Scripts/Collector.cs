using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public UiManager uiManager;

    private Dictionary<string, Action> actions = new Dictionary<string, Action>();


    private void Start()
    {
        actions.Add("Tree", Resources.AddWood);
        actions.Add("Raindrop", Resources.AddWater);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            
            if (Physics.Raycast(ray, out hitInfo))
            {
                ICollectable collectable = hitInfo.collider.GetComponent<ICollectable>();
                if (collectable != null)
                {
                    SaveResourcesByTag(hitInfo.transform.gameObject);
                    collectable.Collect();
                    
                }
            }
        }
    }
    
    private void SaveResourcesByTag(GameObject collectable)
    {
        foreach (var action in actions)
        {
            if(collectable.CompareTag(action.Key))
            {
                action.Value();
                break;
            }
        }
    }
    
    private void CollectWood()
    {
        Resources.AddWood();
    }
    
    private void CollectWater()
    {
        Resources.AddWater();
    }
    
    
}
