using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {


    public void PressButton() {
        int counter = 0;

        while (counter < 5)
        {
            Debug.Log ("Hola mundo!");
            counter++;
        }

        
    }

	// Use this for initialization
	void Start () {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
