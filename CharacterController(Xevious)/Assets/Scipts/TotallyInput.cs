using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meowie;
//Script written by Michael Douglas
//This scripts purpose is to collect input from the user and move it to a outside script

//Namespace to contain the script in a database
namespace Meowie
{
//This script requires a game object in the Movement Variable
[RequireComponent(typeof(GameObject))]

public class TotallyInput : MonoBehaviour
{

    //A Movement Variable to store data
    [Tooltip("You will need to add the game object receiving input into this place")]
    public Movement muv; 

    //Update is called once per frame
    void Update()
    {
        //New Vector3 "m" is getting input from the user of horizontal and vertical movement and turning those into x and y values
        Vector3 m = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0.0f);
        //Movement varialbe "muv" takes the values from Vector3 "m" and puts them into the "Muv" public class
        muv.Muv(m);
    }


    public void FixedUpdate()
    {
        if (muv == null)
        Debug.LogError("You are missing a Game Object in the Movement Variable!");
    }
}
}
