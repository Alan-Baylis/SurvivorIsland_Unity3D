#pragma strict

function Start () {

}

function Update () 
{
	if (Physics.Raycast (transform.position, transform.forward, 10)) {
		print("There is something in front of the object!");
	}
}