﻿using UnityEngine;
using System.Collections;

public class História : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Application.LoadLevel ("Tutorial"); 
		}
	}
}