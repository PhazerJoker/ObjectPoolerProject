using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public Rigidbody2D shipRB;
  public float moveSpeed = .2f;
  void Update()
  {
    Vector3 xMove = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
    Vector3 yMove = new Vector3(0.0f,Input.GetAxis("Vertical"), 0.0f);
    //transform.position = transform.position + xMove * moveSpeed;
    //transform.position = transform.position + yMove * moveSpeed;
    shipRB.MovePosition(transform.position + yMove * moveSpeed+xMove * moveSpeed);
  }
}
