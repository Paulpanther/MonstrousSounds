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
        //if (PlayerInFOV())
        {
            if (PlayerInLineOfSight())
            {
                Camera.main.GetComponent<TriggerGameOver>().TriggerGO();
            }
        }
	}

    private bool PlayerInFOV()
    {
        Vector3 vecToPlayer = player.transform.position - transform.position;
        if (Vector3.Angle(vecToPlayer, transform.up) <= fieldOfView)
        {
            return true;
        } else
        {
            return false;
        }
        
    }

    private bool PlayerInLineOfSight()
    {
        Vector2 pos2d = new Vector2(transform.position.x, transform.position.z);
        Vector3 vecToPlayer = player.transform.position - new Vector3(transform.position.x, transform.position.z, 0);
        RaycastHit2D hit = Physics2D.Raycast(pos2d, new Vector2(vecToPlayer.x, vecToPlayer.y), MaxViewDistance);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player")){
                return true;
                
            }
        }
        return false;
    }
}
