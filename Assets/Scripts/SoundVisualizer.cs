using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVisualizer : MonoBehaviour {

    public GameObject vision_pf;
    public GameObject soundWaves_pf;


	void Start () {
		
	}
	

	void Update () {
        
	}



    public void CreateVision(Vector3 position)
    {
        position += -(transform.forward) * 0.1f;
        Instantiate(vision_pf, position, Quaternion.identity);
    }

    public void CreateSoundWaves(Vector3 position)
    {
        position += -(transform.forward) * 0.3f;
        Instantiate(soundWaves_pf, position, Quaternion.identity);
        //you may take a reference to the object and edit the particlesystem based on some extra parameters...
    }
}
