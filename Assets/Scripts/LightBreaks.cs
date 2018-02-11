﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreaks : MonoBehaviour {
    Light fanLamp;
    bool gotItem = false; 
	// Use this for initialization
	void Start () {
        fanLamp = GetComponent<Light>();
    }
    IEnumerator BreakLightBulb()
    {
        fanLamp.enabled = true; 
        yield return new WaitForSecondsRealtime(5);
        fanLamp.enabled = false;
        BroadcastMessage("Appear"); 
    }

    public void Clicked()
    {
        print("Recieved!");
        if (gotItem == false)
        {
            GameObject BrokenLightBulb = GameObject.Find("LightSource");
            Light BLBProperty = BrokenLightBulb.GetComponent<Light>();
            BLBProperty.enabled = true; 
        }
        gotItem = true;

    }
}
