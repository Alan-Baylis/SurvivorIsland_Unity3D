#pragma strict

var speed : float = 6.0;
var jumpSpeed : float = 8.0;
var gravity : float = 20.0;

var moveDirection : Vector3 = Vector3.zero;

function Start () {

}

function Update () 
{

var controller : CharacterController = GetComponent(CharacterController);

if (controller.isGrounded)
	{
		moveDirection = Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));  //Allow for player input
		moveDirection = transform.TransformDirection (moveDirection);  //How to move
		moveDirection *= speed;  //How fast to move		
		
				if(Input.GetButton("Jump"))	
				{
					moveDirection.y = jumpSpeed;
				}	
	}

// Apply gravity to the player
moveDirection.y -= gravity *Time.deltaTime;

controller.Move(moveDirection * Time.deltaTime);  //Move the controller
	

}
