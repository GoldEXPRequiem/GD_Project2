using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Script : MonoBehaviour
{
private float speed=5f, cam_sense=100f;
private Vector3 movement;
public Camera camera;
public Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move_Horizontal=Input.GetAxisRaw("Horizontal");
	float move_Vertical=Input.GetAxisRaw("Vertical");
	movement=new Vector3(move_Horizontal, 0f, move_Vertical);
	movement=transform.TransformDirection(movement.normalized*Time.deltaTime*speed);
	transform.position += movement;
	float cameraX= Input.GetAxisRaw("Mouse X")* cam_sense *Time.deltaTime;
	Vector3 rotate = new Vector3(0, cameraX, 0);
	transform.Rotate(rotate);
	if(move_Horizontal == 0 && move_Vertical ==0){
	  animate.SetBool("Idle", true);
	  animate.SetBool("Walk", false);
	}
	else{
	  animate.SetBool("Idle", false);
	  animate.SetBool("Walk", true);
	}
	
    }
}
