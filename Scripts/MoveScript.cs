using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;

	// Use this for initialization
	void Start () {
        //this.moveSpeed = 1;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, Space.World);
        transform.Translate(moveSpeed * joystick.Horizontal * Time.deltaTime, 0f, moveSpeed * joystick.Vertical * Time.deltaTime, Space.World);
        //transform.position.Set(transform.position.x, -12.59257, transform.position.z);

    }
}
