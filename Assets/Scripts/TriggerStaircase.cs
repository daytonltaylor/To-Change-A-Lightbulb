﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStaircase : MonoBehaviour {

    public float speed = -0.1f; 
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
    }
    
    public void Appear()
    {
        for (int i = 0; i < 10; i++)
        {
            transform.Translate(0, 0, (speed));
        }
    }
}
