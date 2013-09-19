using UnityEngine;
using System.Collections;
[RequireComponent (typeof (AudioSource))]

public class MainMenuGUI : MonoBehaviour {
	
	public AudioClip beep;
	public GUISkin menuSkin;
	public Rect menuArea;
	public Rect playButton;
	public Rect instructionsButton;
	public Rect quitButton;
	
	Rect menuAreaNormalized;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI ()
	{
		GUI.skin = menuSkin;
		GUI.BeginGroup(menuArea);
		
		if (GUI.Button (new Rect (playButton), "Play"))
		{
			audio.PlayOneShot(beep);
		}
		
		if (GUI.Button (new Rect (instructionsButton), "Instructions"))
		{
			audio.PlayOneShot(beep);
		}
		
		if (GUI.Button (new Rect (quitButton), "Quit"))
		{
			audio.PlayOneShot(beep);
		}
		
		GUI.EndGroup();
	}
}
