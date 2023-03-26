using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeleAnimation : MonoBehaviour 
{
public Animator anim;
//public float speed=0.2f;
public Transform[] points;
public NavMeshAgent navAgent;
private int pointcount=1;
    // Start is called before the first frame update
    void Start()
    { //10
	navAgent.SetDestination(points[0].position);
	anim.SetTrigger("Walk");        
    }

    // Update is called once per frame
    void Update()
    {
	//if(navAgent.remainingDistance == navAgent.stoppingDistance)
	  //{
		
		//if(pointcount==3){ //20
		//pointcount=0;
		//}
		//navAgent.SetDestination(points[pointcount].position);
		//pointcount=pointcount+1;
		//Debug.Log("Working");		
	  //}
}
}
