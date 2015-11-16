﻿using UnityEngine;
using System.Collections;

public class PresentCounter : MonoBehaviour {

	public int presentMissing =0;
	public int presentHit =1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "House") {
			//if no present
			if(!other.gameObject.GetComponent<HouseScript>().presentHit){
				presentMissing++;
			}else{
				//present 
				presentHit++;
			}
		}

		
	}
}
