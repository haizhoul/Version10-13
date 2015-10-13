using UnityEngine;
using System.Collections;

public class NPCnav : MonoBehaviour {
	
	
	public Transform target;
	private NavMeshAgent navMeshAgent;
	
	void Start ()
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();
	}
	
	void Update ()
	{
		navMeshAgent.destination = target.position;
	}
}
