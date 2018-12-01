using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScientistPerception : MonoBehaviour {

    public GameObject player;
    public float fieldOfView;
    public float MaxViewDistance;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerInFOV())
        {
            if (PlayerInLineOfSight())
            {

            }
        }
	}

    private bool PlayerInFOV()
    {
        Vector3 vecToPlayer = player.transform.position - transform.position;
        if (Vector3.Angle(vecToPlayer, -transform.up) <= fieldOfView)
        {
            return true;
        } else
        {
            return false;
        }
        
    }

    private bool PlayerInLineOfSight()
    {
        Vector3 vecToPlayer = player.transform.position - transform.position;
        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), new Vector2(vecToPlayer.x, vecToPlayer.y), MaxViewDistance);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player")){
                Debug.Log("Monster spotted at time: " + Time.time);
            }
        }
        return true;
    }
}
