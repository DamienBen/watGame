using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navtest : MonoBehaviour {

	public Transform[] goal;
    private NavMeshAgent agent;

	private int goalIndex;

	void Start () {
		this.agent = GetComponent<NavMeshAgent>();
		this.goalIndex = Random.Range(0, goal.Length);
		this.agent.destination = goal[this.goalIndex].position; 
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(goal[this.goalIndex].position, transform.position) <= 1f)
		{
			Debug.Log(goal[this.goalIndex].GetComponent<interactiveObject>().GetType());
			this.goalIndex = Random.Range(0, goal.Length);
			this.agent.destination = goal[this.goalIndex].position; 
		}
	}
}
