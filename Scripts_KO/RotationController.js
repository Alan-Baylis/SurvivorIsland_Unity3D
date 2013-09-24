#pragma strict

var rotationState : boolean = true;
public var rotationSpeed : float = 20;
internal var startSpeed : float;

function Start () {
	
	startSpeed = rotationSpeed;
}

function Update () 
{
	if (rotationState == true && rotationSpeed > 5) {
		transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
	}
}

function OnMouseDown ()
{
	if (rotationState) {
		rotationState = false;
	}
	else if (rotationState == false) {
		rotationState = true;
	}
	
//	print("State = " + rotationState);

	rotationSpeed-=0.5;
	
	if (rotationSpeed < 0)
	{
		rotationSpeed = startSpeed;
	}
}