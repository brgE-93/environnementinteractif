﻿using UnityEngine;
using System.Collections;

public class destroyKillButerfly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		GameObject.Destroy (gameObject, 3);
	}
}
