﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Se ocupa de miscarea de rotatie a dovleacului rotativ
 */
public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * 0.15f;
		transform.Rotate(0, 0, -10);
	}
}