using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalMover_PF5T : MonoBehaviour
{
	[SerializeField]
	Transform[] waypoints;

	[SerializeField]
	float moveSpeed = 2f;

	public bool backtrack;

	public bool destroyObjectAfter;

	public int destroyTimer;

	int waypointIndex = 0;


    void Update()
	{
		Move();
	}


	void Move()
	{
		transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

		
		if (waypointIndex < waypoints.Length - 1)
        {
			if (transform.position == waypoints[waypointIndex].transform.position)
			{
				waypointIndex++;
			}
		}


		if (backtrack == true) 
		{ 
			if (waypointIndex == waypoints.Length)
				waypointIndex = 0;
		}
		else 
        {
			if (waypointIndex == waypoints.Length)
				return;
		}
		
		if (destroyObjectAfter == true)
		{
			StartCoroutine(DestroyObject());
		}
	}

	IEnumerator DestroyObject()
    {	
		yield return new WaitForSeconds(destroyTimer);
		Destroy(gameObject);
	}

}
