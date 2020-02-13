using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meowie;
//Script written by Michael Douglas
//This scripts purpose is to use an input script to move a 2D sprite on the X and Y planes

//Namespace to contain the script in a database
namespace Meowie{

// PlayerScript requires a 2D Rigidbody and Float Input
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(float))]

public class Movement : MonoBehaviour
{
  //One 2D rigidbody is needed to run this script
  [Tooltip("This is a 2D Rigidbody Variable, Add a 2D Rigid body here")]
  public Rigidbody2D shipRB;

  //The movement speed is set to a comfortable .2 but is able to be changed to feel in the Unity inspector
  [Tooltip("This variable controls the speed of the 2D Rigidbody, This variable can take any number (Tip: Dont go to crazy)")]
  public float moveSpeed = .2f;

  //A public class calling on the information from the input script that outputs a new Vector3
  public void Muv(Vector3 move)
  {
    //Moving the rigidbody using trasform position plus the move Vector3 and the move speed variable
    shipRB.MovePosition(transform.position + move * moveSpeed);
  }

  public void FixedUpdate()
  {
    if (shipRB == null)
    Debug.LogError("You are missing a Rigidbody!");
    if (moveSpeed == 0)
    Debug.LogError("You are missing a Movement Speed!");
  }



}
}
