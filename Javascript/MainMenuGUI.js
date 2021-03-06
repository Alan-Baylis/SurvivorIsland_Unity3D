﻿#pragma strict

var beep : AudioClip;
var menuSkin : GUISkin;
var menuArea : Rect;
var playButton : Rect;
var instructionsButton : Rect;
var quitButton : Rect;

private var menuAreaNormalized : Rect;
private var menuPage : String = "main";

var instructions : Rect;

var startObj : GameObject;

function Start () 
{
 menuAreaNormalized = Rect (menuArea.x * Screen.width - (menuArea.width * 0.5f), menuArea.y * Screen.height - (menuArea.height * 0.5f), menuArea.width, menuArea.height);
}


function OnGUI ()
{
	GUI.skin = menuSkin;
	GUI.BeginGroup(menuArea);
	
	if(menuPage == "main")
	{
	
		if(GUI.Button (Rect (playButton), "Play"))
		{
			//ButtonAction("Island");
			fadeButtonAction();
		}
		
		if(GUI.Button (Rect (instructionsButton), "Instructions"))
		{
			audio.PlayOneShot(beep);
			menuPage = "instructions";
		}
		
		if(GUI.Button (Rect (quitButton), "Quit"))
		{
			ButtonAction("quit");
		}
	}
	
	else if (menuPage == "instructions")
	{
		GUI.Label (Rect(instructions), "You awake on a mysterious island..."+
		"Find a way to signal for help or face certain doom!");
		
		if(GUI.Button(Rect(quitButton), "Back")) 
		{
			audio.PlayOneShot(beep);
			menuPage = "main";
		}
		
		
	}
	
	GUI.EndGroup();
}

function ButtonAction (levelName : String)
{
	audio.PlayOneShot(beep);
	
	yield new WaitForSeconds(0.35);
	
	if (levelName != "quit")
	{
		Application.LoadLevel(levelName);
	}
	else
	{
		Application.Quit();
		Debug.Log("Have Quit");
	}
}

function fadeButtonAction ()
	{
		audio.PlayOneShot(beep);
		
		yield new WaitForSeconds(0.35f);
		
		startObj.SendMessage("LetsBegin");
	}

@script RequireComponent(AudioSource)