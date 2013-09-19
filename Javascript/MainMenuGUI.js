#pragma strict

var beep : AudioClip;
var menuSkin : GUISkin;
var menuArea : Rect;
var playButton : Rect;
var instructionsButton : Rect;
var quitButton : Rect;

var menuAreaNormalized : Rect;

function Start () 
{

}

function Update () 
{

}

function OnGUI ()
{
	GUI.skin = menuSkin;
	GUI.BeginGroup(menuArea);
	
	if(GUI.Button (Rect (playButton), "Play"))
	{
		audio.PlayOneShot(beep);
	}
	
	if(GUI.Button (Rect (instructionsButton), "Instructions"))
	{
		audio.PlayOneShot(beep);
	}
	
	if(GUI.Button (Rect (quitButton), "Quit"))
	{
		audio.PlayOneShot(beep);
	}
	
	GUI.EndGroup();
}

@script RequireComponent(AudioSource)