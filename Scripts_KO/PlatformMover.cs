using UnityEngine;
using System.Collections;

public class PlatformMover : MonoBehaviour {

	// Use this for initialization
	Vector3 startPos;
	
	public float speed = 1.0f;
	public float range = 1.0f;
	
	void Start () {
		
		startPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = startPos + Vector3.right * ( Mathf.Sin( Time.fixedTime * speed ) * range );
		
	}
}
