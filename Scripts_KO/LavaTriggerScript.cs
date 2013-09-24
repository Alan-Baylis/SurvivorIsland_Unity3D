using UnityEngine;
using System.Collections;

public class LavaTriggerScript : MonoBehaviour {
	
	public Transform respawnPoint;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider other ) {
		
		if ( other.name == "Main Camera" ) {
			
			other.transform.position = respawnPoint.position;
			this.audio.pitch = Random.Range( .5f, .8f );
			this.audio.Play();
			
			
		}
		
	}
	
}
