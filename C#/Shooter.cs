using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	// Variables
	
	public Rigidbody bullet;
	public float power = 1500f;
	public float movespeed = 2f;
	
	// Update is called once per frame
	void Update () {
		
		// Control the movement of the camera|position of the projectile
		float h =Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
		float v =Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
		
		transform.Translate(h,v,0);
		
		if (Input.GetButtonUp("Fire1")) 
		{
			//Create an instance of the bullet
			Rigidbody instance = Instantiate(bullet,transform.position,transform.rotation) as Rigidbody; 
			
			//Add force to the instantiated object
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			
			instance.AddForce(fwd * power);
		}
	
	}
}
