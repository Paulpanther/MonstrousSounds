using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementController : MonoBehaviour {

    public float playerSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey("up"))
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }

	}

    private void FixedUpdate()
    {
        
    }
}
