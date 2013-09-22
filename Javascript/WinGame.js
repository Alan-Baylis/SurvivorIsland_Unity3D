#pragma strict

var winSequence : GameObject;
var fader : GUITexture;
var winClip : AudioClip;

function Start () {

}

function Update () {

}

function GameOver ()
{
	AudioSource.PlayClipAtPoint(winClip, transform.position);
	Instantiate(winSequence);
	
	yield WaitForSeconds(8.0);
	
	Instantiate(fader);
}