using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenScript : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {

		RegenHealth();
	}
	
	void RegenHealth() {
		while( true ) {
			health += 1;
			Debug.Log( "My health is " + health );
		}
	}
}
