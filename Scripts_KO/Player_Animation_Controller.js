#pragma strict

function Start () {

}

function Update () {

	if(Input.GetKey("d") || Input.GetKey("right"))
	{
		animation.Play("RunFwd");
	}
	
	else if(Input.GetKey("a") || Input.GetKey("left"))
	{
		animation.Play("RunBkwd");
	}
	
	else if(Input.GetKey("w") || Input.GetKey("up"))
	{
		animation.Play("StrafeL");
	}
	
	else if(Input.GetKey("s") || Input.GetKey("down"))
	{
		animation.Play("StrafeR");
	}
	
	else 
	{
		animation.CrossFade("Idle");
	}
}