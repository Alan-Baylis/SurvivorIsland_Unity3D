using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {
	
	GameObject currentDoor;
	
								// Old PlayerCollisions Code prior to Raycast Change	
//	// Boolean to determine if door is open. On start, the door should be closed hence the 'false' initialization
//	bool doorIsOpen = false;
//	
//	// Counter/Timer to determine how long door remains open upon trigger
//	float doorTimer = 0.0f;
//	
//	// public float allowing me to adjust how long door must be open in the Inspector
//	public float doorOpenTime = 3.0f;
//	
//	//Audio
//	public AudioClip doorOpenSound;
//	public AudioClip doorShutSound;
//
//	// Use this for initialization
//	void Start () {
//	
//	}
	
	
	void Update () {
		
		
	
		
		
		
	
	RaycastHit hit;
		
		if (Physics.Raycast (transform.position, transform.forward, out hit, 3))
		{
			if (hit.collider.gameObject.tag=="playerDoor")
			{
				currentDoor = hit.collider.gameObject;
				currentDoor.SendMessage("DoorCheck");
			}
		}
		
		
								// Old PlayerCollisions Code prior to Raycast Change
//		if(doorIsOpen)
//		{
//			doorTimer+= Time.deltaTime;
//			
//			if (doorTimer > doorOpenTime)
//			{
//				//ShutDoor(currentDoor);
//				Door(doorShutSound, false,"doorshut", currentDoor);
//				doorTimer = 0.0f;
//			}
//		}
	}
	

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
// Old Functions during my Collison Detection Days
	
/*//Collision Detection Function
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false)
		{
			currentDoor = hit.gameObject;
			//OpenDoor(currentDoor);
			
			Door (doorOpenSound, true, "dooropen", currentDoor);
		}
	}
*/
	
// The OpenDoor & ShutDoor Functions	
//	void OpenDoor(GameObject door)
//	{
//		doorIsOpen = true;
//		door.audio.PlayOneShot(doorOpenSound);
//		door.transform.parent.animation.Play("dooropen");
//	}
//	
//	void ShutDoor(GameObject door)
//	{
//		doorIsOpen = false;
//		door.audio.PlayOneShot(doorShutSound);
//		door.transform.parent.animation.Play("doorshut");
//	}
			
// Old PlayerCollisions Code prior to Raycast Change
//	void Door(AudioClip aClip, bool openCheck, string animName, GameObject thisDoor)
//	{
//		thisDoor.audio.PlayOneShot(aClip);
//		doorIsOpen = openCheck;
//		thisDoor.transform.parent.animation.Play(animName);
//	}
}
