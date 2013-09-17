#pragma strict

var bullet: Rigidbody;
var power : float = 1500;
var movespeed : float = 2;

function Update () {

	var h : float = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
	var v : float = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
	
	transform.Translate(h,v,0);
	
	if (Input.GetButtonUp("Fire1")) 
	{
		//Create an instance of the bullet
		var instance : Rigidbody = Instantiate(bullet,transform.position,transform.rotation);
		
		// Add force to the instantiated object
		var fwd : Vector3 = transform.TransformDirection(Vector3.forward);
		
		instance.AddForce(fwd * power);
	}
}