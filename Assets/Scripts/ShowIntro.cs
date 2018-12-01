using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ShowIntro : MonoBehaviour {

	public Text intro;
	// Use this for initialization
	void Start () {
		Invoke("disableText", 5);
	}

	void disableText() {
		intro.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
}
