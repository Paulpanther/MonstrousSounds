﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVisualizer : MonoBehaviour {

    public GameObject vision_pf;



	void Start () {
		
	}
	

	void Update () {
		/*if (Input.GetMouseButtonDown(0))
        {
            CreateVision(new Vector3(0,0,0));
        }*/
	}



    public void CreateVision(Vector3 position)
    {
        position += -(transform.forward) * 0.1f;
        Instantiate(vision_pf, position, Quaternion.identity);
    }
}