using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meowie;


    

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler instance;
    List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public bool canGrow = true;
    void Awake()
    {
        instance = this;
    }
    void OnEnable()
    {
        pooledObjects = new List<GameObject>();
        for(int i = 0;i<amountToPool;i++){
            GameObject tempObject = GameObject.Instantiate(objectToPool);
            tempObject.SetActive(false);
            pooledObjects.Add(tempObject);
        }
    }

   
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        
        if(canGrow)
        {
            GameObject tempObject = GameObject.Instantiate(objectToPool);
            tempObject.SetActive(false);
            pooledObjects.Add(tempObject);
            return tempObject;
        }

        else
        {
        return null;
        }
    }
}