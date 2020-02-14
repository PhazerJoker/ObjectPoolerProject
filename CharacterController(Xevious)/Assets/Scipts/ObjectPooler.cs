using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler instance;
    public GameObject objectToPool;
    public int amountToPool;
    public bool canGrow;
    List<GameObject> pooledObjects;
    void Awake(){//So we may not even want to use a singleton here? Singleton means only one pooler.
        //But one of the reasons to use this script is to let a bunch of enemies all use it for one bullet type, and then another instance of this class for another object type
        instance = this;
    }
    void Start()
    {
        //Instantiate list.
        pooledObjects = new List<GameObject>();
        //Create the list of inactive objects.
        for(int i = 0;i<amountToPool;i++){
            GameObject tempObject = GameObject.Instantiate(objectToPool);
            tempObject.SetActive(false);
            pooledObjects.Add(tempObject);
        }
    }

    //This is a simple example so lets just let whomever needs this function active the object themselves, and set its position and rotation itself.
    public GameObject GetPooledObject(){
        for(int i = 0;i < pooledObjects.Count;i++){//This loop sounds slow but its not, its much faster than moving objects out of a list and into another list.
            if(!pooledObjects[i].activeInHierarchy){
                return pooledObjects[i];
            }
        }
        //dynamically resize if we need more?
        if(canGrow){
            GameObject tempObject = GameObject.Instantiate(objectToPool);
            pooledObjects.Add(tempObject);
            return tempObject;
        }
        //uh, no available bullet in our pooling system was found or created. sorry.
        return null;
    }
}