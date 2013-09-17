#pragma strict

private var beenHit : boolean = false;
private var targetRoot : Animation;
var hitSound : AudioClip;
var resetSound : AudioClip;
var resetTime : float = 3.0f;

function Start () {
	targetRoot = transform.parent.transform.parent.animation;
}

function Update () {

}

function OnCollisonEnter(theObject : Collision)
{
	if(beenHit == false && theObject.gameObject.name == "coconut")
	{
		StartCoroutine("targetHit");
	}
}

function targetHit()  // a co-routine
{
	audio.PlayOneShot(hitSound);
	targetRoot.Play("down");
	beenHit = true;
	CoconutWin.targets++;
	
	yield new WaitForSeconds(resetTime);  // giveaway that this is a co-routine
	
	audio.PlayOneShot(resetSound);
	targetRoot.Play("up");
	CoconutWin.targets--;
	
}

@script RequireComponent(AudioSource)