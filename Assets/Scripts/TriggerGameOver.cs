using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class TriggerGameOver : MonoBehaviour {

	public Text BadNews;
	// Use this for initialization
	void Start () {
		BadNews.enabled = false;
	}

	// Update is called once per frame
	public void TriggerGO () {
		BadNews.enabled = true;
	}


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
